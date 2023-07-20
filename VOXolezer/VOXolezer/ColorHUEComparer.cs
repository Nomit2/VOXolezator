using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace VOXolezer
{






    class ColorHUEComparer : IComparer<Color>
    {


        int IComparer<Color>.Compare(Color x, Color y)
        {





            float aH = x.GetHue();
            float bH = y.GetHue();




            if (aH > bH)
            {
                return 1;
            }
            else if (aH == bH)
            {
                return 0;
            }
            else
            {
                return -1;
            }


        }
    }
}
