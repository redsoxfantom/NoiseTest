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
            BitmapData imageData = bmp.LockBits(new Rectangle(0, 0, sizeX, sizeY), ImageLockMode.WriteOnly, PixelFormat.Format16bppGrayScale);
            IntPtr ptr = imageData.Scan0;
            int numBytes = Math.Abs(imageData.Stride) * bmp.Height;
            byte[] imageBytes = new byte[numBytes];

            for (int x = 0; x < sizeX; x++ )
            {
                for(int y = 0; y < sizeY; y++)
                {
                    double noiseVal = gen.getValue(x, y);
                    short noiseIn16bits = (short)((double)short.MaxValue * noiseVal);
                    byte upper = (byte)(noiseIn16bits >> 8);
                    byte lower = (byte)(noiseIn16bits & 0xff);
                    imageBytes[x + (y * sizeY)] = noiseIn16bits;
                }
            }

            Marshal.Copy(imageBytes, 0, ptr, numBytes);
            bmp.UnlockBits(imageData);

            return bmp;
        }
    }
}
