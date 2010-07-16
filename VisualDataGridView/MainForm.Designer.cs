namespace VisualDataGridView
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
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.inventoryBindingSource = new System.Windows.Forms.BindingSource( this.components );
         this.inventoryDataSet = new VisualDataGridView.InventoryDataSet();
         this.inventoryTableAdapter = new VisualDataGridView.InventoryDataSetTableAdapters.InventoryTableAdapter();
         this.updateGridBtn = new System.Windows.Forms.Button();
         this.addRowBtn = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.idTxt = new System.Windows.Forms.TextBox();
         this.nameTxt = new System.Windows.Forms.TextBox();
         this.makeTxt = new System.Windows.Forms.TextBox();
         this.colorTxt = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.AutoGenerateColumns = false;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4} );
         this.dataGridView1.DataSource = this.inventoryBindingSource;
         this.dataGridView1.Location = new System.Drawing.Point( 13, 13 );
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size( 456, 170 );
         this.dataGridView1.TabIndex = 0;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "CarID";
         this.dataGridViewTextBoxColumn1.HeaderText = "CarID";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Make";
         this.dataGridViewTextBoxColumn2.HeaderText = "Make";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "Color";
         this.dataGridViewTextBoxColumn3.HeaderText = "Color";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "PetName";
         this.dataGridViewTextBoxColumn4.HeaderText = "PetName";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // inventoryBindingSource
         // 
         this.inventoryBindingSource.DataMember = "Inventory";
         this.inventoryBindingSource.DataSource = this.inventoryDataSet;
         // 
         // inventoryDataSet
         // 
         this.inventoryDataSet.DataSetName = "InventoryDataSet";
         this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // inventoryTableAdapter
         // 
         this.inventoryTableAdapter.ClearBeforeFill = true;
         // 
         // updateGridBtn
         // 
         this.updateGridBtn.Location = new System.Drawing.Point( 358, 209 );
         this.updateGridBtn.Name = "updateGridBtn";
         this.updateGridBtn.Size = new System.Drawing.Size( 75, 23 );
         this.updateGridBtn.TabIndex = 1;
         this.updateGridBtn.Text = "Update";
         this.updateGridBtn.UseVisualStyleBackColor = true;
         this.updateGridBtn.Click += new System.EventHandler( this.OnGridUpdate );
         // 
         // addRowBtn
         // 
         this.addRowBtn.Location = new System.Drawing.Point( 205, 112 );
         this.addRowBtn.Name = "addRowBtn";
         this.addRowBtn.Size = new System.Drawing.Size( 75, 23 );
         this.addRowBtn.TabIndex = 2;
         this.addRowBtn.Text = "Add Row";
         this.addRowBtn.UseVisualStyleBackColor = true;
         this.addRowBtn.Click += new System.EventHandler( this.OnAddRow );
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add( this.colorTxt );
         this.groupBox1.Controls.Add( this.makeTxt );
         this.groupBox1.Controls.Add( this.nameTxt );
         this.groupBox1.Controls.Add( this.idTxt );
         this.groupBox1.Controls.Add( this.label4 );
         this.groupBox1.Controls.Add( this.label3 );
         this.groupBox1.Controls.Add( this.label2 );
         this.groupBox1.Controls.Add( this.label1 );
         this.groupBox1.Controls.Add( this.addRowBtn );
         this.groupBox1.Location = new System.Drawing.Point( 14, 194 );
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size( 298, 146 );
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Add Row";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point( 10, 117 );
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size( 31, 13 );
         this.label4.TabIndex = 6;
         this.label4.Text = "Color";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point( 10, 88 );
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size( 34, 13 );
         this.label3.TabIndex = 5;
         this.label3.Text = "Make";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point( 10, 59 );
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size( 54, 13 );
         this.label2.TabIndex = 4;
         this.label2.Text = "Pet Name";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 10, 30 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 37, 13 );
         this.label1.TabIndex = 3;
         this.label1.Text = "Car ID";
         // 
         // idTxt
         // 
         this.idTxt.Location = new System.Drawing.Point( 78, 26 );
         this.idTxt.Name = "idTxt";
         this.idTxt.Size = new System.Drawing.Size( 100, 20 );
         this.idTxt.TabIndex = 7;
         // 
         // nameTxt
         // 
         this.nameTxt.Location = new System.Drawing.Point( 78, 55 );
         this.nameTxt.Name = "nameTxt";
         this.nameTxt.Size = new System.Drawing.Size( 100, 20 );
         this.nameTxt.TabIndex = 8;
         // 
         // makeTxt
         // 
         this.makeTxt.Location = new System.Drawing.Point( 78, 84 );
         this.makeTxt.Name = "makeTxt";
         this.makeTxt.Size = new System.Drawing.Size( 100, 20 );
         this.makeTxt.TabIndex = 9;
         // 
         // colorTxt
         // 
         this.colorTxt.Location = new System.Drawing.Point( 78, 113 );
         this.colorTxt.Name = "colorTxt";
         this.colorTxt.Size = new System.Drawing.Size( 100, 20 );
         this.colorTxt.TabIndex = 10;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 488, 356 );
         this.Controls.Add( this.groupBox1 );
         this.Controls.Add( this.updateGridBtn );
         this.Controls.Add( this.dataGridView1 );
         this.Name = "MainForm";
         this.Text = "Main Form";
         this.Load += new System.EventHandler( this.MainForm_Load );
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
         this.groupBox1.ResumeLayout( false );
         this.groupBox1.PerformLayout();
         this.ResumeLayout( false );

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
      private InventoryDataSet inventoryDataSet;
      private System.Windows.Forms.BindingSource inventoryBindingSource;
      private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.Button updateGridBtn;
      private System.Windows.Forms.Button addRowBtn;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox colorTxt;
      private System.Windows.Forms.TextBox makeTxt;
      private System.Windows.Forms.TextBox nameTxt;
      private System.Windows.Forms.TextBox idTxt;
   }
}