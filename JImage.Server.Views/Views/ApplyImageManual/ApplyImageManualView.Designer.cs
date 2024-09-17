namespace JImage.Server.Views.Views.ApplyImageManual
{
    partial class ApplyImageManualView
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
            materialLabel1 = new MaterialSkinGT.Controls.MaterialLabel();
            btnApplyImage = new MaterialSkinGT.Controls.MaterialButton();
            treeViewDirectories = new System.Windows.Forms.TreeView();
            lViewFiles = new MaterialSkinGT.Controls.MaterialListView();
            materialLabel2 = new MaterialSkinGT.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(61, 153);
            materialLabel1.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(80, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Directories:";
            // 
            // btnApplyImage
            // 
            btnApplyImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnApplyImage.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplyImage.Depth = 0;
            btnApplyImage.HighEmphasis = true;
            btnApplyImage.Icon = null;
            btnApplyImage.Location = new System.Drawing.Point(836, 546);
            btnApplyImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnApplyImage.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnApplyImage.Name = "btnApplyImage";
            btnApplyImage.NoAccentTextColor = System.Drawing.Color.Empty;
            btnApplyImage.Size = new System.Drawing.Size(67, 36);
            btnApplyImage.TabIndex = 2;
            btnApplyImage.Text = "APPLY";
            btnApplyImage.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnApplyImage.UseAccentColor = false;
            btnApplyImage.UseVisualStyleBackColor = true;
            // 
            // treeViewDirectories
            // 
            treeViewDirectories.Location = new System.Drawing.Point(61, 175);
            treeViewDirectories.Name = "treeViewDirectories";
            treeViewDirectories.Size = new System.Drawing.Size(788, 63);
            treeViewDirectories.TabIndex = 4;
            treeViewDirectories.AfterSelect += treeViewDirectories_AfterSelect;
            // 
            // lViewFiles
            // 
            lViewFiles.AutoSizeTable = false;
            lViewFiles.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            lViewFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lViewFiles.Depth = 0;
            lViewFiles.FullRowSelect = true;
            lViewFiles.HideSelection = false;
            lViewFiles.Location = new System.Drawing.Point(61, 307);
            lViewFiles.MinimumSize = new System.Drawing.Size(200, 100);
            lViewFiles.MouseLocation = new System.Drawing.Point(-1, -1);
            lViewFiles.MouseState = MaterialSkinGT.MouseState.OUT;
            lViewFiles.Name = "lViewFiles";
            lViewFiles.OwnerDraw = true;
            lViewFiles.Size = new System.Drawing.Size(788, 203);
            lViewFiles.TabIndex = 5;
            lViewFiles.UseCompatibleStateImageBehavior = false;
            lViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(61, 285);
            materialLabel2.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(38, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "Files:";
            // 
            // ApplyImageManualView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(910, 591);
            Controls.Add(materialLabel2);
            Controls.Add(lViewFiles);
            Controls.Add(treeViewDirectories);
            Controls.Add(btnApplyImage);
            Controls.Add(materialLabel1);
            Name = "ApplyImageManualView";
            Text = "ApplyImageManualView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkinGT.Controls.MaterialLabel materialLabel1;
        private MaterialSkinGT.Controls.MaterialButton btnApplyImage;
        private System.Windows.Forms.TreeView treeViewDirectories;
        private MaterialSkinGT.Controls.MaterialListView lViewFiles;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel2;
    }
}