namespace JImage.Server.Views.Views.FilesExplorer
{
    partial class FilesExplorerView
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
            materialListView1 = new MaterialSkinGT.Controls.MaterialListView();
            materialLabel1 = new MaterialSkinGT.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.HideSelection = false;
            materialListView1.Location = new System.Drawing.Point(51, 124);
            materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            materialListView1.MouseState = MaterialSkinGT.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new System.Drawing.Size(900, 387);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(51, 102);
            materialLabel1.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(76, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Directories";
            // 
            // FilesExplorerView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 624);
            Controls.Add(materialLabel1);
            Controls.Add(materialListView1);
            Name = "FilesExplorerView";
            Text = "FilesExplorerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialListView materialListView1;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel1;
    }
}