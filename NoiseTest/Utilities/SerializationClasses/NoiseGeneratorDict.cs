using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.Utilities.SerializationClasses
{
    [CollectionDataContract(Name="NoiseGenerators",KeyName="NoiseGeneratorName",ValueName="NoiseGenerator")]
    public class NoiseGeneratorDict : Dictionary<string,INoiseGenerator>
    {
    }
}
