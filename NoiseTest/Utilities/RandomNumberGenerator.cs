using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.Utilities
{
    public class RandomNumberGenerator
    {
        private Random mGen;
        private Dictionary<Tuple<int, int>, double> mCachedValues;

        public RandomNumberGenerator(int seed)
        {
            mGen = new Random(seed);
            mCachedValues = new Dictionary<Tuple<int, int>, double>();
        }

        public RandomNumberGenerator()
        {
            mGen = new Random();
            mCachedValues = new Dictionary<Tuple<int, int>, double>();
        }

        public double GetValue(int x, int y)
        {
            Tuple<int,int> newKey = new Tuple<int,int>(x,y);
            if(mCachedValues.ContainsKey(newKey))
            {
                return mCachedValues[newKey];
            }
            else
            {
                double valToReturn = mGen.NextDouble();
                mCachedValues.Add(newKey, valToReturn);
                return valToReturn;
            }
        }
    }
}
