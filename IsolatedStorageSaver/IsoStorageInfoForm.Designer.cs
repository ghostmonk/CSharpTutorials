using System.Security.Permissions;
[assembly: 
   IsolatedStorageFilePermission( SecurityAction.RequestMinimum, 
   UsageAllowed = IsolatedStorageContainment.AssemblyIsolationByUser)]
namespace IsolatedStorageSaver
{
   
   partial class IsoStorageInfoForm
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
         this.StorageSaveField = new System.Windows.Forms.TextBox();
         this.StorageSaveBtn = new System.Windows.Forms.Button();
         this.StorageReadField = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.StorageDeleteBtn = new System.Windows.Forms.Button();
         this.label = new System.Windows.Forms.Label();
         this.StorageReadBtn = new System.Windows.Forms.Button();
         this.StorageFileNameField = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 14, 65 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 149, 13 );
         this.label1.TabIndex = 0;
         this.label1.Text = "Enter Data to Save in Storage";
         // 
         // StorageSaveField
         // 
         this.StorageSaveField.Location = new System.Drawing.Point( 14, 82 );
         this.StorageSaveField.Multiline = true;
         this.StorageSaveField.Name = "StorageSaveField";
         this.StorageSaveField.Size = new System.Drawing.Size( 342, 91 );
         this.StorageSaveField.TabIndex = 1;
         // 
         // StorageSaveBtn
         // 
         this.StorageSaveBtn.Location = new System.Drawing.Point( 14, 189 );
         this.StorageSaveBtn.Name = "StorageSaveBtn";
         this.StorageSaveBtn.Size = new System.Drawing.Size( 122, 23 );
         this.StorageSaveBtn.TabIndex = 3;
         this.StorageSaveBtn.Text = "Save Storage Data";
         this.StorageSaveBtn.UseVisualStyleBackColor = true;
         this.StorageSaveBtn.Click += new System.EventHandler( this.SaveDataBtn_Click );
         // 
         // StorageReadField
         // 
         this.StorageReadField.Location = new System.Drawing.Point( 14, 254 );
         this.StorageReadField.Multiline = true;
         this.StorageReadField.Name = "StorageReadField";
         this.StorageReadField.Size = new System.Drawing.Size( 339, 125 );
         this.StorageReadField.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point( 14, 229 );
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size( 125, 13 );
         this.label3.TabIndex = 6;
         this.label3.Text = "Data Read From Storage";
         // 
         // StorageDeleteBtn
         // 
         this.StorageDeleteBtn.Location = new System.Drawing.Point( 149, 397 );
         this.StorageDeleteBtn.Name = "StorageDeleteBtn";
         this.StorageDeleteBtn.Size = new System.Drawing.Size( 131, 23 );
         this.StorageDeleteBtn.TabIndex = 7;
         this.StorageDeleteBtn.Text = "Delete Storage Data";
         this.StorageDeleteBtn.UseVisualStyleBackColor = true;
         this.StorageDeleteBtn.Click += new System.EventHandler( this.StorageDeleter_Click );
         // 
         // label
         // 
         this.label.AutoSize = true;
         this.label.Location = new System.Drawing.Point( 14, 9 );
         this.label.Name = "label";
         this.label.Size = new System.Drawing.Size( 54, 13 );
         this.label.TabIndex = 8;
         this.label.Text = "File Name";
         // 
         // StorageReadBtn
         // 
         this.StorageReadBtn.Location = new System.Drawing.Point( 14, 397 );
         this.StorageReadBtn.Name = "StorageReadBtn";
         this.StorageReadBtn.Size = new System.Drawing.Size( 119, 23 );
         this.StorageReadBtn.TabIndex = 9;
         this.StorageReadBtn.Text = "Read Storage Data";
         this.StorageReadBtn.UseVisualStyleBackColor = true;
         this.StorageReadBtn.Click += new System.EventHandler( this.ReadStorageBtn_Click );
         // 
         // StorageFileNameField
         // 
         this.StorageFileNameField.Location = new System.Drawing.Point( 14, 34 );
         this.StorageFileNameField.Name = "StorageFileNameField";
         this.StorageFileNameField.Size = new System.Drawing.Size( 148, 20 );
         this.StorageFileNameField.TabIndex = 10;
         // 
         // IsoStorageInfoForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 369, 442 );
         this.Controls.Add( this.StorageFileNameField );
         this.Controls.Add( this.StorageReadBtn );
         this.Controls.Add( this.label );
         this.Controls.Add( this.StorageDeleteBtn );
         this.Controls.Add( this.label3 );
         this.Controls.Add( this.StorageReadField );
         this.Controls.Add( this.StorageSaveBtn );
         this.Controls.Add( this.StorageSaveField );
         this.Controls.Add( this.label1 );
         this.Name = "IsoStorageInfoForm";
         this.Text = "The Amazing Isolated Storage Saver";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox StorageSaveField;
      private System.Windows.Forms.Button StorageSaveBtn;
      private System.Windows.Forms.TextBox StorageReadField;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button StorageDeleteBtn;
      private System.Windows.Forms.Label label;
      private System.Windows.Forms.Button StorageReadBtn;
      private System.Windows.Forms.TextBox StorageFileNameField;
   }
}

