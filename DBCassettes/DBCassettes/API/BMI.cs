using DBCassettes.API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;


namespace DBCassettes.API
{
 

    static class BMI
    {
        public static BitmapImage GetImageFromDataBase(byte[] ByteArray)
        {
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.StreamSource = new MemoryStream(ByteArray);
            bmp.DecodePixelHeight = 200;
            bmp.EndInit();
            return bmp;
        }
        public static BitmapImage LoadImage(Uri uri)
        {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = uri;
            bitmap.DecodePixelHeight = 200;
            bitmap.EndInit();
            return bitmap;
        }

        public static byte[] LoadImageToDataBase(BitmapImage image)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            };
            return data;
        }
    }
}
