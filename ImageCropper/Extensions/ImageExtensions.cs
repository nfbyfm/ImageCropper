using ImageCropper.Models;
using System.Drawing.Imaging;

namespace ImageCropper.Extensions
{
  internal static class ImageExtensions
  {
    /// <summary>
    /// creates a cropped image
    /// </summary>
    /// <param name="img"></param>
    /// <param name="cropArea"></param>
    /// <returns></returns>
    public static Image GetCroppedImage(this Image img, Rectangle cropArea)
    {
      Bitmap bmpImage = new(img);
      return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
    }

    /// <summary>
    /// creates a cropped image, with additionally setting the brightness and contrast values
    /// </summary>
    /// <param name="img"></param>
    /// <param name="cropArea"></param>
    /// <param name="brightness"></param>
    /// <param name="contrast"></param>
    /// <returns></returns>
    public static Image GetCroppedImage(this Image img, Rectangle cropArea, float brightness, int contrast)
    {
      Bitmap bmpImage = new(img);
      bmpImage = bmpImage.SetBrightnessAndContrast(brightness, contrast);
      return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
    }
    
    /// <summary>
    /// creates a copy of the current bitmap and changes its brightness and ccontrast values
    /// </summary>
    /// <param name="bmpIn"></param>
    /// <param name="brightness"></param>
    /// <param name="contrast"></param>
    /// <returns></returns>
    internal static Bitmap SetBrightnessAndContrast(this Bitmap bmpIn, float brightness, int contrast)
    {
      Bitmap bmpOut = new(bmpIn.Width, bmpIn.Height);
      brightness = Math.Max(-100, Math.Min(brightness, 100));
      Rectangle r = new(0, 0, bmpIn.Width, bmpIn.Height);

      float[][] matrixItems = {
        new float[] {1,0,0,0,0},
        new float[] {0,1,0,0,0},
        new float[] {0,0,1,0,0},
        new float[] {0,0,0,1,0},
        new float[] {brightness,brightness,brightness,0,1} };

      ColorMatrix colorMatrix = new(matrixItems);

      ImageAttributes imageAtt = new();
      imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

      using (Graphics g = Graphics.FromImage(bmpOut))
        g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

      bmpOut.SetContrast(contrast);

      return bmpOut;
    }

    /// <summary>
    /// sets the contrast of the current bitmap
    /// </summary>
    /// <param name="bmp">the current image / bitmap</param>
    /// <param name="threshold">threshold should be a value between -100 and 100</param>
    internal static void SetContrast(this Bitmap bmp, int threshold)
    {
      var lockedBitmap = new LockBitmap(bmp);
      lockedBitmap.LockBits();

      threshold = Math.Max(-100, Math.Min(threshold, 100));

      var contrast = Math.Pow((100.0 + threshold) / 100.0, 2);

      for (int y = 0; y < lockedBitmap.Height; y++)
      {
        for (int x = 0; x < lockedBitmap.Width; x++)
        {
          var oldColor = lockedBitmap.GetPixel(x, y);
          var red = ((oldColor.R / 255.0 - 0.5) * contrast + 0.5) * 255.0;
          var green = ((oldColor.G / 255.0 - 0.5) * contrast + 0.5) * 255.0;
          var blue = ((oldColor.B / 255.0 - 0.5) * contrast + 0.5) * 255.0;
          if (red > 255)
            red = 255;
          if (red < 0)
            red = 0;
          if (green > 255)
            green = 255;
          if (green < 0)
            green = 0;
          if (blue > 255)
            blue = 255;
          if (blue < 0)
            blue = 0;

          var newColor = Color.FromArgb(oldColor.A, (int)red, (int)green, (int)blue);
          lockedBitmap.SetPixel(x, y, newColor);
        }
      }
      lockedBitmap.UnlockBits();
    }
  }
}
