using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace VOXolezer
{
    public class Core
    {


        public event Action<Bitmap> OnPaletteCrated;
        public event Action OnError;

        public Bitmap OriginalBitmap { set; get; }
        public Bitmap topBitmap { set; get; }
        public Bitmap frontBitmap { set; get; }
        public Bitmap sideBitmap { set; get; }
        public Bitmap PaletteBitmap { set; get; }

        public Dictionary<Color, uint> ColorsDictionary = new Dictionary<Color, uint>();

        public MagicaVoxelWriter.VoxWriter writer = new MagicaVoxelWriter.VoxWriter(128, 128, 128);

        byte[,,] sideProjection = new byte[128, 128, 128];
        byte[,,] topProjection = new byte[128, 128, 128];
        byte[,,] frontProjection = new byte[128, 128, 128];
        byte[,,] mainMatrix = new byte[128, 128, 128];


        public Core()
        {

        }



        public void SetBitmaps(string path)
        {

            OriginalBitmap = new Bitmap(path);

            Rectangle rectangle = new Rectangle(0, 0, 128, 128);

            topBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);

            rectangle = new Rectangle(0, 128, 128, 128);

            frontBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);

            rectangle = new Rectangle(128, 128, 128, 128);

            sideBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);

            frontBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            sideBitmap.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            topBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);


        }

        public void GetPalette()
        {


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

            Array.Sort(clr,new ColorHUEComparer());
            //Array.Sort(clr, new ColorValueComparer());

            if (colors.Count < 256)
            {
                for (int i = 0; i < clr.Length; i++)
                {

                    PaletteBitmap.SetPixel(i, 0, clr[i]);

                }



                for (int i = 0; i < clr.Length; i++)
                {
                    {
                        ColorsDictionary.Add(clr[i], (uint)i + 1);

                        writer.Palette[i] = clr[i].ToUint();

                    }

                }





            }

            OnPaletteCrated?.Invoke(PaletteBitmap);

        }


        // В 2д картинке измерение идет с левого верхнего угла
        // в 3д снизу слева, Y глубина



        public void SetVoxels()
        {

            for (int X = 0; X < 128; X++)
            {

                for (int Y = 0; Y < 128; Y++)
                {

                    for (int Z = 0; Z < 128; Z++)
                    {

                        Color XZ_front_clr = frontBitmap.GetPixel(X, Z);
                        Color YZ_side_clr = sideBitmap.GetPixel(Y, Z);
                        Color XY_top_clr = topBitmap.GetPixel(X, Y);

                        if (XZ_front_clr.A > 0 && YZ_side_clr.A > 0 && XY_top_clr.A > 0)
                        {

                            mainMatrix[X, Y, Z] = 1;

                        }


                    }

                }

            }



            for (int X = 0; X < 128; X++)
            {
                for (int Y = 0; Y < 128; Y++)
                {
                    for (int Z = 0; Z < 128; Z++)
                    {

                        if (mainMatrix[X, Y, Z] == 1)
                        {
                            writer.SetVoxel(X, Y, Z, 2);
                        }

                    }
                }
            }


            // Красим


            // Теперь сверху

            for (int X = 0; X < 128; X++)
            {
                for (int Y = 0; Y < 128; Y++)
                {

                    for (int Z = 127; Z >= 0; Z--)
                    {

                        if (mainMatrix[X, Y, Z] == 1)
                        {

                            Color clr = topBitmap.GetPixel(X, Y);
                            uint clrIndex = ColorsDictionary[clr];
                            writer.SetVoxel(X, Y, Z, (byte)clrIndex);
                            break;


                        }

                    }

                }
            }

            // теперь сбоку

            for (int Y = 0; Y < 128; Y++)
            {

                for (int Z = 0; Z < 128; Z++)
                {

                    for (int X = 127; X >= 0; X--)
                    {
                        if (mainMatrix[X, Y, Z] == 1)
                        {

                            Color clr = sideBitmap.GetPixel(Y, Z);
                            uint clrIndex = ColorsDictionary[clr];
                            writer.SetVoxel(X, Y, Z, (byte)clrIndex);
                            break;


                        }



                    }


                }

            }

            // Сначала спереди

            for (int X = 0; X < 128; X++)
            {

                for (int Z = 0; Z < 128; Z++)
                {



                    for (int Y = 0; Y < 128; Y++)
                    {

                        if (mainMatrix[X, Y, Z] == 1)
                        {

                            Color clr = frontBitmap.GetPixel(X, Z);
                            uint clrIndex = ColorsDictionary[clr];
                            writer.SetVoxel(X, Y, Z, (byte)clrIndex);
                            break;


                        }

                    }




                }


            }

            // Делаем симметричную покраску сзади

            for (int X = 0; X < 128; X++)
            {

                for (int Z = 0; Z < 128; Z++)
                {



                    for (int Y = 127; Y >= 0; Y--)
                    {

                        if (mainMatrix[X, Y, Z] == 1)
                        {

                            Color clr = frontBitmap.GetPixel(X, Z);
                            uint clrIndex = ColorsDictionary[clr];
                            writer.SetVoxel(X, Y, Z, (byte)clrIndex);
                            break;


                        }

                    }




                }


            }





        }


        public void FrontExtrudMatrix()
        {
            for (int x = 0; x < frontBitmap.Width; x++)
            {

                for (int y = 0; y < frontBitmap.Height; y++)
                {
                    for (int Z = 0; Z < 128; Z++)
                    {
                        Color clr = frontBitmap.GetPixel(x, y);

                        if (clr.A > 0)
                        {
                            writer.SetVoxel(x, Z, y, 1);
                        }


                    }

                }

            }
        }

        public void SideExtrudMatrix()
        {
            for (int x = 0; x < sideBitmap.Width; x++)
            {

                for (int y = 0; y < sideBitmap.Height; y++)
                {

                    for (int X = 0; X < 128; X++)
                    {
                        Color clr = sideBitmap.GetPixel(x, y);
                        if (clr.A > 0)
                        {
                            writer.SetVoxel(X, x, y, 1);
                        }
                    }





                }
            }
        }

        public void TopExtrudMatrix()
        {
            for (int x = 0; x < topBitmap.Width; x++)
            {

                for (int y = 0; y < topBitmap.Height; y++)
                {




                    Color clr = topBitmap.GetPixel(x, y);


                    for (int Z = 0; Z < 128; Z++)
                    {
                        if (clr.A > 0)
                        {
                            writer.SetVoxel(x, y, Z, 1);
                        }
                    }




                }
            }
        }







        public void SetVoxelsOld()
        {


            #region Заполняем боковую проэкция

            // Заполняем фронтальную проэкция

            for (int Y = 0; Y < 128; Y++)
            {
                for (int Z = 0; Z < 128; Z++)
                {
                    for (int X = 0; X < 128; X++)
                    {


                        try
                        {
                            Color sideColor = frontBitmap.GetPixel(X, 127 - Z);


                            uint clrIndex = ColorsDictionary[sideColor];

                            if (sideColor.A > 0)
                            {

                                writer.SetVoxel(X, Y, Z, (byte)clrIndex);
                            }
                            else
                            {
                                sideProjection[X, Y, Z] = 0;
                            }
                        }
                        catch (Exception e)
                        {


                            MessageBox.Show($"Вероятно, в изображении более 255 цветов. Ошибка: {e.Message}");

                            OnError?.Invoke();

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

                        Color clr = topBitmap.GetPixel(X, 127 - Y);


                        if (clr.A == 0)
                        {

                            writer.SetVoxel(X, Y, Z, 0);
                        }
                        else
                        {

                        }


                    }



                }






            }


            #endregion

            #region Заполняем фронтальную проэкция

            // Заполняем фронтальную проэкция
            // В случае, если есть хоть один пиксель.

            bool frontHavePixels = false;


            for (int X = 0; X < 128; X++)
            {

                for (int Y = 0; Y < 128; Y++)
                {

                    Color clr = sideBitmap.GetPixel(X, Y);

                    if (clr.A > 0)
                    {
                        frontHavePixels = true;
                        break;
                    }


                }

                if (frontHavePixels)
                {
                    break;
                }


            }


            if (frontHavePixels)
            {
                for (int X = 0; X < 128; X++)
                {

                    for (int Z = 0; Z < 128; Z++)
                    {

                        for (int Y = 127; Y >= 0; Y--)
                        {

                            Color clr = sideBitmap.GetPixel(127 - Y, 127 - Z);

                            if (clr.A == 0)
                            {

                                writer.SetVoxel(X, Y, Z, 0);

                            }
                            else
                            {

                            }


                        }

                    }

                }
            }










            #endregion

        }







        public static uint ColorToUint(Color c)
        {
            uint u = (UInt32)c.A << 24;
            u += (UInt32)c.R << 16;
            u += (UInt32)c.G << 8;
            u += c.B;
            return u;

        }


    }
}