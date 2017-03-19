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

        public string getClassName()
        {
            return this.className;
        }

        public int getFeaturesNumber()
        {
            return this.features.Count();
        }
        public List getFeatures()
        {
            return this.features;
        }
    }
}
