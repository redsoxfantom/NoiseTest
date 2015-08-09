using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.Utilities
{
    public class InterpolationFunctions
    {
        public static double Interpolate(Interpolation interpolationToUse, double currentXVal, double startYVal, double endYVal, double beforeStartYVal = 0.0, double afterEndYVal = 0.0)
        {
            switch(interpolationToUse)
            {
                case Interpolation.LINEAR:
                    return LinearlyInterpolate(currentXVal, startYVal, endYVal);
                case Interpolation.COSINE:
                    return CosineInterpolate(currentXVal, startYVal, endYVal);
                case Interpolation.CUBIC:
                    return CubicInterpolate(currentXVal, startYVal, endYVal, beforeStartYVal, afterEndYVal);
                default:
                    return 0.0;
            }
        }

        private static double LinearlyInterpolate(double currentXVal, double startYVal, double endYVal)
        {
            return (1 - currentXVal) * startYVal + currentXVal * endYVal;
        }

        private static double CosineInterpolate(double currentXVal, double startYVal, double endYVal)
        {
            double newCurrentXVal = (1 - Math.Cos(currentXVal * Math.PI)) / 2;
            return (startYVal * (1 - newCurrentXVal) + endYVal * newCurrentXVal);
        }

        private static double CubicInterpolate(double currentXVal, double startYVal, double endYVal, double beforeStartYVal, double afterEndYVal)
        {
            double currentXValSquared = currentXVal * currentXVal;
            double a0 = afterEndYVal - endYVal - beforeStartYVal + startYVal;
            double a1 = beforeStartYVal - startYVal - a0;
            double a2 = endYVal - beforeStartYVal;
            double a3 = startYVal;

            double calculatedInterp = a0 * currentXVal * currentXValSquared + a1 * currentXValSquared + a2 * currentXVal + a3;

            return calculatedInterp;
        }
    }

    public enum Interpolation
    {
        LINEAR,
        COSINE,
        CUBIC
    }
}
