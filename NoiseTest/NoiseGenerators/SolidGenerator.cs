using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    public class SolidGenerator : INoiseGenerator
    {
        public double Value { get; set; }

        public double getValue(params double[] location)
        {
            return Value;
        }

        public void Init()
        {

        }
    }
}
