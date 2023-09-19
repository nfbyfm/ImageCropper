using System.Diagnostics;
using System.Reflection;

namespace ImageCropper
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();

      tabControl1.TabPages.Clear();
    }

    #region menu bar event listeners

    private void Open_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new()
      {
        Title = "select images to open",
        RestoreDirectory = true,
        Multiselect = true,
        Filter = "image-file|*.jpg"
      };

      if (ofd.ShowDialog() == DialogResult.OK)
      {
        if (ofd.FileNames != null && ofd.FileNames.Length > 0)
        {
          for (int i = 0; i < ofd.FileNames.Length; i++)
          {
            string filePath = ofd.FileNames[i];

            if (File.Exists(filePath))
            {
              TabPage newTabPage = new(Path.GetFileName(filePath));
              UC_ImageEdit imageEdit = new(filePath)
              {
                Dock = DockStyle.Fill
              };

              newTabPage.Controls.Add(imageEdit);

              tabControl1.TabPages.Add(newTabPage);
            }
          }
        }
      }
    }

    private void Save_Click(object sender, EventArgs e)
    {
      if (tabControl1.SelectedIndex >= 0 && tabControl1.SelectedTab != null)
      {
        foreach (Control subControl in tabControl1.SelectedTab.Controls)
        {
          if (subControl != null && subControl.GetType() == typeof(UC_ImageEdit))
          {
            UC_ImageEdit edit = (UC_ImageEdit)subControl;
            edit.SaveImage();
          }
        }
      }
    }

    private void Close_Click(object sender, EventArgs e)
    {
      if (tabControl1.SelectedIndex >= 0 && tabControl1.SelectedTab != null)
      {
        CloseImageEdit(tabControl1.SelectedTab);

        tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
      }
    }

    private void Quit_Click(object sender, EventArgs e)
    {
      if (this.tabControl1.TabPages.Count > 0)
      {
        foreach (TabPage page in this.tabControl1.TabPages)
        {
          CloseImageEdit(page);
        }
      }

      this.Close();
    }

    private void About_Click(object sender, EventArgs e)
    {
      //create strings for message box
      string dialogTitle = "ImageCropper";
      string dialogMessage = "Windows desktop application for cropping images." + Environment.NewLine;

      try
      {
        Version? appVersion = Assembly.GetExecutingAssembly().GetName().Version;

        if (appVersion != null)
          dialogMessage += Environment.NewLine + "Version: " + appVersion.ToString();
      }
      catch (Exception ex)
      {
        Debug.WriteLine("Failed to get the version of the current application: " + ex.Message);
      }

      dialogMessage += Environment.NewLine + "https://github.com/nfbyfm/ImageCropper";

      //show messagebox
      MessageBox.Show(dialogMessage, dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    #endregion

    /// <summary>
    /// function for safely close a tab page
    /// </summary>
    /// <param name="page"></param>
    private static void CloseImageEdit(TabPage page)
    {
      if (page != null)
      {
        foreach (Control subControl in page.Controls)
        {
          if (subControl != null && subControl.GetType() == typeof(UC_ImageEdit))
          {
            UC_ImageEdit edit = (UC_ImageEdit)subControl;
            edit.Close();
          }
        }
      }
    }
  }
}