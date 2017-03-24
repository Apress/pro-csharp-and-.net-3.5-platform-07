namespace CreditCheckApp
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
      this.btnCheckCustomerCredit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCustomerID = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnCheckCustomerCredit
      // 
      this.btnCheckCustomerCredit.Location = new System.Drawing.Point(16, 54);
      this.btnCheckCustomerCredit.Name = "btnCheckCustomerCredit";
      this.btnCheckCustomerCredit.Size = new System.Drawing.Size(197, 23);
      this.btnCheckCustomerCredit.TabIndex = 0;
      this.btnCheckCustomerCredit.Text = "Check Credit";
      this.btnCheckCustomerCredit.UseVisualStyleBackColor = true;
      this.btnCheckCustomerCredit.Click += new System.EventHandler(this.btnCheckCustomerCredit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Check my Credit";
      // 
      // txtCustomerID
      // 
      this.txtCustomerID.Location = new System.Drawing.Point(113, 13);
      this.txtCustomerID.Name = "txtCustomerID";
      this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
      this.txtCustomerID.TabIndex = 2;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(232, 97);
      this.Controls.Add(this.txtCustomerID);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCheckCustomerCredit);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Credit Checker";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCheckCustomerCredit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCustomerID;
  }
}

