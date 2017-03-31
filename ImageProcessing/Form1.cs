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
           

        }

      /*  private void updateDatabaseInfo()
        {
            FScomboBox.Items.Clear();
            for(int i=0;i<= maple_oak.getNoFeatures();++i)
            {
                FScomboBox.Items.Add(i.ToString());
            }
            FStextBrowserDatabaseInfo.Text = "noClass: " + maple_oak.getNoClass().ToString();
            FStextBrowserDatabaseInfo.Text = "noObjects: " + maple_oak.getNoObject().ToString();
            FStextBrowserDatabaseInfo.Text = "noFeatures: " + maple_oak.getNoFeatures().ToString();
        }*/

        private void computeButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Singleton single = new Singleton();
            //FSupdateButtonState();
        }
       /* private void FSupdateButtonState()
        {
            if(db.getNoObject() == 0)
            {
                FSsetButtonState(false);
            }
            else
            {
                FSsetButtonState(true);
            }
        }*/

        private void FSsetButtonState(bool state)
        {
           
            FScomboBox.Enabled = state;
            FSpushButtonCompute.Enabled = state;
            saveFileButton.Enabled = state;
            FSradioButtonFisher.Enabled = state;
            FSradioButtonSFS.Enabled = state;
            
        }

        private void FSpushButtonCompute_Click(object sender, EventArgs e)
        {
            int dimension = int.Parse(FScomboBox.GetItemText(this.FScomboBox.SelectedItem));

            if(FSradioButtonFisher.Checked)
            {
                if(dimension.Equals(1) && maple_oak.getNoClass().Equals(2))
                {
                    float FLD = 0, tmp;
                    int maxInd = -1;

                    for(int i=0; i< maple_oak.getNoFeatures(); ++i)
                    {
                        Dictionary<string, float> classAverages;
                        Dictionary<string, float> classStds;

                        foreach(Object ob in maple_oak.getObjects())
                        {
                          //  classAverages[ob.getClassName()] += ob.getFeatures()[i];
                          //  classStds[ob.getClassName()] += ob.getFeatures()[i] * ob.getFeatures()[i];
                        }
                        tmp = 0; // tu naprawić 

                        if (tmp > FLD)
                        {
                            FLD = tmp;
                            maxInd = i;
                        }
                    }
                   
                }
            }
        }

        private void trainingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileButtonClassifiers_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            NearestNeighbour nn = new NearestNeighbour();
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                string fullPath = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;

                db.load(fullPath);
                
                double result = Math.Round(nn.nearestNeighbourAlgorithm(db),2);
                CtextBrowser.AppendText( "Dokładność : " + result.ToString());
                
                // FSupdateButtonState();
                // updateDatabaseInfo();

            }
        }
    }
}
