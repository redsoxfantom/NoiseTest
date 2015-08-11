using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    public abstract class BaseNoiseGenerator :INoiseGenerator
    {
        [Description("The unique name of this generator. Fill this in to allow saving the generator's params to a file")]
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public string Assembly
        {
            get { return this.GetType().ToString(); }
        }

        public abstract double getValue(params double[] location);

        public abstract void Init();
    }
}
