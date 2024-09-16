namespace JImage.Server.Views.Views.ApplyImageAutomatic
{
    partial class ApplyImageAutomaticView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnApplyImage = new MaterialSkinGT.Controls.MaterialButton();
            lblBaseBoard = new MaterialSkinGT.Controls.MaterialLabel();
            lblImageToInstall = new MaterialSkinGT.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // btnApplyImage
            // 
            btnApplyImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnApplyImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnApplyImage.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            btnApplyImage.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplyImage.Depth = 0;
            btnApplyImage.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            btnApplyImage.HighEmphasis = true;
            btnApplyImage.Icon = null;
            btnApplyImage.Location = new System.Drawing.Point(771, 638);
            btnApplyImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnApplyImage.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnApplyImage.Name = "btnApplyImage";
            btnApplyImage.NoAccentTextColor = System.Drawing.Color.Empty;
            btnApplyImage.Size = new System.Drawing.Size(116, 36);
            btnApplyImage.TabIndex = 1;
            btnApplyImage.Text = "Apply Image";
            btnApplyImage.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnApplyImage.UseAccentColor = false;
            btnApplyImage.UseVisualStyleBackColor = false;
            // 
            // lblBaseBoard
            // 
            lblBaseBoard.AutoSize = true;
            lblBaseBoard.Depth = 0;
            lblBaseBoard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblBaseBoard.Location = new System.Drawing.Point(6, 97);
            lblBaseBoard.MouseState = MaterialSkinGT.MouseState.HOVER;
            lblBaseBoard.Name = "lblBaseBoard";
            lblBaseBoard.Size = new System.Drawing.Size(85, 19);
            lblBaseBoard.TabIndex = 2;
            lblBaseBoard.Text = "Base board:";
            // 
            // lblImageToInstall
            // 
            lblImageToInstall.AutoSize = true;
            lblImageToInstall.Depth = 0;
            lblImageToInstall.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblImageToInstall.Location = new System.Drawing.Point(6, 126);
            lblImageToInstall.MouseState = MaterialSkinGT.MouseState.HOVER;
            lblImageToInstall.Name = "lblImageToInstall";
            lblImageToInstall.Size = new System.Drawing.Size(114, 19);
            lblImageToInstall.TabIndex = 3;
            lblImageToInstall.Text = "Image to install:";
            // 
            // ApplyImageView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(894, 683);
            Controls.Add(lblImageToInstall);
            Controls.Add(lblBaseBoard);
            Controls.Add(btnApplyImage);
            FormStyle = FormStyles.ActionBar_64;
            Name = "ApplyImageView";
            Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialButton btnApplyImage;
        private MaterialSkinGT.Controls.MaterialLabel lblBaseBoard;
        private MaterialSkinGT.Controls.MaterialLabel lblImageToInstall;
    }
}
