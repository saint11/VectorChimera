using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorChimera
{
    public static class ColorPalette
    {
        public const int SIZE = 25;
        public const int BORDER = 3;

        public static List<int> ExtractPalette(Bitmap image)
        {
            HashSet<int> colors = new HashSet<int>();
            if (image.Palette.Entries.Count() > 0)
                foreach (var c in image.Palette.Entries)
                {
                    colors.Add(c.ToArgb());
                }
            else
            {
                for(int y=0;y<image.Height;y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        colors.Add(image.GetPixel(x, y).ToArgb());
                    }
                }
            }

            return colors.ToList();
        }

        public static Bitmap CreatePalette(Color[] colors,int width)
        {
            int cntColors = colors.Count();

            Bitmap palette = new Bitmap(width, SIZE * (int)((cntColors + 1 )* (SIZE + BORDER) / width));
            Graphics dc = Graphics.FromImage(palette);

            int currX = 0,
                currY = 0;

            for (int i = 0; i < cntColors; i++)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(colors[i].A, colors[i].R, colors[i].G, colors[i].B));

                dc.FillRectangle(brush, currX, currY, SIZE, SIZE);

                if (currX > palette.Width-SIZE*2)
                {
                    currX = 0;
                    currY += SIZE+BORDER;
                }
                else
                {
                    currX += SIZE + BORDER;
                }
            }
            return palette;

        }

        public static Bitmap SwapColors(Dictionary<int,int> changelog, Bitmap image)
        {
            Bitmap final = new Bitmap(image);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int color = final.GetPixel(x,y).ToArgb();

                    if (changelog.ContainsKey(color))
                        final.SetPixel(x, y, Color.FromArgb(changelog[color]));
                }
            }

            return final;
        }

        public static void SaveFiles(Dictionary<int, int> changelog, List<string> files)
        {
            foreach (string file in files)
            {
                Bitmap bit = SwapColors(changelog, new Bitmap(ImageHandler.LoadImageNoLock(file)));

                Stream stream = new FileStream(file,FileMode.Create);
                bit.Save(stream,ImageFormat.Png);
                stream.Close();
            }
        }
    }
}
