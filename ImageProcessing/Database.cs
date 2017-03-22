using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Database
    {
        #region Private Variables
        private List<Object> objects = new List<Object>();                              //Lista w C# zamiast Vectora w C++
        private Dictionary<string, int> classCounters = new Dictionary<string, int>();   //Dictionary w C# zamiast map w C++
        private List<String> classNameVector = new List<string>();                      //Lista w C# zamiast Vectora w C++
        private List<uint> featuresIDs = new List<uint>();                              //Lista w C# zamiast Vectora w C++

        private uint noClass;
        private uint noObjects;
        private uint noFeatures;
        #endregion

        #region Public function 
        public Database()
        {
            noClass = 0;
            noObjects = 0;
            noFeatures = 0;
        }

        public bool addObject(Object obj)
        {
            if (noFeatures.Equals(0))
            {
                noFeatures = obj.getFeaturesNumber();
            }
            else if (noFeatures != obj.getFeaturesNumber())
            {
                return false;
            }

            objects.Add(obj);
            ++noObjects;

            if (classCounters[obj.getClassName()]++ == 0)
            {
                classNameVector.Add(obj.getClassName());
            }

            return true;
        }

        public bool load(string fileName) // FUNKCJA LOAD JEST CAŁA DO POPRAWY
        {
            clear();

           

            return true;
        }

        //Funkcja Save będzie przeniesiona do FORM1.cs

        public string getLine(StreamReader file)
        {
            string line = file.ReadLine();

            return line;
        }

        public void clear()
        {
            objects.Clear();
            classNameVector.Clear();
            classCounters.Clear();
            featuresIDs.Clear();
            noClass = 0;
            noObjects = 0;
            noFeatures = 0;
        }

       
        #endregion
    }
}
