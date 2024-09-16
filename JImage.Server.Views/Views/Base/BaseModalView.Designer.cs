namespace JImage.Server.Views.Views.Base
{
    partial class BaseModalView
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
            pBoxLoadIndicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxLoadIndicator).BeginInit();
            SuspendLayout();
            // 
            // pBoxLoadIndicator
            // 
            pBoxLoadIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            pBoxLoadIndicator.Location = new System.Drawing.Point(3, 64);
            pBoxLoadIndicator.Name = "pBoxLoadIndicator";
            pBoxLoadIndicator.Size = new System.Drawing.Size(794, 383);
            pBoxLoadIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pBoxLoadIndicator.TabIndex = 1;
            pBoxLoadIndicator.TabStop = false;
            // 
            // BaseModalView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pBoxLoadIndicator);
            Name = "BaseModalView";
            Text = "BaseModalView";
            ((System.ComponentModel.ISupportInitialize)pBoxLoadIndicator).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLoadIndicator;
    }
}