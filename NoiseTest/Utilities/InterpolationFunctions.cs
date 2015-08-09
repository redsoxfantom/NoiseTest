using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.Utilities
{
    public class InterpolationFunctions
    {
        public static double Interpolate(Interpolation interpolationToUse, double currentXVal, double startYVal, double endYVal)
        {
            switch(interpolationToUse)
            {
                case Interpolation.LINEAR:
                    return LinearlyInterpolate(currentXVal, startYVal, endYVal);
                default:
                    return 0.0;
            }
        }

        private static double LinearlyInterpolate(double currentXVal, double startYVal, double endYVal)
        {
            return (1 - currentXVal) * startYVal + currentXVal * endYVal;
        }
    }

    public enum Interpolation
    {
        LINEAR,
        COSINE,
        CUBIC
    }
}
