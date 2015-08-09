using NoiseTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    public class RandomGenerator : INoiseGenerator
    {
        private RandomNumberGenerator gen;

        public int Seed { get; set; }

        public RandomGenerator()
        {
        }

        public double getValue(params double[] location)
        {
            return gen.GetValue(location[0], location[1]);
        }


        public void Init()
        {
            gen = new RandomNumberGenerator(Seed);
        }
    }
}
