using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NoiseGeneratorAttribute : Attribute
    {
        public NoiseGeneratorAttribute()
        {

        }
    }
}
