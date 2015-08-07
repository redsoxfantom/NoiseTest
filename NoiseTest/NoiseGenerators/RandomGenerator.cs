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

        public int Seed { get; set; }

        public RandomGenerator()
        {
        }

        public double getValue(params double[] location)
        {
            return gen.NextDouble();
        }


        public void Init()
        {
            gen = new Random(Seed);
        }
    }
}
