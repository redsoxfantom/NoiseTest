using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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

            // Create and store an instance of each generator
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

        public Image GenerateNoiseImage(string generatorToUse, int sizeX, int sizeY)
        {
            INoiseGenerator gen = mGenerators[generatorToUse];

            Bitmap bmp = new Bitmap(sizeX, sizeY);
            Graphics bitmapGfx = Graphics.FromImage(bmp);

            for (int x = 0; x < sizeX; x++ )
            {
                for(int y = 0; y < sizeY; y++)
                {
                    double color = gen.getValue(x,y);
                    int intColor = (int)(255.0 * color);
                    SolidBrush coloringBrush = new SolidBrush(Color.FromArgb(intColor,intColor,intColor));
                    bitmapGfx.FillRectangle(coloringBrush,x,y,1,1);
                }
            }

            return bmp;
        }
    }
}
