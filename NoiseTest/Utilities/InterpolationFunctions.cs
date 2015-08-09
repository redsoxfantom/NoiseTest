﻿using System;
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
                case Interpolation.COSINE:
                    return CosineInterpolate(currentXVal, startYVal, endYVal);
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
    }

    public enum Interpolation
    {
        LINEAR,
        COSINE,
        CUBIC
    }
}
