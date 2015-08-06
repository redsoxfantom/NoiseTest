using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.NoiseGenerators
{
    // Manager for the noise generators. Responsible for creating all instances and utilizing an active one to return an image
    public class NoiseGeneratorManager
    {
        Dictionary<string, INoiseGenerator> mGenerators;

        public NoiseGeneratorManager()
        {
            mGenerators = new Dictionary<string, INoiseGenerator>();
        }

        public void Init()
        {
            // Get all the INoiseGenerators in this program
            Assembly currAsm = Assembly.GetExecutingAssembly();
            var types = from type in currAsm.GetTypes()
                        where typeof(INoiseGenerator).IsAssignableFrom(type)
                        where !type.IsInterface
                        select type;

            foreach(Type generator in types)
            {
                INoiseGenerator createdGenerator = (INoiseGenerator)Activator.CreateInstance(generator);
                mGenerators.Add(generator.Name, createdGenerator);
            }
        }

        public string[] GetGeneratorNames()
        {
            return mGenerators.Keys.ToArray<string>();
        }
    }
}
