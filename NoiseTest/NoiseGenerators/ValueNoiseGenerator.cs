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

        public double getValue(params double[] location)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
