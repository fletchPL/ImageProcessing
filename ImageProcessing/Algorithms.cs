using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Algorithms
    {
        public int nearestNeighbourAlgorithm(Database db, double dbRatio)
        {
            double somePart = db.getObjects().Count * dbRatio;
            List<Object> testObjects = new List<Object>();
            List<Object> trainObjects = new List<Object>();
            int position = 0;
            Random r = new Random();
            

            for (int i = 0; i < db.getObjects().Count; i++)
            {
                int randomNumber = r.Next(0, db.getObjects().Count);
                if (i < somePart)
                {
                    testObjects.Add(db.getObjects()[randomNumber]);
                }
                else
                {
                    trainObjects.Add(db.getObjects()[randomNumber]);
                }
            }
            Console.Write(somePart + " " + db.getObjects().Count);


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
                
            }
            return position;
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
