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


        public event Action<Bitmap> OnPaletteCrated;

        public Bitmap OriginalBitmap { set; get; }
        public Bitmap TopBitmap { set; get; }
        public Bitmap SideBitmap { set; get; }
        public Bitmap FrontBitmap { set; get; }
        public Bitmap PaletteBitmap { set; get; }

        public Dictionary<Color, byte> ColorsDictionary = new Dictionary<Color, byte>();

        public MagicaVoxelWriter.VoxWriter writer = new MagicaVoxelWriter.VoxWriter(128, 128, 128);


        public Core()
        {

        }



        public void SetBitmaps(string path)
        {

            OriginalBitmap = new Bitmap(path);



            Rectangle rectangle = new Rectangle(0, 0, 128, 128);

            TopBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);

            rectangle = new Rectangle(0, 128, 128, 128);

            SideBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);

            rectangle = new Rectangle(128, 128, 128, 128);

            FrontBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);



        }

        public void GetPalette()
        {

            //List<Color> colors = new List<Color>();
            HashSet<Color> colors = new HashSet<Color>();

            for (int x = 0; x < OriginalBitmap.Width; x++)
            {


                for (int y = 0; y < OriginalBitmap.Height; y++)
                {


                    colors.Add(OriginalBitmap.GetPixel(x, y));



                }


            }


            PaletteBitmap = new Bitmap(256, 1);

            Color[] clr = colors.ToArray();

            if (colors.Count < 256)
            {
                for (int i = 0; i < clr.Length; i++)
                {

                    PaletteBitmap.SetPixel(i, 0, clr[i]);
                    
                }


                for (int i = 0; i < clr.Length; i++)
                {

                    ColorsDictionary.Add(clr[i], (byte)i);
                    writer.Palette[i] = ColorToUint(clr[i]);
                }




            }

            OnPaletteCrated?.Invoke(PaletteBitmap);






        }


        public void SetVoxels()
        {

            byte[,,] sideProjection = new byte[128, 128, 128];
            byte[,,] topProjection = new byte[128, 128, 128];
            byte[,,] frontProjection = new byte[128, 128, 128];
            byte[,,] sidesBool = new byte[128, 128, 128];


            #region Заполняем боковую проэкция

            // Заполняем фронтальную проэкция

            for (int Y = 0; Y < 128; Y++)
            {
                for (int Z = 0; Z < 128; Z++)
                {
                    for (int X = 0; X < 128; X++)
                    {

                        Color sideColor = SideBitmap.GetPixel(X, 127 - Z);

                        if (sideColor.A > 0)
                        {
                            sideProjection[X, Y, Z] = 1;

                            //writer.SetVoxel(X, Y, Z, 1);
                        }
                        else
                        {
                            sideProjection[X, Y, Z] = 0;
                        }


                    }

                }

            }

            #endregion

            #region Запорняем проэкцию сверху


            for (int Z = 0; Z < 128; Z++)
            {


                for (int Y = 0; Y < 128; Y++)
                {


                    for (int X = 0; X < 128; X++)
                    {

                        Color clr = TopBitmap.GetPixel(X, 127 - Y);

                        if (clr.A > 0)
                        {

                            topProjection[X, Y, Z] = 1;

                            //writer.SetVoxel(X, Y, Z, 1);
                        }
                        else
                        {
                            topProjection[X, Y, Z] = 0;
                        }


                    }



                }






            }







            #endregion

            #region Заполняем фронтальную проэкция

            // Заполняем фронтальную проэкция


            for (int X = 0; X < 128; X++)
            {

                for (int Z = 0; Z < 128; Z++)
                {

                    for (int Y = 127; Y >= 0; Y--)
                    {

                        Color clr = FrontBitmap.GetPixel(127-Y, 127 - Z);

                        if (clr.A > 0)
                        {

                            frontProjection[X, Y, Z] = 1;

                        }
                        else
                        {
                            frontProjection[X, Y, Z] = 0;
                        }


                    }

                }

            }




            #endregion

            #region MatrixSubstract
            
            for (int X = 0; X < 128; X++)
            {

                for (int Y = 0; Y < 128; Y++)
                {
                    for (int Z = 0; Z < 128; Z++)
                    {

                        if (sideProjection[X,Y,Z] == 1 && topProjection[X,Y,Z]==1 && frontProjection[X,Y,Z]==1)
                        {
                            writer.SetVoxel(X, Y, Z, 1);
                        }

                    }
                }


            }
            

            #endregion


         

            #region Fill Voxels
            /*
            for (int X = 0; X < 128; X++)
            {

                for (int Y = 0; Y < 128; Y++)
                {
                    for (int Z = 0; Z < 128; Z++)
                    {




                        
                        if (frontProjection[X, Y, Z] == 1)
                        {
                            writer.SetVoxel(X, Y, Z, 1);
                        }




                    }
                }


            }
            */

            #endregion







            /*

            for (int z = 0; z < 128; z++)
            {
                for (int x = 0; x < 128; x++)
                {
                    for (int y = 127; y >= 0; y--)
                    {
                        int yReal = 127 - y;

                        Color frontColor = SideBitmap.GetPixel(x, yReal);
                        Color sideColor = SideBitmap.GetPixel(x, yReal);
                        Color topColor = SideBitmap.GetPixel(x, yReal);

                        if (frontColor.A != 0 && sideColor.A != 0 && topColor.A != 0)
                        {
                            writer.SetVoxel(x, y, z, 1);
                        }

                    }

                }

            }
            

            */
            writer.Export("D:\\work\\models\\guns\\sideScreen\\gg.vox");



        }

        public static uint ColorToUint(Color c)
        {
            uint u = (UInt32)c.A << 24;
            u += (UInt32)c.R << 16;
            u += (UInt32)c.G << 8;
            u += c.B;
            return u;

            // (UInt32)((UInt32)c.A << 24 + (UInt32)c.R << 16 + (UInt32)c.G << 8 + (UInt32)c.B);
        }


    }
}