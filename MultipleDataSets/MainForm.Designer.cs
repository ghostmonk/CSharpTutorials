namespace MultipleDataSets
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
         this.inventoryDg = new System.Windows.Forms.DataGridView();
         this.customersDg = new System.Windows.Forms.DataGridView();
         this.ordersDg = new System.Windows.Forms.DataGridView();
         this.updateDbBtn = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label4 = new System.Windows.Forms.Label();
         this.customerIdTxt = new System.Windows.Forms.TextBox();
         this.getOrderBtn = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.inventoryDg)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.customersDg)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.ordersDg)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // inventoryDg
         // 
         this.inventoryDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.inventoryDg.Location = new System.Drawing.Point( 13, 42 );
         this.inventoryDg.Name = "inventoryDg";
         this.inventoryDg.Size = new System.Drawing.Size( 546, 150 );
         this.inventoryDg.TabIndex = 0;
         // 
         // customersDg
         // 
         this.customersDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.customersDg.Location = new System.Drawing.Point( 13, 220 );
         this.customersDg.Name = "customersDg";
         this.customersDg.Size = new System.Drawing.Size( 546, 154 );
         this.customersDg.TabIndex = 1;
         // 
         // ordersDg
         // 
         this.ordersDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.ordersDg.Location = new System.Drawing.Point( 12, 398 );
         this.ordersDg.Name = "ordersDg";
         this.ordersDg.Size = new System.Drawing.Size( 547, 150 );
         this.ordersDg.TabIndex = 2;
         // 
         // updateDbBtn
         // 
         this.updateDbBtn.Location = new System.Drawing.Point( 484, 572 );
         this.updateDbBtn.Name = "updateDbBtn";
         this.updateDbBtn.Size = new System.Drawing.Size( 75, 23 );
         this.updateDbBtn.TabIndex = 3;
         this.updateDbBtn.Text = "Update";
         this.updateDbBtn.UseVisualStyleBackColor = true;
         this.updateDbBtn.Click += new System.EventHandler( this.OnDbUpdate );
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 13, 379 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 38, 13 );
         this.label1.TabIndex = 4;
         this.label1.Text = "Orders";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point( 12, 201 );
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size( 56, 13 );
         this.label2.TabIndex = 5;
         this.label2.Text = "Customers";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point( 16, 17 );
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size( 51, 13 );
         this.label3.TabIndex = 6;
         this.label3.Text = "Inventory";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add( this.getOrderBtn );
         this.groupBox1.Controls.Add( this.customerIdTxt );
         this.groupBox1.Controls.Add( this.label4 );
         this.groupBox1.Location = new System.Drawing.Point( 12, 572 );
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size( 166, 96 );
         this.groupBox1.TabIndex = 7;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Lookup Customer Order";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point( 7, 34 );
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size( 68, 13 );
         this.label4.TabIndex = 0;
         this.label4.Text = "Customer ID:";
         // 
         // customerIdTxt
         // 
         this.customerIdTxt.Location = new System.Drawing.Point( 81, 31 );
         this.customerIdTxt.Name = "customerIdTxt";
         this.customerIdTxt.Size = new System.Drawing.Size( 72, 20 );
         this.customerIdTxt.TabIndex = 1;
         // 
         // getOrderBtn
         // 
         this.getOrderBtn.Location = new System.Drawing.Point( 57, 58 );
         this.getOrderBtn.Name = "getOrderBtn";
         this.getOrderBtn.Size = new System.Drawing.Size( 99, 23 );
         this.getOrderBtn.TabIndex = 2;
         this.getOrderBtn.Text = "Get Order Details";
         this.getOrderBtn.UseVisualStyleBackColor = true;
         this.getOrderBtn.Click += new System.EventHandler( this.OnGetOrder );
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 582, 680 );
         this.Controls.Add( this.groupBox1 );
         this.Controls.Add( this.label3 );
         this.Controls.Add( this.label2 );
         this.Controls.Add( this.label1 );
         this.Controls.Add( this.updateDbBtn );
         this.Controls.Add( this.ordersDg );
         this.Controls.Add( this.customersDg );
         this.Controls.Add( this.inventoryDg );
         this.Name = "MainForm";
         this.Text = "AutoLot DB Manipulator";
         ((System.ComponentModel.ISupportInitialize)(this.inventoryDg)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.customersDg)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.ordersDg)).EndInit();
         this.groupBox1.ResumeLayout( false );
         this.groupBox1.PerformLayout();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView inventoryDg;
      private System.Windows.Forms.DataGridView customersDg;
      private System.Windows.Forms.DataGridView ordersDg;
      private System.Windows.Forms.Button updateDbBtn;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button getOrderBtn;
      private System.Windows.Forms.TextBox customerIdTxt;
      private System.Windows.Forms.Label label4;
   }
}

