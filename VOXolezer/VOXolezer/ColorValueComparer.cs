using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VOXolezer
{
    class ColorValueComparer : IComparer<Color>
    {

        int IComparer<Color>.Compare(Color x, Color y)
        {



            float aV = x.GetBrightness();
            float bV = y.GetBrightness();




            if (aV > bV)
            {
                return 1;
            }
            else if (aV == bV)
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
