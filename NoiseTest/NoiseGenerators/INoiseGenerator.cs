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
        /// The name of the generator.
        /// Used for serialization / deserialization
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The Type of this object
        /// </summary>
        string Assembly { get; }

        /// <summary>
        /// Get the noise at a particular location
        /// </summary>
        /// <param name="location">The location to sample for noise</param>
        /// <returns>a value from 0..1</returns>
        double getValue(params double[] location);

        /// <summary>
        /// Initialize the generator
        /// </summary>
        void Init();
    }
}
