using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorChimera
{
    public static class ImageHandler
    {

        public static Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.SmoothingMode = SmoothingMode.None;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            }
            return result;
        }

        public static Image LoadImageNoLock(string path)
        {
            var ms = new MemoryStream(File.ReadAllBytes(path)); // Don't use using!!
            Image ret = Image.FromStream(ms);
            ms.Close();
            return ret;
        }
    }
}
