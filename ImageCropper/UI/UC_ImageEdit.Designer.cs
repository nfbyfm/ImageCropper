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
      this.imagePanel = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.trackBar_Brightness = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.trackBar_Contrast = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.cB_RotateFlip = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.imagePanel)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).BeginInit();
      this.SuspendLayout();
      // 
      // imagePanel
      // 
      this.imagePanel.BackColor = System.Drawing.Color.Transparent;
      this.tableLayoutPanel1.SetColumnSpan(this.imagePanel, 2);
      this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imagePanel.Location = new System.Drawing.Point(3, 3);
      this.imagePanel.Name = "imagePanel";
      this.imagePanel.Size = new System.Drawing.Size(682, 360);
      this.imagePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imagePanel.TabIndex = 0;
      this.imagePanel.TabStop = false;
      this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ImagePanel_Paint);
      this.imagePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseDown);
      this.imagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseMove);
      this.imagePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseUp);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.imagePanel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.trackBar_Brightness, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.trackBar_Contrast, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.cB_RotateFlip, 1, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 447);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(3, 366);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 27);
      this.label2.TabIndex = 2;
      this.label2.Text = "Brightness:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // trackBar_Brightness
      // 
      this.trackBar_Brightness.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBar_Brightness.LargeChange = 10;
      this.trackBar_Brightness.Location = new System.Drawing.Point(89, 369);
      this.trackBar_Brightness.Maximum = 100;
      this.trackBar_Brightness.Minimum = -100;
      this.trackBar_Brightness.Name = "trackBar_Brightness";
      this.trackBar_Brightness.Size = new System.Drawing.Size(596, 21);
      this.trackBar_Brightness.SmallChange = 5;
      this.trackBar_Brightness.TabIndex = 3;
      this.trackBar_Brightness.TickFrequency = 5;
      this.trackBar_Brightness.ValueChanged += new System.EventHandler(this.SetBrightnessAndContrast);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(3, 393);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 27);
      this.label3.TabIndex = 4;
      this.label3.Text = "Contrast:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // trackBar_Contrast
      // 
      this.trackBar_Contrast.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBar_Contrast.LargeChange = 10;
      this.trackBar_Contrast.Location = new System.Drawing.Point(89, 396);
      this.trackBar_Contrast.Maximum = 100;
      this.trackBar_Contrast.Minimum = -100;
      this.trackBar_Contrast.Name = "trackBar_Contrast";
      this.trackBar_Contrast.Size = new System.Drawing.Size(596, 21);
      this.trackBar_Contrast.SmallChange = 5;
      this.trackBar_Contrast.TabIndex = 5;
      this.trackBar_Contrast.TickFrequency = 5;
      this.trackBar_Contrast.ValueChanged += new System.EventHandler(this.SetBrightnessAndContrast);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 420);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 27);
      this.label1.TabIndex = 6;
      this.label1.Text = "rotate / flip:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cB_RotateFlip
      // 
      this.cB_RotateFlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cB_RotateFlip.FormattingEnabled = true;
      this.cB_RotateFlip.Location = new System.Drawing.Point(89, 423);
      this.cB_RotateFlip.Name = "cB_RotateFlip";
      this.cB_RotateFlip.Size = new System.Drawing.Size(201, 23);
      this.cB_RotateFlip.TabIndex = 7;
      // 
      // UC_ImageEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "UC_ImageEdit";
      this.Size = new System.Drawing.Size(688, 447);
      ((System.ComponentModel.ISupportInitialize)(this.imagePanel)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private PictureBox imagePanel;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label2;
    private TrackBar trackBar_Brightness;
    private Label label3;
    private TrackBar trackBar_Contrast;
        private Label label1;
        private ComboBox cB_RotateFlip;
    }
}
