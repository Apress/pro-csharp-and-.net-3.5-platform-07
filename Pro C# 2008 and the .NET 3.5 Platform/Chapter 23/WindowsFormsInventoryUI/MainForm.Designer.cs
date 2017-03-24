namespace WindowsFormsInventoryUI
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
      this.inventoryGrid = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.btnUpdateInventory = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // inventoryGrid
      // 
      this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.inventoryGrid.Location = new System.Drawing.Point(13, 48);
      this.inventoryGrid.Name = "inventoryGrid";
      this.inventoryGrid.Size = new System.Drawing.Size(414, 298);
      this.inventoryGrid.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(366, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Make Changes to the Grid and Click the Update Button to Process Changes";
      // 
      // btnUpdateInventory
      // 
      this.btnUpdateInventory.Location = new System.Drawing.Point(13, 364);
      this.btnUpdateInventory.Name = "btnUpdateInventory";
      this.btnUpdateInventory.Size = new System.Drawing.Size(93, 23);
      this.btnUpdateInventory.TabIndex = 2;
      this.btnUpdateInventory.Text = "Update!";
      this.btnUpdateInventory.UseVisualStyleBackColor = true;
      this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(439, 399);
      this.Controls.Add(this.btnUpdateInventory);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.inventoryGrid);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Inventory GUI";
      ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView inventoryGrid;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnUpdateInventory;
  }
}

