using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class NearestNeighbour
    {
        public double nearestNeighbourAlgorithm(Database db)
        {
            double somePart = db.getObjects().Count * Global.dbRatio;
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
                    Global.testObjects.Add(db.getObjects()[i]);
                }
                else
                {
                    Global.trainObjects.Add(db.getObjects()[i]);
                }
            }
           
            int correctClasifierCounter = 0, incorrectClasifierCounter = 0;
            Classifier classifier = new Classifier();
            foreach (Object o1 in Global.testObjects)
            {
                Global.prevEuklSum = 0;
                Global.counter = 0;
                int positionOfObject = classifier.classifie(o1);
                
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
