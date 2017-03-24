namespace FileOrIsoStorageWinApp
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.btnFileIO = new System.Windows.Forms.Button();
      this.btnIsoStorage = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(277, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Change the Permission Set of My_Computer_Zone to test";
      // 
      // btnFileIO
      // 
      this.btnFileIO.Location = new System.Drawing.Point(16, 50);
      this.btnFileIO.Name = "btnFileIO";
      this.btnFileIO.Size = new System.Drawing.Size(150, 23);
      this.btnFileIO.TabIndex = 1;
      this.btnFileIO.Text = "Write Data with File IO";
      this.btnFileIO.UseVisualStyleBackColor = true;
      this.btnFileIO.Click += new System.EventHandler(this.btnFileIO_Click);
      // 
      // btnIsoStorage
      // 
      this.btnIsoStorage.Location = new System.Drawing.Point(181, 50);
      this.btnIsoStorage.Name = "btnIsoStorage";
      this.btnIsoStorage.Size = new System.Drawing.Size(150, 23);
      this.btnIsoStorage.TabIndex = 2;
      this.btnIsoStorage.Text = "Write Data with Iso Storage";
      this.btnIsoStorage.UseVisualStyleBackColor = true;
      this.btnIsoStorage.Click += new System.EventHandler(this.btnIsoStorage_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(351, 95);
      this.Controls.Add(this.btnIsoStorage);
      this.Controls.Add(this.btnFileIO);
      this.Controls.Add(this.label1);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "File IO / Iso Storage";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnFileIO;
    private System.Windows.Forms.Button btnIsoStorage;
  }
}

