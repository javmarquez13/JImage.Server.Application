namespace JImage.Server.Views.Views.Base
{
    partial class BaseView
    {
        public BaseView()
        {

        }

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
            pBoxLoadIndicator = new System.Windows.Forms.PictureBox();
            btnAdminMenu = new MaterialSkinGT.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pBoxLoadIndicator).BeginInit();
            SuspendLayout();
            // 
            // pBoxLoadIndicator
            // 
            pBoxLoadIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            pBoxLoadIndicator.Location = new System.Drawing.Point(3, 88);
            pBoxLoadIndicator.Name = "pBoxLoadIndicator";
            pBoxLoadIndicator.Size = new System.Drawing.Size(894, 659);
            pBoxLoadIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pBoxLoadIndicator.TabIndex = 0;
            pBoxLoadIndicator.TabStop = false;
            // 
            // btnAdminMenu
            // 
            btnAdminMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAdminMenu.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdminMenu.Depth = 0;
            btnAdminMenu.HighEmphasis = true;
            btnAdminMenu.Icon = null;
            btnAdminMenu.Location = new System.Drawing.Point(815, 104);
            btnAdminMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnAdminMenu.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnAdminMenu.Name = "btnAdminMenu";
            btnAdminMenu.NoAccentTextColor = System.Drawing.Color.Empty;
            btnAdminMenu.Size = new System.Drawing.Size(68, 36);
            btnAdminMenu.TabIndex = 1;
            btnAdminMenu.Text = "ADMIN";
            btnAdminMenu.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdminMenu.UseAccentColor = false;
            btnAdminMenu.UseVisualStyleBackColor = true;
            btnAdminMenu.Click += btnAdminMenu_Click;
            // 
            // BaseView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 750);
            Controls.Add(btnAdminMenu);
            Controls.Add(pBoxLoadIndicator);
            FormStyle = FormStyles.ActionBar_64;
            Name = "BaseView";
            Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BaseView";
            ((System.ComponentModel.ISupportInitialize)pBoxLoadIndicator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLoadIndicator;
        public MaterialSkinGT.Controls.MaterialButton btnAdminMenu;
    }
}