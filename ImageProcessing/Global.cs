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
        public static double dbRatio = 0.25;
        public static int position = 0;
        public static int counter = 0;
        public static double prevEuklSum = 0;
        public static List<Object> testObjects = new List<Object>();
        public static List<Object> trainObjects = new List<Object>();
    }
}
