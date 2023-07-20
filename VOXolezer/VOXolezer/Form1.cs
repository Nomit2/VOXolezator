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
            core.OnPaletteCrated += SetPalleteToBGWhenCreated;
            core.OnError += ExitOnError;


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

                openFileDialog.InitialDirectory = "D:\\work\\models\\guns\\sideScreen\\";
                openFileDialog.Filter = "png files (*.png)|*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    core.SetBitmaps(openFileDialog.FileName);

                    Bitmap b = new Bitmap(128, 128);

                    Graphics g = Graphics.FromImage((System.Drawing.Image)b);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.DrawImage(core.OriginalBitmap, 0, 0, 128, 128);
                    g.Dispose();

                    panelAll.BackgroundImage = b;

                    panelFront.BackgroundImage = core.sideBitmap;
                    panelSide.BackgroundImage = core.frontBitmap;
                    panelTop.BackgroundImage = core.topBitmap;



                }

                core.GetPalette();

            }


            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);


            this.buttonConvert.Enabled = true;


        }


        private void SetPalleteToBGWhenCreated(Bitmap bitmap)
        {

            panelPallete.BackgroundImage = bitmap;

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {

            core.SetVoxels();



            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "vox files (*.vox)|*.vox";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string s = saveFileDialog1.FileName;

                core.writer.Export(s);


            }


        }

        private void ExitOnError()
        {

            Close();
            
        }

        private void labelSide_Click(object sender, EventArgs e)
        {

        }
    }
}
