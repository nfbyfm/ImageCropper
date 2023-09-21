namespace ImageCropper
{
  partial class MainWindow
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      menuStrip1 = new MenuStrip();
      fileToolStripMenuItem = new ToolStripMenuItem();
      toolStripMenuItem1 = new ToolStripMenuItem();
      saveToolStripMenuItem = new ToolStripMenuItem();
      closeToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      quitToolStripMenuItem = new ToolStripMenuItem();
      extrasToolStripMenuItem = new ToolStripMenuItem();
      aboutToolStripMenuItem = new ToolStripMenuItem();
      tabControl1 = new TabControl();
      tabPage1 = new TabPage();
      tabPage2 = new TabPage();
      toolStripSeparator2 = new ToolStripSeparator();
      menuStrip1.SuspendLayout();
      tabControl1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, extrasToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Padding = new Padding(5, 2, 0, 2);
      menuStrip1.Size = new Size(686, 24);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripSeparator2, saveToolStripMenuItem, closeToolStripMenuItem, toolStripSeparator1, quitToolStripMenuItem });
      fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      fileToolStripMenuItem.Size = new Size(31, 20);
      fileToolStripMenuItem.Text = "&File";
      // 
      // toolStripMenuItem1
      // 
      toolStripMenuItem1.Name = "toolStripMenuItem1";
      toolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.O;
      toolStripMenuItem1.Size = new Size(132, 22);
      toolStripMenuItem1.Text = "&Open";
      toolStripMenuItem1.Click += Open_Click;
      // 
      // saveToolStripMenuItem
      // 
      saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
      saveToolStripMenuItem.Size = new Size(132, 22);
      saveToolStripMenuItem.Text = "&Save";
      saveToolStripMenuItem.Click += Save_Click;
      // 
      // closeToolStripMenuItem
      // 
      closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
      closeToolStripMenuItem.Size = new Size(132, 22);
      closeToolStripMenuItem.Text = "&Close";
      closeToolStripMenuItem.Click += Close_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(129, 6);
      // 
      // quitToolStripMenuItem
      // 
      quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
      quitToolStripMenuItem.Size = new Size(132, 22);
      quitToolStripMenuItem.Text = "&Quit";
      quitToolStripMenuItem.Click += Quit_Click;
      // 
      // extrasToolStripMenuItem
      // 
      extrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
      extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
      extrasToolStripMenuItem.Size = new Size(42, 20);
      extrasToolStripMenuItem.Text = "&Extras";
      // 
      // aboutToolStripMenuItem
      // 
      aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      aboutToolStripMenuItem.ShortcutKeys = Keys.F1;
      aboutToolStripMenuItem.Size = new Size(112, 22);
      aboutToolStripMenuItem.Text = "&About";
      aboutToolStripMenuItem.Click += About_Click;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 24);
      tabControl1.Margin = new Padding(3, 2, 3, 2);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(686, 336);
      tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      tabPage1.Location = new Point(4, 21);
      tabPage1.Margin = new Padding(3, 2, 3, 2);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3, 2, 3, 2);
      tabPage1.Size = new Size(678, 311);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "tabPage1";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      tabPage2.Location = new Point(4, 21);
      tabPage2.Margin = new Padding(3, 2, 3, 2);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3, 2, 3, 2);
      tabPage2.Size = new Size(678, 311);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "tabPage2";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(129, 6);
      // 
      // MainWindow
      // 
      AllowDrop = true;
      AutoScaleDimensions = new SizeF(6F, 12F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(686, 360);
      Controls.Add(tabControl1);
      Controls.Add(menuStrip1);
      Icon = (Icon)resources.GetObject("$this.Icon");
      MainMenuStrip = menuStrip1;
      Margin = new Padding(3, 2, 3, 2);
      Name = "MainWindow";
      Text = "Image cropper";
      DragDrop += MainWindow_DragDrop;
      DragEnter += MainWindow_DragEnter;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      tabControl1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem quitToolStripMenuItem;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private ToolStripMenuItem closeToolStripMenuItem;
    private ToolStripMenuItem extrasToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
  }
}