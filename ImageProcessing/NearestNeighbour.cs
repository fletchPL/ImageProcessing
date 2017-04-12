using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class NearestNeighbour
    {
        public double nearestNeighbourAlgorithm()
        {
            
            Global.splitForTwoVectors();

            int correctClasifierCounter = 0, incorrectClasifierCounter = 0;
          
            foreach (Object o1 in Global.testObjects)
            {
                Global.prevEuklSum = 0;
                Global.counter = 0;
                int positionOfObject = Global.classifier.classifie(o1);
                
                string temp = Global.trainObjects[positionOfObject - 1].getClassName().ToString();
                if (o1.getClassName().Equals(temp))
                {
                    correctClasifierCounter++;
                }
                else
                {
                    incorrectClasifierCounter++;
                }

            }
            double result = (double)correctClasifierCounter / Global.testObjects.Count;
            return result * 100;
        }
     
    }
}
