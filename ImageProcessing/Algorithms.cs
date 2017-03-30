using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Algorithms
    {
        public double nearestNeighbourAlgorithm(Database db, double dbRatio)
        {
            double somePart = db.getObjects().Count * dbRatio;
            List<Object> testObjects = new List<Object>();
            List<Object> trainObjects = new List<Object>();
            int position = 0;
            Random r = new Random();

            int number;
            List<int> intList = new List<int>();
            for (int i = 0; i < somePart; i++)
            {
                do
                {
                    number = r.Next(0, db.getObjects().Count);

                } while (intList.Contains(number));
                intList.Add(number);
            }

            for (int i = 0; i < db.getObjects().Count; i++)
            {
                if (intList.Contains(i))
                {
                    testObjects.Add(db.getObjects()[i]);
                }
                else
                {
                    trainObjects.Add(db.getObjects()[i]);
                }
            }
            int correctClasifierCounter = 0, incorrectClasifierCounter = 0;
            foreach (Object o1 in testObjects)
            {
                double prevEuklSum = 0;
                int counter = 0;
                foreach (Object o2 in trainObjects)
                {
                    counter++;
                    double euklSum = euklidesSum(o1, o2);
                    if (prevEuklSum == 0 || euklSum < prevEuklSum)
                    {
                        prevEuklSum = euklSum;
                        position = counter;
                    }
                }
                string temp = trainObjects[position-1].getClassName().ToString();
                if (o1.getClassName().Equals(temp))
                {
                    correctClasifierCounter++;
                }
                else
                {
                    incorrectClasifierCounter++;
                }

            }
            double result = (double)correctClasifierCounter/testObjects.Count;
            return result;
        }
        public double euklidesSum(Object o1, Object o2)
        {
            double sumOfSquareDifference = 0;
            for (int i = 0; i < o1.getFeaturesNumber(); i++)
            {
                sumOfSquareDifference += Math.Pow((o1.getFeatures()[i] - o2.getFeatures()[i]), 2);
            }
            return Math.Sqrt(sumOfSquareDifference);
        }
    }
}
