using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    public class SolidGenerator : BaseNoiseGenerator
    {
        [Description("A value from 0.0 to 1.0. 0.0 = black, 1.0 = white")]
        public double Value { get; set; }

        public override double getValue(params double[] location)
        {
            return Value;
        }

        public override void Init()
        {

        }
    }
}
