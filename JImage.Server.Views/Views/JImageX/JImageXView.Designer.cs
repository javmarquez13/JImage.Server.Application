namespace JImage.Server.Views.Views.JImageX
{
    partial class JImageXView
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
            pBarInstallation = new MaterialSkinGT.Controls.MaterialProgressBar();
            lblProgressInstallationImage = new MaterialSkinGT.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // pBarInstallation
            // 
            pBarInstallation.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pBarInstallation.Depth = 0;
            pBarInstallation.Location = new System.Drawing.Point(43, 157);
            pBarInstallation.MouseState = MaterialSkinGT.MouseState.HOVER;
            pBarInstallation.Name = "pBarInstallation";
            pBarInstallation.Size = new System.Drawing.Size(1045, 5);
            pBarInstallation.TabIndex = 0;
            // 
            // lblProgressInstallationImage
            // 
            lblProgressInstallationImage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblProgressInstallationImage.AutoSize = true;
            lblProgressInstallationImage.Depth = 0;
            lblProgressInstallationImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblProgressInstallationImage.Location = new System.Drawing.Point(986, 165);
            lblProgressInstallationImage.MouseState = MaterialSkinGT.MouseState.HOVER;
            lblProgressInstallationImage.Name = "lblProgressInstallationImage";
            lblProgressInstallationImage.Size = new System.Drawing.Size(78, 19);
            lblProgressInstallationImage.TabIndex = 1;
            lblProgressInstallationImage.Text = "Installing...";
            // 
            // JImageXView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1133, 267);
            Controls.Add(lblProgressInstallationImage);
            Controls.Add(pBarInstallation);
            Name = "JImageXView";
            Text = "JImageXView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialProgressBar pBarInstallation;
        private MaterialSkinGT.Controls.MaterialLabel lblProgressInstallationImage;
    }
}