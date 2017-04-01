using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
   public class Classifier
    {
        public int classifie(Object objectFromTestList)
        {
           // int counter = 0;
            foreach (Object o2 in Global.trainObjects)
            {
                Global.counter++;
                double euklSum = euklidesSum(objectFromTestList, o2);
                if (Global.prevEuklSum == 0 || euklSum < Global.prevEuklSum)
                {
                    Global.prevEuklSum = euklSum;
                    Global.position = Global.counter;
                }
            }
            return Global.position;
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
