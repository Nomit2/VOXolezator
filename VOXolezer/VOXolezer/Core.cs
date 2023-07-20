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

        public MagicaVoxelWriter.VoxWriter writer = new MagicaVoxelWriter.VoxWriter(256, 256, 256);


        byte[,,] mainMatrix = new byte[256, 256, 256];


        public Core()
        {

        }



        public void SetBitmaps(string path)
        {

            OriginalBitmap = new Bitmap(path);


            Rectangle rectangle = new Rectangle(0, 0, 256, 256);

            topBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);

            rectangle = new Rectangle(0, 256, 256, 256);

            frontBitmap = OriginalBitmap.Clone(rectangle, OriginalBitmap.PixelFormat);

            rectangle = new Rectangle(256, 256, 256, 256);

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

            //Array.Sort(clr,new ColorHUEComparer());
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
            SetVoxelsOld();

        }

        public void SetVoxelsOld()
        {

            for (int X = 0; X < 256; X++)
            {

                for (int Y = 0; Y < 256; Y++)
                {

                    for (int Z = 0; Z < 256; Z++)
                    {

                        Color XZ_front_clr = frontBitmap.GetPixel(X, Z);
                        Color YZ_side_clr = sideBitmap.GetPixel(Y, Z);
                        Color XY_top_clr = topBitmap.GetPixel(X, Y);

                        if (XZ_front_clr.A > 0 && YZ_side_clr.A > 0 && XY_top_clr.A > 0)
                        {
                            //writer.SetVoxel(X, Y, Z, 1);
                            mainMatrix[X, Y, Z] = 1;

                        }


                    }

                }

            }


            for (int X = 0; X < 256; X++)
            {
                for (int Y = 0; Y < 256; Y++)
                {
                    for (int Z = 0; Z < 256; Z++)
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

            for (int X = 0; X < 256; X++)
            {
                for (int Y = 0; Y < 256; Y++)
                {

                    for (int Z = 255; Z >= 0; Z--)
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

            for (int Y = 0; Y < 256; Y++)
            {

                for (int Z = 0; Z < 256; Z++)
                {

                    for (int X = 255; X >= 0; X--)
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

            for (int X = 0; X < 256; X++)
            {

                for (int Z = 0; Z < 256; Z++)
                {



                    for (int Y = 0; Y < 256; Y++)
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

            for (int X = 0; X < 256; X++)
            {

                for (int Z = 0; Z < 256; Z++)
                {



                    for (int Y = 255; Y >= 0; Y--)
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


        }
}