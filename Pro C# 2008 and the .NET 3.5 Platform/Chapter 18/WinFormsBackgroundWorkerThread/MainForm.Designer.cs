namespace WinFormsBackgroundWorkerThread
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
      this.label2 = new System.Windows.Forms.Label();
      this.btnProcessData = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtFirstNumber = new System.Windows.Forms.TextBox();
      this.txtSecondNumber = new System.Windows.Forms.TextBox();
      this.ProcessNumbersBackgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(294, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Please Enter Two Values to Process on a Secondary Thread";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "First Number";
      // 
      // btnProcessData
      // 
      this.btnProcessData.Location = new System.Drawing.Point(236, 127);
      this.btnProcessData.Name = "btnProcessData";
      this.btnProcessData.Size = new System.Drawing.Size(105, 23);
      this.btnProcessData.TabIndex = 2;
      this.btnProcessData.Text = "Process Data";
      this.btnProcessData.UseVisualStyleBackColor = true;
      this.btnProcessData.Click += new System.EventHandler(this.btnProcessData_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(84, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Second Number";
      // 
      // txtFirstNumber
      // 
      this.txtFirstNumber.Location = new System.Drawing.Point(117, 38);
      this.txtFirstNumber.Name = "txtFirstNumber";
      this.txtFirstNumber.Size = new System.Drawing.Size(190, 20);
      this.txtFirstNumber.TabIndex = 4;
      // 
      // txtSecondNumber
      // 
      this.txtSecondNumber.Location = new System.Drawing.Point(117, 72);
      this.txtSecondNumber.Name = "txtSecondNumber";
      this.txtSecondNumber.Size = new System.Drawing.Size(190, 20);
      this.txtSecondNumber.TabIndex = 5;
      // 
      // ProcessNumbersBackgroundWorker
      // 
      this.ProcessNumbersBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProcessNumbersBackgroundWorker_DoWork);
      this.ProcessNumbersBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProcessNumbersBackgroundWorker_RunWorkerCompleted);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(353, 162);
      this.Controls.Add(this.txtSecondNumber);
      this.Controls.Add(this.txtFirstNumber);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnProcessData);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Fun with BackgroundWorker ";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnProcessData;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtFirstNumber;
    private System.Windows.Forms.TextBox txtSecondNumber;
    private System.ComponentModel.BackgroundWorker ProcessNumbersBackgroundWorker;
  }
}

