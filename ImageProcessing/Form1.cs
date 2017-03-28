using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Database maple_oak;
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            saveFileFunction();
        }

        public void saveFileFunction()
        {
            Database db = new Database();
            if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                saveFileDialog.InitialDirectory = @"C:\";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.CheckFileExists = true;
                saveFileDialog.CheckPathExists = true;
                string path = saveFileDialog.FileName;
                db.save(path);
            }



        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            maple_oak = new Database();
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                string fullPath = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;
                label3.Text = fullPath;
                label4.Text = fileName;

                maple_oak.load(fullPath);
                nearestNeighbourAlgorithm(maple_oak, 0.25);
            }

        }
        private void nearestNeighbourAlgorithm(Database db, double dbRatio)
        {
            double somePart = db.getObjects().Count * dbRatio;
            List<Object> testObjects = new List<Object>();
            List<Object> trainObjects = new List<Object>();

            for (int i = 0; i < db.getObjects().Count; i++)
            {
                if (i < somePart)
                {
                    testObjects.Add(db.getObjects()[i]);
                }
                else
                {
                    trainObjects.Add(db.getObjects()[i]);
                }
            }
            Console.Write(somePart + " " + db.getObjects().Count);


            foreach (Object o1 in testObjects)
            {
                double prevEuklSum = 0;
                int counter = 0, position = 0;
                foreach (Object o2 in trainObjects)
                {
                    counter++;
                    double euklSum = euklidesSum(o1, o2);
                    if (prevEuklSum == 0 || euklSum < prevEuklSum)
                    {
                        prevEuklSum = euklSum;
                        position = counter;
                    }
                }
                Console.WriteLine("Najbliżej do próbki numer:" + position);
            }
        }
        private double euklidesSum(Object o1, Object o2)
        {
            double sumOfSquareDifference = 0;
            for (int i = 0; i < o1.getFeaturesNumber(); i++)
            {
                sumOfSquareDifference += Math.Pow((o1.getFeatures()[i] - o2.getFeatures()[i]), 2);
            }
            return Math.Sqrt(sumOfSquareDifference);
        }
        private void computeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
