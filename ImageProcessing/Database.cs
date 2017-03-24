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
                    
                    while(true)
                    {
                        positionOfFirstSign = featuresID.IndexOf(',');

                        if(positionOfFirstSign != null)
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
                    while((line = sr.ReadLine()) != null)
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

                        while(true)
                        {
                            pos = features.IndexOf(',');
                            if(pos != null)
                            {
                                string feature = features.Substring(0, pos);
                                features = features.Substring(pos + 1);
                                float featuresValue = float.Parse(feature);
                                featuresValues.Add(featuresValue);
                            }
                            else
                            {
                                float featureValue = float.Parse(features);
                                featuresValues.Add(featureValue);
                                break;
                            }
                        }

                        if (classFeaturesNo == featuresValues.Count())
                        {
                           /* if (addObject(new Object(className, featuresValues)))
                            {

                            }*/
                        }
                        else return false; 

                    }
                   
                }
            }catch(Exception e)
            {
                e.Message.ToString();
            }

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
