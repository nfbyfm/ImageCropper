namespace ImageCropper
{
  partial class UC_ImageEdit
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      imagePanel = new PictureBox();
      tableLayoutPanel1 = new TableLayoutPanel();
      label2 = new Label();
      trackBar_Brightness = new TrackBar();
      label3 = new Label();
      trackBar_Contrast = new TrackBar();
      ((System.ComponentModel.ISupportInitialize)imagePanel).BeginInit();
      tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)trackBar_Brightness).BeginInit();
      ((System.ComponentModel.ISupportInitialize)trackBar_Contrast).BeginInit();
      SuspendLayout();
      // 
      // imagePanel
      // 
      imagePanel.BackColor = Color.Transparent;
      tableLayoutPanel1.SetColumnSpan(imagePanel, 2);
      imagePanel.Dock = DockStyle.Fill;
      imagePanel.Location = new Point(3, 3);
      imagePanel.Name = "imagePanel";
      imagePanel.Size = new Size(682, 387);
      imagePanel.SizeMode = PictureBoxSizeMode.Zoom;
      imagePanel.TabIndex = 0;
      imagePanel.TabStop = false;
      imagePanel.Paint += ImagePanel_Paint;
      imagePanel.MouseDown += imagePanel_MouseDown;
      imagePanel.MouseMove += imagePanel_MouseMove;
      imagePanel.MouseUp += imagePanel_MouseUp;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(imagePanel, 0, 0);
      tableLayoutPanel1.Controls.Add(label2, 0, 1);
      tableLayoutPanel1.Controls.Add(trackBar_Brightness, 1, 1);
      tableLayoutPanel1.Controls.Add(label3, 0, 2);
      tableLayoutPanel1.Controls.Add(trackBar_Contrast, 1, 2);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 3;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      tableLayoutPanel1.Size = new Size(688, 447);
      tableLayoutPanel1.TabIndex = 1;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Dock = DockStyle.Fill;
      label2.Location = new Point(3, 393);
      label2.Name = "label2";
      label2.Size = new Size(80, 27);
      label2.TabIndex = 2;
      label2.Text = "Brightness:";
      label2.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // trackBar_Brightness
      // 
      trackBar_Brightness.Dock = DockStyle.Fill;
      trackBar_Brightness.LargeChange = 10;
      trackBar_Brightness.Location = new Point(89, 396);
      trackBar_Brightness.Maximum = 100;
      trackBar_Brightness.Minimum = -100;
      trackBar_Brightness.Name = "trackBar_Brightness";
      trackBar_Brightness.Size = new Size(596, 21);
      trackBar_Brightness.SmallChange = 5;
      trackBar_Brightness.TabIndex = 3;
      trackBar_Brightness.TickFrequency = 5;
      trackBar_Brightness.Scroll += SetBrightnessAndContrast;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Dock = DockStyle.Fill;
      label3.Location = new Point(3, 420);
      label3.Name = "label3";
      label3.Size = new Size(80, 27);
      label3.TabIndex = 4;
      label3.Text = "Contrast:";
      label3.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // trackBar_Contrast
      // 
      trackBar_Contrast.Dock = DockStyle.Fill;
      trackBar_Contrast.LargeChange = 10;
      trackBar_Contrast.Location = new Point(89, 423);
      trackBar_Contrast.Maximum = 100;
      trackBar_Contrast.Minimum = -100;
      trackBar_Contrast.Name = "trackBar_Contrast";
      trackBar_Contrast.Size = new Size(596, 21);
      trackBar_Contrast.SmallChange = 5;
      trackBar_Contrast.TabIndex = 5;
      trackBar_Contrast.TickFrequency = 5;
      trackBar_Contrast.Scroll += SetBrightnessAndContrast;
      // 
      // UC_ImageEdit
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(tableLayoutPanel1);
      Name = "UC_ImageEdit";
      Size = new Size(688, 447);
      ((System.ComponentModel.ISupportInitialize)imagePanel).EndInit();
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)trackBar_Brightness).EndInit();
      ((System.ComponentModel.ISupportInitialize)trackBar_Contrast).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private PictureBox imagePanel;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label2;
    private TrackBar trackBar_Brightness;
    private Label label3;
    private TrackBar trackBar_Contrast;
  }
}
