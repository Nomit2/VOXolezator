using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace VOXolezer
{
    public class Core
    {

        public Bitmap OriginalBitmap { set; get; }
        public Bitmap SideBitmap { set; get; }
        public Bitmap TopBitmap { set; get; }
        public Bitmap FrontBitmap { set; get; }



        public Core()
        {

        }



        public void SetBitmaps(string path)
        {

            OriginalBitmap = new Bitmap(path);


        }





    }
}