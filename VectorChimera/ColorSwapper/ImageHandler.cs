using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
//using ImageMagick;

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

        public static Bitmap ScaleBitmap(Bitmap b, float nWidth, float nHeight)
        {
            Bitmap result = ResizeBitmap(b, (int)(nWidth * b.Width), (int)(nHeight * b.Height));
            return result;
        }

        public static Image LoadImageNoLock(string path)
        {
            var ms = new MemoryStream(File.ReadAllBytes(path)); // Don't use using!!
            Image ret = Image.FromStream(ms);
            
            //TODO: Find a better way to do this:
            if (path.Substring(path.Length - 3, 3) != "gif") ms.Close();

            return ret;
        }
        /*
        internal static Image ResizeGif(string path, int nWidth, int nHeight)
        {

            var image = new MagickImage(path);
            image.Interpolate = PixelInterpolateMethod.Nearest;
            //image.Scale(nWidth, nHeight);
            //->coalesceImages(); 
            
            
            
            foreach ($image as $frame) { 
              $frame->cropImage($crop_w, $crop_h, $crop_x, $crop_y); 
              $frame->thumbnailImage($size_w, $size_h); 
              $frame->setImagePage($size_w, $size_h, 0, 0); 
            } 

            $image = $image->deconstructImages(); 
            $image->writeImages($file_dst, true); 


        var ms = new MemoryStream(image.ToByteArray(MagickFormat.Gif)); // Don't use using!!
            //var ms = new MemoryStream(File.ReadAllBytes(path)); // Don't use using!!
            Image ret = Image.FromStream(ms);
            
            return ret;
        }*/
    }
}
