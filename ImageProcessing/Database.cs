using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class Database
    {
        #region Private Variables
        private List<Object> objects = new List<Object>();                              //Lista w C# zamiast Vectora w C++
        private Dictionary<string, int> classCounters = new Dictionary<string, int>();  //Dictionary w C# zamiast map w C++
        private List<String> classNameVector = new List<string>();                      //Lista w C# zamiast Vectora w C++
        private List<float> featuresIDs = new List<float>();                              //Lista w C# zamiast Vectora w C++

        private uint noClass;
        private uint noObjects;
        private uint noFeatures;
        #endregion

        #region Public function 

        public string[] strArry;
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
                noFeatures = (uint)obj.getFeaturesNumber();
            }
            else if (noFeatures != obj.getFeaturesNumber())
            {
                return false;
            }

            objects.Add(obj);
            ++noObjects;

            if (!classCounters.ContainsKey(obj.getClassName()))
            {
                classNameVector.Add(obj.getClassName());
            }


            return true;
        }

        public bool load(string fileName) 
        {
            clear();

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line = sr.ReadLine();
                    int positionOfFirstSign = line.IndexOf(',');

                    if (positionOfFirstSign.Equals(null))
                    {
                        return false;
                    }

                    uint classFeaturesNo = uint.Parse(line.Substring(0, positionOfFirstSign));

                    string featuresID = line.Substring(positionOfFirstSign + 1);

                    while (true)
                    {
                        positionOfFirstSign = featuresID.IndexOf(',');

                        if (positionOfFirstSign != -1)
                        {
                            string feature = featuresID.Substring(0, positionOfFirstSign);
                            featuresID = featuresID.Substring(positionOfFirstSign + 1);
                            float featureID = float.Parse(feature);
                            featuresIDs.Add(featureID);
                        }
                        else
                        {
                            float featureID = float.Parse(featuresID);
                            featuresIDs.Add(featureID);
                            break;
                        }
                    }

                    while ((line = sr.ReadLine()) != null)
                    {
                        int pos = line.IndexOf(',');

                        if (pos.Equals(null))
                        {
                            continue;
                            //throw new Exception("Index not found");
                        }

                        string className = line.Substring(0, pos);
                        int classNamePos = className.IndexOf(' ');

                        if (classNamePos != null)
                        {
                            className = className.Substring(0, classNamePos);
                        }

                        string features = line.Substring(pos + 1);
                        List<float> featuresValues = new List<float>();

                        while (true)
                        {
                            pos = features.IndexOf(',');
                            if (pos != -1)
                            {
                                string feature = features.Substring(0, pos);
                                features = features.Substring(pos + 1);
                                float featuresValue = float.Parse(feature.Replace('.', ','));
                                featuresValues.Add(featuresValue);
                            }
                            else
                            {
                                float featureValue = float.Parse(features.Replace('.', ','));
                                featuresValues.Add(featureValue);
                                break;
                            }
                        }

                        if (classFeaturesNo == featuresValues.Count())
                        {

                            if (addObject(new Object(className, featuresValues)))
                            {

                            }
                        }
                        else return false;

                    }

                }
            }
            catch (FileLoadException e)
            {
                e.Message.ToString();
                Console.WriteLine("Co tu się odpierdala?");
            }

            return true;
        }

        public void save(string filePathToSave)
        {
            StreamWriter sw = new StreamWriter(filePathToSave);
            foreach (float id in featuresIDs)
            {
                sw.Write(id + ",");
            }
            foreach (Object obj in getObjects())
            {
                sw.Write(obj.getClassName() + ",");
                foreach (Object obj2 in getObjects())
                {
                    sw.Write(obj2.getFeatures() + ",");
                }
                sw.Write("\n");
            }
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
        #region geter and setter
        public List<Object> getObjects()
        {
            return objects;
        }

        public uint getNoClass()
        {
            string a = classNameVector.Count.ToString();
            return Convert.ToUInt16(a);
         
        }
        public uint getNoObject()
        {
            return noObjects;
        }
        public uint getNoFeatures()
        {
            return noFeatures;
        }
        #endregion
    }
}
