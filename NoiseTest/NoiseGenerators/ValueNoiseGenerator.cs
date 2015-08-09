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

        private RandomNumberGenerator mGen;
        private double amplitude;
        private double mFrequency;

        public double getValue(params double[] location)
        {
            double total = 0.0;
            double x = location[0], y = location[1];

            for (int i = 0; i < Octaves; i++)
            {
                total += mGen.GetValue(x * mFrequency, y * mFrequency) * amplitude;
                mFrequency *= 2;
                amplitude *= Persistance;
            }

            return total > 1.0 ? 1.0 : total;
        }

        public void Init()
        {
            mGen = new RandomNumberGenerator(Seed);
            amplitude = Persistance;
            mFrequency = Frequency;
        }
    }
}
