using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    public class RandomGenerator : INoiseGenerator
    {
        private Random gen;

        public RandomGenerator()
        {
            gen = new Random();
        }

        public double getValue(params double[] location)
        {
            return gen.NextDouble();
        }
    }
}
