﻿using NoiseTest.Utilities.SerializationClasses;
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
        NoiseGeneratorDict mLoadedGenerators = new NoiseGeneratorDict();

        public NoiseGeneratorManager()
        {
            mGenerators = new Dictionary<string, INoiseGenerator>();
            mLoadedGenerators = new NoiseGeneratorDict();
        }

        public void Init()
        {
            // Get all the INoiseGenerators in this program
            Assembly currAsm = Assembly.GetExecutingAssembly();
            var types = from type in currAsm.GetTypes()
                        where typeof(BaseNoiseGenerator).IsAssignableFrom(type)
                        where !type.IsAbstract
                        where !type.IsInterface
                        select type;

            // Create and store an instance of each generator
            foreach(Type generator in types)
            {
                INoiseGenerator createdGenerator = (INoiseGenerator)Activator.CreateInstance(generator);
                mGenerators.Add(generator.Name, createdGenerator);
            }
        }

        public bool LoadGeneratorFile(string filename)
        {
            try
            {
                mLoadedGenerators = XMLSerializer.DeserializeObject<NoiseGeneratorDict>(filename);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool AddGeneratorToLoadedGenerators(INoiseGenerator generator)
        {
            if(mLoadedGenerators.ContainsKey(generator.Name))
            {
                return false;
            }
            mLoadedGenerators.Add(generator.Name, generator);
            return true;
        }

        public bool SaveGeneratorsToFile(string filename)
        {
            try
            {
                XMLSerializer.SerializeObject<NoiseGeneratorDict>(filename, mLoadedGenerators);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public string[] GetGeneratorNames()
        {
            return mGenerators.Keys.ToArray<string>();
        }

        public INoiseGenerator GetGenerator(string generatorName)
        {
            return mGenerators[generatorName];
        }

        public Image GenerateNoiseImage(string generatorToUse, int sizeX, int sizeY, IProgress<int> progressReporter)
        {
            INoiseGenerator gen = mGenerators[generatorToUse];
            gen.Init();

            Bitmap imageToDraw = new Bitmap(sizeX, sizeY);
            Graphics bitmapGfx = Graphics.FromImage(imageToDraw);
            int totalIterations = sizeX * sizeY;

            for (int x = 0; x < imageToDraw.Width; x++)
            {
                for (int y = 0; y < imageToDraw.Height; y++)
                {
                    double color = gen.getValue(x, y);
                    int intColor = (int)(255.0 * color);
                    SolidBrush coloringBrush = new SolidBrush(Color.FromArgb(intColor, intColor, intColor));
                    bitmapGfx.FillRectangle(coloringBrush, x, y, 1, 1);
                }

                int workDone = (int)(((double)(sizeX * (x+1))/(double)totalIterations) * 100.0);
                progressReporter.Report(workDone);
            }

            return imageToDraw;
        }
    }
}
