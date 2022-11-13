using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VOXolezer
{
    public partial class Form1 : Form
    {

        Core core = new Core();



        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectFile();
        }





        private void SelectFile()
        {


            string fileContent = string.Empty;
            string filePath = string.Empty;



            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {


                //"D:\\work\\models\\guns\\sideScreen\\"
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.InitialDirectory = "D:\\work\\models\\guns\\sideScreen\\";
                openFileDialog.Filter = "png files (*.png)|*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    core.SetBitmaps(openFileDialog.FileName);

                }
                


            }


            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);





        }



    }
}
