using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RoboticArmCapture
{
    class GoProControl
    {
        public static GoProCamera goPro;
        public static Process ffplay;
        public static bool streaming = false;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public static async Task Trigger()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.5.5.9/gp/gpControl/command/shutter?p=1";
                var responseString = await client.GetStringAsync(url);
                goPro.addLog(url + " ==> " + responseString + "\r\n");
            }
        }

        public static async Task<List<string>> GetMediaList()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.5.5.9/gp/gpMediaList";
                var responseString = await client.GetStringAsync(url);
                goPro.addLog(url + " ==> SUCCESS" + "\r\n");
                dynamic mediaList = JsonConvert.DeserializeObject(responseString);
                List<string> paths = new List<string>();
                foreach (dynamic m in mediaList.media)
                {
                    string directory = m.d;
                    foreach (dynamic file in m.fs)
                    {
                        string filename = file.n;
                        paths.Add("/" + directory + "/" + filename);
                    }
                }
                return paths;
            }
        }

        public static async Task<Image> GetImage(string url)
        {
            using (var client = new HttpClient())
            {
                var responseStream = await client.GetStreamAsync(url);
                return Image.FromStream(responseStream);
            }
        }

        public static async Task<Image> GetThumbnail(string path)
        {
            using (var client = new HttpClient())
            {
                string url = string.Format("http://10.5.5.9:8080/gp/gpMediaMetadata?p={0}", path);
                var responseStream = await client.GetStreamAsync(url);
                return Image.FromStream(responseStream);
            }
        }

        public static void StopStreaming()
        {
            if (ffplay != null)
                ffplay.Kill();
            streaming = false;
        }

        public static async Task WaitProcessingDone()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.5.5.9/gp/gpControl/status";
                while (true)
                {
                    var responseString = await client.GetStringAsync(url);
                    dynamic camStatus = JsonConvert.DeserializeObject(responseString);
                    if (camStatus.status["8"] == 0)
                        break;
                    await Task.Delay(500);
                }
            }
        }

        public static async Task StartStreaming()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.5.5.9/gp/gpControl/execute?p1=gpStream&a1=proto_v2&c1=restart";
                var responseString = await client.GetStringAsync(url);
                goPro.addLog(url + " ==> " + responseString + "\r\n");
                url = "http://10.5.5.9/gp/gpControl/status";
                for (int i = 0; i < 5; i++)
                {
                    responseString = await client.GetStringAsync(url);
                }
                goPro.addLog(url + " ==> " + responseString + "\r\n");
                ffplay = new Process();
                ffplay.StartInfo.FileName = "ffplay.exe";
                ffplay.StartInfo.Arguments = "-fflags nobuffer -f:v mpegts -probesize 8192 udp://10.5.5.9:8554";
                ffplay.StartInfo.CreateNoWindow = true;
                ffplay.StartInfo.RedirectStandardOutput = true;
                ffplay.StartInfo.UseShellExecute = false;
                ffplay.Start();

                string message = "_GPHD_:0:0:2:0.000000\n";
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPAddress serverAddr = IPAddress.Parse("10.5.5.9");
                IPEndPoint endPoint = new IPEndPoint(serverAddr, 8554);
                streaming = true;
                Task.Factory.StartNew(async () =>
                {
                    await Task.Delay(3000);
                    SetParent(ffplay.MainWindowHandle, goPro.getStreamingPanel().Handle);
                    MoveWindow(ffplay.MainWindowHandle, 0, 0, goPro.getStreamingPanel().Width, goPro.getStreamingPanel().Height, true);
                });
                while (streaming)
                {
                    sock.SendTo(Encoding.UTF8.GetBytes(message), endPoint);
                    await Task.Delay(2500);
                }
            }
        }

        public static async Task DeleteFile(string path)
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.5.5.9/gp/gpControl/command/storage/delete?p=" + path;
                var responseString = await client.GetStringAsync(url);
                goPro.addLog(url + " ==> " + responseString + "\r\n");
            }
        }

        public static async Task Sleep()
        {
            using (var client = new HttpClient())
            {
                string url = "http://10.5.5.9/gp/gpControl/command/system/sleep";
                var responseString = await client.GetStringAsync(url);
                goPro.addLog(url + " ==> " + responseString + "\r\n");
            }
        }
    }
}
