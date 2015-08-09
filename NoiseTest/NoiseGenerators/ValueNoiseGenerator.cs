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

        public double getValue(params double[] location)
        {
            double total = 0.0;
            double x = location[0], y = location[1];

            for (int i = 0; i < Octaves; i++)
            {
                //total += RandomNumberGenerator.GetValue(x * mFrequency + mRandomOffsetX, y * mFrequency + mRandomOffsetY) * amplitude;
                mFrequency *= 2;
                amplitude *= Persistance;
            }

            return total > 1.0 ? 1.0 : total;
        }

        public void Init()
        {
            gen = new Random(Seed);
            mRandomOffsetX = gen.Next();
            mRandomOffsetY = gen.Next();
            amplitude = Persistance;
            mFrequency = Frequency;
        }
    }
}
