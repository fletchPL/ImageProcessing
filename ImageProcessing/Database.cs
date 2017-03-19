using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Database
    {
        private List<Object> objects = new List<Object>();                              //Lista w C# zamiast Vectora w C++
        private Dictionary<string,int> classCounters = new Dictionary<string, int>();   //Dictionary w C# zamiast map w C++
        private List<String> classNameVector = new List<string>();                      //Lista w C# zamiast Vectora w C++
    }
}
