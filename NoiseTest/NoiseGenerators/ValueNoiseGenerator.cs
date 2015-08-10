using NoiseTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    public class ValueNoiseGenerator : INoiseGenerator
    {
        public Interpolation InterpolationToUse { get; set; }
        public int Seed { get; set; }
        public double Frequency { get; set; }
        public int Octaves { get; set; }
        public double Persistance { get; set; }

        private Random gen;
        private double amplitude;
        private double mFrequency;
        private int mRandomOffsetX, mRandomOffsetY;

        private double generatePoint(double x, double y)
        {
            int intX = (int)x;
            double fractX = x - intX;
            int intY = (int)y;
            double fractY = y - intY;

            double vert1 = RandomNumberGenerator.GetValue(intX, intY);
            double vert2 = RandomNumberGenerator.GetValue(intX + 1, intY);
            double vert3 = RandomNumberGenerator.GetValue(intX, intY + 1);
            double vert4 = RandomNumberGenerator.GetValue(intX + 1, intY + 1);
            double vert5 = 0.0;
            double vert6 = 0.0;
            double vert7 = 0.0;
            double vert8 = 0.0;
            double i3 = 0.0;
            double i4 = 0.0;
            if (InterpolationToUse == Interpolation.CUBIC)
            {
                vert5 = RandomNumberGenerator.GetValue(intX - 1, intY);
                vert6 = RandomNumberGenerator.GetValue(intX + 2, intY);
                vert7 = RandomNumberGenerator.GetValue(intX - 1, intY + 1);
                vert8 = RandomNumberGenerator.GetValue(intX + 2, intY + 1);
            }

            double i1 = InterpolationFunctions.Interpolate(InterpolationToUse, fractX, vert1, vert2, vert5, vert6);
            double i2 = InterpolationFunctions.Interpolate(InterpolationToUse, fractX, vert3, vert4, vert7, vert8);
            if(InterpolationToUse == Interpolation.CUBIC)
            {

            }

            return InterpolationFunctions.Interpolate(InterpolationToUse, i1, i2, fractY, i3, i4);
        }

        public double getValue(params double[] location)
        {
            double total = 0.0;
            double x = location[0], y = location[1];

            for (int i = 0; i < Octaves; i++)
            {
                total += generatePoint(x * mFrequency + mRandomOffsetX, y * mFrequency + mRandomOffsetY) * amplitude;
                mFrequency *= 2;
                amplitude *= Persistance;
            }

            if(total < 0.0)
            {
                total = 0.0;
            }
            if(total > 1.0)
            {
                total = 1.0;
            }
            return total;
        }

        public void Init()
        {
            gen = new Random(Seed);
            mRandomOffsetX = gen.Next(100000);
            mRandomOffsetY = gen.Next(100000);
            amplitude = Persistance;
            mFrequency = Frequency;
        }
    }
}
