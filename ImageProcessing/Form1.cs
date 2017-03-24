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
        public Database db = new Database();
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
            
            if(openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                string fullPath = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;
                label3.Text = fullPath;
                label4.Text = fileName;

                db.load(fullPath);
            }
        }

    }
}
