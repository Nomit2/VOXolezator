using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VOXolezer
{
    public static class Extensions
    {

        public static uint ToUint(this Color c)
        {
            uint u = (UInt32)c.A << 24;
            u += (UInt32)c.R << 16;
            u += (UInt32)c.G << 8;
            u += c.B;
            return u;
        }



    }
}
