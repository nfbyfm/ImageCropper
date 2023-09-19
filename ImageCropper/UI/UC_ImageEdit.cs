using ImageCropper.Extensions;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace ImageCropper
{
  public partial class UC_ImageEdit : UserControl
  {
    private string _filePath;
    private Image? _image;

    public UC_ImageEdit(string filePath)
    {
      InitializeComponent();

      DoubleBuffered = true;

      _filePath = filePath;

      LoadImage();
    }

    internal void Close()
    {
      _image?.Dispose();
    }

    #region load and save functions
    private void LoadImage()
    {
      try
      {
        _image = Image.FromFile(_filePath);
        imagePanel.Image = _image;

        this.Invalidate();
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex);
      }
    }

    internal void SaveImage()
    {
      if (_image == null)
      {
        MessageBox.Show("Please load an image first.");
      }
      else if (!_mouseDownLocationSet)
      {
        MessageBox.Show("Please select the part of the image you want to save.");
      }
      else
      {
        try
        {
          string saveFilePath = GetSaveFilePath(_filePath);

          Rectangle cropRectangle = GetCropRectangle(_mouseDownLocation, _mouseUpLocation, _image);

          if (trackBar_Brightness.Value != 0 || trackBar_Contrast.Value != 0)
          {
            using (Image croppedImage = _image.GetCroppedImage(cropRectangle, trackBar_Brightness.Value * 0.01f, trackBar_Contrast.Value))
            {
              croppedImage.Save(saveFilePath, ImageFormat.Jpeg);
            }
          }
          else
          {
            using (Image croppedImage = _image.GetCroppedImage(cropRectangle))
            {
              croppedImage.Save(saveFilePath, ImageFormat.Jpeg);
            }
          }

          MessageBox.Show($"Successfully saved image to '{saveFilePath}'.", "Save image to file", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
          MessageBox.Show($"Failed to save the image: {ex.Message}", "Error saving to file", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    #endregion

    #region save helper functions
    private string GetSaveFilePath(string imageFilePath)
    {
      string result = imageFilePath;

      string? directoryPath = Path.GetDirectoryName(imageFilePath);// imageFilePath.Remove(imageFilePath.LastIndexOf(Path.DirectorySeparatorChar));

      if (Directory.Exists(directoryPath))
      {
        string directoryName = directoryPath.Remove(0, directoryPath.LastIndexOf(Path.DirectorySeparatorChar) + 1);

        string[] filePaths = Directory.GetFiles(directoryPath, "*.jpg", SearchOption.TopDirectoryOnly);
        int suffixNumber = 1;

        foreach (string fPath in filePaths)
        {
          string fPa = Path.GetFileNameWithoutExtension(fPath);
          if (fPa.StartsWith(directoryName))
          {
            if (int.TryParse(fPa.Replace(directoryName, "").Replace('_', ' '), out int res))
              suffixNumber = Math.Max(suffixNumber, res + 1);
          }
        }

        result = Path.Combine(directoryPath, directoryName + "_" + suffixNumber.ToString() + ".jpg");
      }

      return result;
    }

    private Rectangle GetCropRectangle(Point p1, Point p2, Image originalImage)
    {
      // calculate scaling factor

      float nPercentW = ((float)imagePanel.Width / (float)originalImage.Width);
      float nPercentH = ((float)imagePanel.Height / (float)originalImage.Height);
      float nPercent = Math.Min(nPercentW, nPercentH);

      float imageWidth = originalImage.Width * nPercent;

      float xCorrection = (float)((imagePanel.Width - imageWidth) / 2.0);

      int x = (int)(((float)Math.Min(p1.X, p2.X) - xCorrection) / nPercent);
      int y = (int)(Math.Min(p1.Y, p2.Y) / nPercent);
      int width = (int)(Math.Abs(p1.X - p2.X) / nPercent);
      int height = (int)(Math.Abs(p1.Y - p2.Y) / nPercent);

      return new(x, y, width, height);
    }

    private Rectangle GetRectangle(Point p1, Point p2)
    {
      int x = Math.Min(p1.X, p2.X);
      int y = Math.Min(p1.Y, p2.Y);
      int width = Math.Abs(p1.X - p2.X);
      int height = Math.Abs(p1.Y - p2.Y);

      return new(x, y, width, height);
    }

    #endregion

    #region crop selection functions
    private bool _mouseDownLocationSet = false;
    private Point _mouseDownLocation;
    private Point _mouseLocation;
    private Point _mouseUpLocation;
    private bool _mouseIsDown = false;

    private void imagePanel_MouseDown(object sender, MouseEventArgs e)
    {
      _mouseDownLocation = e.Location;
      _mouseDownLocationSet = true;
      _mouseIsDown = true;
    }

    private void imagePanel_MouseMove(object sender, MouseEventArgs e)
    {
      bool invalidate = _mouseIsDown &&
        (Math.Abs(_mouseLocation.X - e.Location.X) < 2 ||
          Math.Abs(_mouseLocation.Y - e.Location.Y) < 2);

      _mouseLocation = e.Location;

      if (invalidate)
        imagePanel.Invalidate();
    }

    private void imagePanel_MouseUp(object sender, MouseEventArgs e)
    {
      _mouseUpLocation = e.Location;
      _mouseIsDown = false;
      imagePanel.Invalidate();
    }

    private void ImagePanel_Paint(object sender, PaintEventArgs e)
    {
      if (_mouseIsDown)
      {
        e.Graphics.DrawRectangle(new Pen(Color.Orange, 1), GetRectangle(_mouseLocation, _mouseDownLocation));
      }
      else if (_mouseDownLocationSet)
      {
        e.Graphics.DrawRectangle(new Pen(Color.Green, 1), GetRectangle(_mouseUpLocation, _mouseDownLocation));
      }
    }

    #endregion

    #region brightness and contrast



    private void SetBrightnessAndContrast(object sender, EventArgs e)
    {
      if (_image != null)
      {
        imagePanel.Image = ((Bitmap)_image).SetBrightnessAndContrast(trackBar_Brightness.Value * 0.01f, trackBar_Contrast.Value);
      }
    }

    #endregion

  }
}
