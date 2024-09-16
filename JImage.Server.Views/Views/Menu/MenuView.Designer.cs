namespace JImage.Server.Views.Views.Menu
{
    partial class MenuView
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
            btnOpenCaptureImageModal = new MaterialSkinGT.Controls.MaterialButton();
            btnOpenApplyImageManualModal = new MaterialSkinGT.Controls.MaterialButton();
            btnOpenApplyImageAutomaticModal = new MaterialSkinGT.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnOpenCaptureImageModal
            // 
            btnOpenCaptureImageModal.AutoSize = false;
            btnOpenCaptureImageModal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnOpenCaptureImageModal.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOpenCaptureImageModal.Depth = 0;
            btnOpenCaptureImageModal.HighEmphasis = true;
            btnOpenCaptureImageModal.Icon = null;
            btnOpenCaptureImageModal.Location = new System.Drawing.Point(28, 122);
            btnOpenCaptureImageModal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnOpenCaptureImageModal.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnOpenCaptureImageModal.Name = "btnOpenCaptureImageModal";
            btnOpenCaptureImageModal.NoAccentTextColor = System.Drawing.Color.Empty;
            btnOpenCaptureImageModal.Size = new System.Drawing.Size(231, 186);
            btnOpenCaptureImageModal.TabIndex = 1;
            btnOpenCaptureImageModal.Text = "CAPTURE";
            btnOpenCaptureImageModal.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOpenCaptureImageModal.UseAccentColor = false;
            btnOpenCaptureImageModal.UseVisualStyleBackColor = true;
            btnOpenCaptureImageModal.Click += btnOpenCaptureImageModal_Click;
            // 
            // btnOpenApplyImageManualModal
            // 
            btnOpenApplyImageManualModal.AutoSize = false;
            btnOpenApplyImageManualModal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnOpenApplyImageManualModal.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOpenApplyImageManualModal.Depth = 0;
            btnOpenApplyImageManualModal.HighEmphasis = true;
            btnOpenApplyImageManualModal.Icon = null;
            btnOpenApplyImageManualModal.Location = new System.Drawing.Point(291, 122);
            btnOpenApplyImageManualModal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnOpenApplyImageManualModal.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnOpenApplyImageManualModal.Name = "btnOpenApplyImageManualModal";
            btnOpenApplyImageManualModal.NoAccentTextColor = System.Drawing.Color.Empty;
            btnOpenApplyImageManualModal.Size = new System.Drawing.Size(231, 186);
            btnOpenApplyImageManualModal.TabIndex = 2;
            btnOpenApplyImageManualModal.Text = "APPLY MANUAL";
            btnOpenApplyImageManualModal.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOpenApplyImageManualModal.UseAccentColor = false;
            btnOpenApplyImageManualModal.UseVisualStyleBackColor = true;
            btnOpenApplyImageManualModal.Click += btnOpenApplyImageManualModal_Click;
            // 
            // btnOpenApplyImageAutomaticModal
            // 
            btnOpenApplyImageAutomaticModal.AutoSize = false;
            btnOpenApplyImageAutomaticModal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnOpenApplyImageAutomaticModal.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOpenApplyImageAutomaticModal.Depth = 0;
            btnOpenApplyImageAutomaticModal.HighEmphasis = true;
            btnOpenApplyImageAutomaticModal.Icon = null;
            btnOpenApplyImageAutomaticModal.Location = new System.Drawing.Point(558, 122);
            btnOpenApplyImageAutomaticModal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnOpenApplyImageAutomaticModal.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnOpenApplyImageAutomaticModal.Name = "btnOpenApplyImageAutomaticModal";
            btnOpenApplyImageAutomaticModal.NoAccentTextColor = System.Drawing.Color.Empty;
            btnOpenApplyImageAutomaticModal.Size = new System.Drawing.Size(231, 186);
            btnOpenApplyImageAutomaticModal.TabIndex = 3;
            btnOpenApplyImageAutomaticModal.Text = "APPLY AUTOMATIC";
            btnOpenApplyImageAutomaticModal.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOpenApplyImageAutomaticModal.UseAccentColor = false;
            btnOpenApplyImageAutomaticModal.UseVisualStyleBackColor = true;
            btnOpenApplyImageAutomaticModal.Click += btnOpenApplyImageAutomaticModal_Click;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(817, 380);
            Controls.Add(btnOpenApplyImageAutomaticModal);
            Controls.Add(btnOpenApplyImageManualModal);
            Controls.Add(btnOpenCaptureImageModal);
            Name = "MenuView";
            Text = "MenuView";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialButton btnOpenCaptureImageModal;
        private MaterialSkinGT.Controls.MaterialButton btnOpenApplyImageManualModal;
        private MaterialSkinGT.Controls.MaterialButton btnOpenApplyImageAutomaticModal;
    }
}