using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest
{
    public interface INoiseGenerator
    {
        /// <summary>
        /// Get the noise at a particular location
        /// </summary>
        /// <param name="location">The location to sample for noise</param>
        /// <returns>a value from 0..1</returns>
        double getValue(params double[] location);
    }
}
