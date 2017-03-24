namespace VisualDataGridViewApp
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
      this.components = new System.ComponentModel.Container();
      this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.btnUpdateInventory = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnAddRow = new System.Windows.Forms.Button();
      this.txtMake = new System.Windows.Forms.TextBox();
      this.txtPetName = new System.Windows.Forms.TextBox();
      this.txtColor = new System.Windows.Forms.TextBox();
      this.txtCarID = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.inventoryDataSet = new VisualDataGridViewApp.InventoryDataSet();
      this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.inventoryTableAdapter = new VisualDataGridViewApp.InventoryDataSetTableAdapters.InventoryTableAdapter();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewInventory
      // 
      this.dataGridViewInventory.AutoGenerateColumns = false;
      this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
      this.dataGridViewInventory.DataSource = this.inventoryBindingSource;
      this.dataGridViewInventory.Location = new System.Drawing.Point(12, 47);
      this.dataGridViewInventory.Name = "dataGridViewInventory";
      this.dataGridViewInventory.Size = new System.Drawing.Size(463, 178);
      this.dataGridViewInventory.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(209, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "The AutoLot Inventory Table";
      // 
      // btnUpdateInventory
      // 
      this.btnUpdateInventory.Location = new System.Drawing.Point(383, 241);
      this.btnUpdateInventory.Name = "btnUpdateInventory";
      this.btnUpdateInventory.Size = new System.Drawing.Size(92, 23);
      this.btnUpdateInventory.TabIndex = 2;
      this.btnUpdateInventory.Text = "Update";
      this.btnUpdateInventory.UseVisualStyleBackColor = true;
      this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnAddRow);
      this.groupBox1.Controls.Add(this.txtMake);
      this.groupBox1.Controls.Add(this.txtPetName);
      this.groupBox1.Controls.Add(this.txtColor);
      this.groupBox1.Controls.Add(this.txtCarID);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(12, 241);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(321, 161);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Manually Adding New Row";
      // 
      // btnAddRow
      // 
      this.btnAddRow.Location = new System.Drawing.Point(222, 122);
      this.btnAddRow.Name = "btnAddRow";
      this.btnAddRow.Size = new System.Drawing.Size(88, 23);
      this.btnAddRow.TabIndex = 4;
      this.btnAddRow.Text = "Add Row";
      this.btnAddRow.UseVisualStyleBackColor = true;
      this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
      // 
      // txtMake
      // 
      this.txtMake.Location = new System.Drawing.Point(82, 58);
      this.txtMake.Name = "txtMake";
      this.txtMake.Size = new System.Drawing.Size(118, 20);
      this.txtMake.TabIndex = 1;
      // 
      // txtPetName
      // 
      this.txtPetName.Location = new System.Drawing.Point(82, 124);
      this.txtPetName.Name = "txtPetName";
      this.txtPetName.Size = new System.Drawing.Size(118, 20);
      this.txtPetName.TabIndex = 3;
      // 
      // txtColor
      // 
      this.txtColor.Location = new System.Drawing.Point(82, 91);
      this.txtColor.Name = "txtColor";
      this.txtColor.Size = new System.Drawing.Size(118, 20);
      this.txtColor.TabIndex = 2;
      // 
      // txtCarID
      // 
      this.txtCarID.Location = new System.Drawing.Point(82, 25);
      this.txtCarID.Name = "txtCarID";
      this.txtCarID.Size = new System.Drawing.Size(118, 20);
      this.txtCarID.TabIndex = 0;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 94);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(31, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Color";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "PetName";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Make";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 28);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Car ID";
      // 
      // inventoryDataSet
      // 
      this.inventoryDataSet.DataSetName = "InventoryDataSet";
      this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // inventoryBindingSource
      // 
      this.inventoryBindingSource.DataMember = "Inventory";
      this.inventoryBindingSource.DataSource = this.inventoryDataSet;
      // 
      // inventoryTableAdapter
      // 
      this.inventoryTableAdapter.ClearBeforeFill = true;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "CarID";
      this.dataGridViewTextBoxColumn5.HeaderText = "CarID";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "Make";
      this.dataGridViewTextBoxColumn6.HeaderText = "Make";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "Color";
      this.dataGridViewTextBoxColumn7.HeaderText = "Color";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "PetName";
      this.dataGridViewTextBoxColumn8.HeaderText = "PetName";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(487, 414);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnUpdateInventory);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridViewInventory);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Invertory Viewer Redux";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewInventory;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnUpdateInventory;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtMake;
    private System.Windows.Forms.TextBox txtPetName;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.TextBox txtCarID;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAddRow;
    private InventoryDataSet inventoryDataSet;
    private System.Windows.Forms.BindingSource inventoryBindingSource;
    private VisualDataGridViewApp.InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
  }
}

