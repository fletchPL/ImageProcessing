using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class NearestMean
    {
        private Object nearestAcerMean, nearestQuercusMean;

        public NearestMean()
        {
             List<float> nearestAcerFeaturesMean = new List<float>();
         List<float> nearestQuercusFeaturesMean = new List<float>();
         List<Object> quercusObjects = new List<Object>();
            List<Object> acerObjects = new List<Object>();
            for (int i = 0; i < Global.trainObjects.Count; i++)
            {
                if (Global.trainObjects[i].getClassName().ToLower().Equals("acer"))
                {
                    acerObjects.Add(Global.trainObjects[i]);
                }
                else if (Global.trainObjects[i].getClassName().ToLower().Equals("quercus"))
                {
                    quercusObjects.Add(Global.trainObjects[i]);
                }
            }
            ///MEAN
            ///
            float tempSum = 0;
            
            for (int i = 0; i < acerObjects.Count; i++)
            {
                if (i == 0)
                {
                    nearestAcerFeaturesMean = acerObjects[i].getFeatures();
                    continue;
                }
                for (int j = 0; j < acerObjects[i].getFeatures().Count; j++)
                {
                    nearestAcerFeaturesMean[j] += acerObjects[i].getFeatures()[j];
                }
            }

            for (int i = 0; i < nearestAcerFeaturesMean.Count; i++)
            {
                nearestAcerFeaturesMean[i]=nearestAcerFeaturesMean[i]/(float)acerObjects.Count;
            }

            for (int i = 0; i < quercusObjects.Count; i++)
            {
                if (i == 0)
                {
                    nearestQuercusFeaturesMean = acerObjects[i].getFeatures();
                    continue;
                }
                for (int j = 0; j < acerObjects[i].getFeatures().Count; j++)
                {
                    nearestQuercusFeaturesMean[j] += acerObjects[i].getFeatures()[j];
                }
            }
            for (int i = 0; i < nearestQuercusFeaturesMean.Count; i++)
            {
                nearestQuercusFeaturesMean[i] = nearestQuercusFeaturesMean[i] / (float)acerObjects.Count;
            }

             nearestAcerMean = new Object();
            nearestAcerMean.setFeatures(nearestAcerFeaturesMean);

             nearestQuercusMean = new Object();
            nearestQuercusMean.setFeatures(nearestQuercusFeaturesMean);
        }
       
    
        public double nearestMeanAlgorithm()
        {
            int correctClasifierCounter = 0;
            Classifier classifier = new Classifier();
            foreach(Object o1 in Global.testObjects)
            {

                if(classifier.euklidesSum(o1, nearestAcerMean)< classifier.euklidesSum(o1, nearestQuercusMean))
                {
                    if (o1.getClassName().ToLower().Equals("acer"))
                    {
                        correctClasifierCounter++;
                    }
                }
                else
                {
                    if (o1.getClassName().ToLower().Equals("quercus"))
                    {
                        correctClasifierCounter++;
                    }
                    
                }
            }

            return (correctClasifierCounter/(double)Global.testObjects.Count)*100;
        }

    }
}
