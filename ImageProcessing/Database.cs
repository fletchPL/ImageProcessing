using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Database
    {
        #region Private Variables
            private List<Object> objects = new List<Object>();                              //Lista w C# zamiast Vectora w C++
            private Dictionary<string,int> classCounters = new Dictionary<string, int>();   //Dictionary w C# zamiast map w C++
            private List<String> classNameVector = new List<string>();                      //Lista w C# zamiast Vectora w C++
            private List<uint> featuresIDs = new List<uint>();                              //Lista w C# zamiast Vectora w C++

            private uint noClass;
            private uint noObjects;
            private uint noFeatures;
        #endregion

        #region Public function 
            public Database ()
            {
                noClass = 0;
                noObjects = 0;
                noFeatures = 0;
            }

      

        #endregion
    }
}
