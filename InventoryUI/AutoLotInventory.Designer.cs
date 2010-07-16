namespace InventoryUI
{
   partial class AutoLotInventory
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
         this.inventoryDG = new System.Windows.Forms.DataGridView();
         this.inventoryUpdateBtn = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.inventoryDG)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 14, 15 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 94, 13 );
         this.label1.TabIndex = 0;
         this.label1.Text = "Auto Lot Inventory";
         // 
         // inventoryDG
         // 
         this.inventoryDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.inventoryDG.Location = new System.Drawing.Point( 16, 39 );
         this.inventoryDG.Name = "inventoryDG";
         this.inventoryDG.Size = new System.Drawing.Size( 501, 263 );
         this.inventoryDG.TabIndex = 1;
         // 
         // inventoryUpdateBtn
         // 
         this.inventoryUpdateBtn.Location = new System.Drawing.Point( 12, 308 );
         this.inventoryUpdateBtn.Name = "inventoryUpdateBtn";
         this.inventoryUpdateBtn.Size = new System.Drawing.Size( 105, 23 );
         this.inventoryUpdateBtn.TabIndex = 2;
         this.inventoryUpdateBtn.Text = "Update Inventory";
         this.inventoryUpdateBtn.UseVisualStyleBackColor = true;
         this.inventoryUpdateBtn.Click += new System.EventHandler( this.OnInventoryUpdate );
         // 
         // AutoLotInventory
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 529, 343 );
         this.Controls.Add( this.inventoryUpdateBtn );
         this.Controls.Add( this.inventoryDG );
         this.Controls.Add( this.label1 );
         this.Name = "AutoLotInventory";
         this.Text = "Auto Lot Inventory";
         ((System.ComponentModel.ISupportInitialize)(this.inventoryDG)).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView inventoryDG;
      private System.Windows.Forms.Button inventoryUpdateBtn;
   }
}

