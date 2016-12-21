namespace ConwayNnL
{
  partial class Form1
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

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.button2 = new System.Windows.Forms.Button();
      this.boardControl1 = new ConwayNnL.BoardControl();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(463, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(49, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Go";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // trackBar1
      // 
      this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar1.LargeChange = 20;
      this.trackBar1.Location = new System.Drawing.Point(12, 1);
      this.trackBar1.Maximum = 80;
      this.trackBar1.Minimum = 10;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(390, 45);
      this.trackBar1.SmallChange = 5;
      this.trackBar1.TabIndex = 2;
      this.trackBar1.Value = 40;
      this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.Location = new System.Drawing.Point(408, 8);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(49, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Reset";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // boardControl1
      // 
      this.boardControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.boardControl1.BoardDimension = 30;
      this.boardControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.boardControl1.Location = new System.Drawing.Point(12, 38);
      this.boardControl1.Name = "boardControl1";
      this.boardControl1.Size = new System.Drawing.Size(500, 400);
      this.boardControl1.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(528, 457);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.boardControl1);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "N&L Game of Life";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TrackBar trackBar1;
    private BoardControl boardControl1;
    private System.Windows.Forms.Button button2;
  }
}

