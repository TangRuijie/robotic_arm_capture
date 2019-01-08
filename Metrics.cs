using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticArmCapture
{
    class Metrics
    {
        public static int stepsPerUnit = 20;
        public static int divide = 16;
        public static double anglePerStep = 1.8;

        public static double degreePerUnit = Metrics.anglePerStep / Metrics.divide * Metrics.stepsPerUnit;
        public static double unitPerDegree = 1.0 / degreePerUnit;
    }
}
