using NoiseTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    [DataContract(Name="RandomGenerator")]
    public class RandomGenerator : BaseNoiseGenerator
    {
        private Random gen;

        [DataMember(Name="Seed")]
        public int Seed { get; set; }

        public RandomGenerator()
        {
        }

        public override double getValue(params double[] location)
        {
            return gen.NextDouble();
        }


        public override void Init()
        {
            gen = new Random(Seed);
        }
    }
}
