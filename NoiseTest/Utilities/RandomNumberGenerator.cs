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
        private Dictionary<Tuple<double, double>, double> mCachedValues;

        public RandomNumberGenerator(int seed)
        {
            mGen = new Random(seed);
            mCachedValues = new Dictionary<Tuple<double, double>, double>();
        }

        public RandomNumberGenerator()
        {
            mGen = new Random();
            mCachedValues = new Dictionary<Tuple<double, double>, double>();
        }

        public double GetValue(double x, double y)
        {
            Tuple<double, double> newKey = new Tuple<double, double>(x, y);
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
