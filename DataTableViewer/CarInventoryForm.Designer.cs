namespace DataTableViewer
{
   partial class CarInventoryForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.carInventoryDG = new System.Windows.Forms.DataGridView();
         this.removeRowBtn = new System.Windows.Forms.Button();
         this.rowNumberTxt = new System.Windows.Forms.TextBox();
         this.rowDeleteGrp = new System.Windows.Forms.GroupBox();
         this.makeViewGB = new System.Windows.Forms.GroupBox();
         this.makeTxt = new System.Windows.Forms.TextBox();
         this.displayMakesBtn = new System.Windows.Forms.Button();
         this.makeChangerBtn = new System.Windows.Forms.Button();
         this.bmwDG = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.carInventoryDG)).BeginInit();
         this.rowDeleteGrp.SuspendLayout();
         this.makeViewGB.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bmwDG)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 13, 13 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 70, 13 );
         this.label1.TabIndex = 0;
         this.label1.Text = "Inventory List";
         // 
         // carInventoryDG
         // 
         this.carInventoryDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.carInventoryDG.Location = new System.Drawing.Point( 16, 29 );
         this.carInventoryDG.Name = "carInventoryDG";
         this.carInventoryDG.Size = new System.Drawing.Size( 369, 190 );
         this.carInventoryDG.TabIndex = 1;
         this.carInventoryDG.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler( this.OnRowPostPaint );
         // 
         // removeRowBtn
         // 
         this.removeRowBtn.Location = new System.Drawing.Point( 8, 51 );
         this.removeRowBtn.Name = "removeRowBtn";
         this.removeRowBtn.Size = new System.Drawing.Size( 75, 23 );
         this.removeRowBtn.TabIndex = 2;
         this.removeRowBtn.Text = "Remove";
         this.removeRowBtn.UseVisualStyleBackColor = true;
         this.removeRowBtn.Click += new System.EventHandler( this.OnRemoveDataRow );
         // 
         // rowNumberTxt
         // 
         this.rowNumberTxt.Location = new System.Drawing.Point( 8, 25 );
         this.rowNumberTxt.Name = "rowNumberTxt";
         this.rowNumberTxt.Size = new System.Drawing.Size( 155, 20 );
         this.rowNumberTxt.TabIndex = 3;
         // 
         // rowDeleteGrp
         // 
         this.rowDeleteGrp.Controls.Add( this.removeRowBtn );
         this.rowDeleteGrp.Controls.Add( this.rowNumberTxt );
         this.rowDeleteGrp.Location = new System.Drawing.Point( 16, 230 );
         this.rowDeleteGrp.Name = "rowDeleteGrp";
         this.rowDeleteGrp.Size = new System.Drawing.Size( 169, 82 );
         this.rowDeleteGrp.TabIndex = 4;
         this.rowDeleteGrp.TabStop = false;
         this.rowDeleteGrp.Text = "Enter row number to delete";
         // 
         // makeViewGB
         // 
         this.makeViewGB.Controls.Add( this.makeTxt );
         this.makeViewGB.Controls.Add( this.displayMakesBtn );
         this.makeViewGB.Location = new System.Drawing.Point( 191, 230 );
         this.makeViewGB.Name = "makeViewGB";
         this.makeViewGB.Size = new System.Drawing.Size( 173, 82 );
         this.makeViewGB.TabIndex = 5;
         this.makeViewGB.TabStop = false;
         this.makeViewGB.Text = "Enter Make To View";
         // 
         // makeTxt
         // 
         this.makeTxt.Location = new System.Drawing.Point( 6, 25 );
         this.makeTxt.Name = "makeTxt";
         this.makeTxt.Size = new System.Drawing.Size( 161, 20 );
         this.makeTxt.TabIndex = 1;
         // 
         // displayMakesBtn
         // 
         this.displayMakesBtn.Location = new System.Drawing.Point( 6, 51 );
         this.displayMakesBtn.Name = "displayMakesBtn";
         this.displayMakesBtn.Size = new System.Drawing.Size( 99, 23 );
         this.displayMakesBtn.TabIndex = 0;
         this.displayMakesBtn.Text = "Display Makes";
         this.displayMakesBtn.UseVisualStyleBackColor = true;
         this.displayMakesBtn.Click += new System.EventHandler( this.OnMakeView );
         // 
         // makeChangerBtn
         // 
         this.makeChangerBtn.Location = new System.Drawing.Point( 16, 329 );
         this.makeChangerBtn.Name = "makeChangerBtn";
         this.makeChangerBtn.Size = new System.Drawing.Size( 141, 23 );
         this.makeChangerBtn.TabIndex = 6;
         this.makeChangerBtn.Text = "Change Make";
         this.makeChangerBtn.UseVisualStyleBackColor = true;
         this.makeChangerBtn.Click += new System.EventHandler( this.OnChangeMake );
         // 
         // bmwDG
         // 
         this.bmwDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.bmwDG.Location = new System.Drawing.Point( 16, 373 );
         this.bmwDG.Name = "bmwDG";
         this.bmwDG.Size = new System.Drawing.Size( 369, 89 );
         this.bmwDG.TabIndex = 7;
         this.bmwDG.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler( this.OnRowPostPaint );
         // 
         // CarInventoryForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 406, 481 );
         this.Controls.Add( this.bmwDG );
         this.Controls.Add( this.makeChangerBtn );
         this.Controls.Add( this.makeViewGB );
         this.Controls.Add( this.carInventoryDG );
         this.Controls.Add( this.label1 );
         this.Controls.Add( this.rowDeleteGrp );
         this.Name = "CarInventoryForm";
         this.Text = "Car Inventory";
         ((System.ComponentModel.ISupportInitialize)(this.carInventoryDG)).EndInit();
         this.rowDeleteGrp.ResumeLayout( false );
         this.rowDeleteGrp.PerformLayout();
         this.makeViewGB.ResumeLayout( false );
         this.makeViewGB.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bmwDG)).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView carInventoryDG;
      private System.Windows.Forms.Button removeRowBtn;
      private System.Windows.Forms.TextBox rowNumberTxt;
      private System.Windows.Forms.GroupBox rowDeleteGrp;
      private System.Windows.Forms.GroupBox makeViewGB;
      private System.Windows.Forms.TextBox makeTxt;
      private System.Windows.Forms.Button displayMakesBtn;
      private System.Windows.Forms.Button makeChangerBtn;
      private System.Windows.Forms.DataGridView bmwDG;
   }
}

