using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
   
    public static class Global
    {
        public static Database data = new Database();
        public static Classifier classifier = new Classifier();
        public static double dbRatio = 0.25;
        public static int position = 0;
        public static int counter = 0;
        public static double prevEuklSum = 0;
        public static List<Object> testObjects = new List<Object>();
        public static List<Object> trainObjects = new List<Object>();

        public static void splitForTwoVectors()
        {
            
            double somePart = data.getObjects().Count * Global.dbRatio;
            Random r = new Random();

            int number;
            List<int> intList = new List<int>();
            for (int i = 0; i < somePart; i++)
            {
                do
                {
                    number = r.Next(0, data.getObjects().Count);

                } while (intList.Contains(number));
                intList.Add(number);
            }

            for (int i = 0; i < data.getObjects().Count; i++)
            {
                if (intList.Contains(i))
                {
                    Global.testObjects.Add(data.getObjects()[i]);
                }
                else
                {
                    Global.trainObjects.Add(data.getObjects()[i]);
                }
            }
        }
    }
}
