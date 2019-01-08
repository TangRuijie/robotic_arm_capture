using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace RoboticArmCapture
{
    class EmailNotification
    {
        const string fromPassword = "trj(())0";
        const string subject = "Capture Finished! | RoboticArmCapture V1.0";
        const string body = "This session of images recording has already finished! Please come back here to check the data!";

        public static MailAddress fromAddress = new MailAddress("jerrytang2015013240@gmail.com", "RoboticArmCapture");
        public static MailAddress toAddress = new MailAddress("jerrytang2015013240@gmail.com", "Jerry Tang");

        public static void sendNotification()
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
