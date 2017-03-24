namespace WindowsFormsDataTableViewer
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
          this.carInventoryGridView = new System.Windows.Forms.DataGridView();
          this.label1 = new System.Windows.Forms.Label();
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.txtRowToRemove = new System.Windows.Forms.TextBox();
          this.btnRemoveRow = new System.Windows.Forms.Button();
          this.groupBox2 = new System.Windows.Forms.GroupBox();
          this.txtMakeToView = new System.Windows.Forms.TextBox();
          this.btnDisplayMakes = new System.Windows.Forms.Button();
          this.btnChangeBeemersToYugos = new System.Windows.Forms.Button();
          this.dataGridColtsView = new System.Windows.Forms.DataGridView();
          this.label2 = new System.Windows.Forms.Label();
          ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
          this.groupBox1.SuspendLayout();
          this.groupBox2.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridColtsView)).BeginInit();
          this.SuspendLayout();
          // 
          // carInventoryGridView
          // 
          this.carInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.carInventoryGridView.Location = new System.Drawing.Point(13, 48);
          this.carInventoryGridView.Name = "carInventoryGridView";
          this.carInventoryGridView.Size = new System.Drawing.Size(402, 135);
          this.carInventoryGridView.TabIndex = 0;
          this.carInventoryGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.carInventoryGridView_RowPostPaint);
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(13, 12);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(141, 13);
          this.label1.TabIndex = 1;
          this.label1.Text = "The Current List of Inventory";
          // 
          // groupBox1
          // 
          this.groupBox1.Controls.Add(this.txtRowToRemove);
          this.groupBox1.Controls.Add(this.btnRemoveRow);
          this.groupBox1.Location = new System.Drawing.Point(13, 204);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Size = new System.Drawing.Size(177, 85);
          this.groupBox1.TabIndex = 2;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Enter row number to delete";
          // 
          // txtRowToRemove
          // 
          this.txtRowToRemove.Location = new System.Drawing.Point(6, 22);
          this.txtRowToRemove.Name = "txtRowToRemove";
          this.txtRowToRemove.Size = new System.Drawing.Size(135, 20);
          this.txtRowToRemove.TabIndex = 1;
          // 
          // btnRemoveRow
          // 
          this.btnRemoveRow.Location = new System.Drawing.Point(6, 48);
          this.btnRemoveRow.Name = "btnRemoveRow";
          this.btnRemoveRow.Size = new System.Drawing.Size(135, 23);
          this.btnRemoveRow.TabIndex = 0;
          this.btnRemoveRow.Text = "Remove";
          this.btnRemoveRow.UseVisualStyleBackColor = true;
          this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
          // 
          // groupBox2
          // 
          this.groupBox2.Controls.Add(this.txtMakeToView);
          this.groupBox2.Controls.Add(this.btnDisplayMakes);
          this.groupBox2.Location = new System.Drawing.Point(238, 204);
          this.groupBox2.Name = "groupBox2";
          this.groupBox2.Size = new System.Drawing.Size(177, 85);
          this.groupBox2.TabIndex = 3;
          this.groupBox2.TabStop = false;
          this.groupBox2.Text = "Enter make To view";
          // 
          // txtMakeToView
          // 
          this.txtMakeToView.Location = new System.Drawing.Point(6, 22);
          this.txtMakeToView.Name = "txtMakeToView";
          this.txtMakeToView.Size = new System.Drawing.Size(135, 20);
          this.txtMakeToView.TabIndex = 1;
          // 
          // btnDisplayMakes
          // 
          this.btnDisplayMakes.Location = new System.Drawing.Point(6, 48);
          this.btnDisplayMakes.Name = "btnDisplayMakes";
          this.btnDisplayMakes.Size = new System.Drawing.Size(135, 23);
          this.btnDisplayMakes.TabIndex = 0;
          this.btnDisplayMakes.Text = "Display Makes";
          this.btnDisplayMakes.UseVisualStyleBackColor = true;
          this.btnDisplayMakes.Click += new System.EventHandler(this.btnDisplayMakes_Click);
          // 
          // btnChangeBeemersToYugos
          // 
          this.btnChangeBeemersToYugos.Location = new System.Drawing.Point(238, 12);
          this.btnChangeBeemersToYugos.Name = "btnChangeBeemersToYugos";
          this.btnChangeBeemersToYugos.Size = new System.Drawing.Size(177, 23);
          this.btnChangeBeemersToYugos.TabIndex = 4;
          this.btnChangeBeemersToYugos.Text = "Change All BMWs to Yugos";
          this.btnChangeBeemersToYugos.UseVisualStyleBackColor = true;
          this.btnChangeBeemersToYugos.Click += new System.EventHandler(this.btnChangeBeemersToYugos_Click);
          // 
          // dataGridColtsView
          // 
          this.dataGridColtsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dataGridColtsView.Location = new System.Drawing.Point(13, 323);
          this.dataGridColtsView.Name = "dataGridColtsView";
          this.dataGridColtsView.Size = new System.Drawing.Size(402, 95);
          this.dataGridColtsView.TabIndex = 5;
          this.dataGridColtsView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridColtsView_RowPostPaint);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(13, 297);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(95, 13);
          this.label2.TabIndex = 6;
          this.label2.Text = "Here are the Colts:";
          // 
          // MainForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(427, 430);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.dataGridColtsView);
          this.Controls.Add(this.btnChangeBeemersToYugos);
          this.Controls.Add(this.groupBox2);
          this.Controls.Add(this.groupBox1);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.carInventoryGridView);
          this.Name = "MainForm";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "DataTable Viewer";
          ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          this.groupBox2.ResumeLayout(false);
          this.groupBox2.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridColtsView)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carInventoryGridView;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtRowToRemove;
      private System.Windows.Forms.Button btnRemoveRow;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TextBox txtMakeToView;
      private System.Windows.Forms.Button btnDisplayMakes;
      private System.Windows.Forms.Button btnChangeBeemersToYugos;
      private System.Windows.Forms.DataGridView dataGridColtsView;
      private System.Windows.Forms.Label label2;
    }
}

