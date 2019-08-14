using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace KYCProcessPassportWebjob.AbbyyCloudOCR
{
    public static class ImageStream
    {
        public static MemoryStream GetImageStream(Stream blob)
        {
            //Change image back to a stream for passing through to user as Http Content
            MemoryStream streamOut = new MemoryStream();
            try
            {
                Image originalImage = Bitmap.FromStream(blob);

                //Pass the image and requested file size into our image resizing method to resize the image
                Image resizedImage = ResizeImage(originalImage, 760, 500);

                resizedImage.Save(streamOut, ImageFormat.Jpeg);
                streamOut.Position = 0;

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return streamOut;
        }

        //Method to resize images without distortion
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);
            try
            {
                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return destImage;
        }

    }
}
