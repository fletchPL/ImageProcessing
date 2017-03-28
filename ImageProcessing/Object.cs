using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Object
    {
        private int classID;
        private string className;
        private List<float> features = new List<float>();

        public Object(String className, List<float> features)
        {
            this.className = className;
            this.features = features;
        }

        public string getClassName()
        {
            return this.className;
        }

        public int getFeaturesNumber()
        {
            return this.features.Count();
            //return 1; // this.features.Count(); to poprawić 
        }
        public List<float> getFeatures()
        {
            return this.features;
        }
    }
}
