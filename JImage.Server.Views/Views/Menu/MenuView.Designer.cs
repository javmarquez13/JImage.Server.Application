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
            btnOpenApplyImageManualModal = new MaterialSkinGT.Controls.MaterialButton();
            materialButton1 = new MaterialSkinGT.Controls.MaterialButton();
            materialButton2 = new MaterialSkinGT.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnOpenApplyImageManualModal
            // 
            btnOpenApplyImageManualModal.AutoSize = false;
            btnOpenApplyImageManualModal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnOpenApplyImageManualModal.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOpenApplyImageManualModal.Depth = 0;
            btnOpenApplyImageManualModal.HighEmphasis = true;
            btnOpenApplyImageManualModal.Icon = null;
            btnOpenApplyImageManualModal.Location = new System.Drawing.Point(28, 122);
            btnOpenApplyImageManualModal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnOpenApplyImageManualModal.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnOpenApplyImageManualModal.Name = "btnOpenApplyImageManualModal";
            btnOpenApplyImageManualModal.NoAccentTextColor = System.Drawing.Color.Empty;
            btnOpenApplyImageManualModal.Size = new System.Drawing.Size(231, 186);
            btnOpenApplyImageManualModal.TabIndex = 1;
            btnOpenApplyImageManualModal.Text = "CAPTURE";
            btnOpenApplyImageManualModal.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOpenApplyImageManualModal.UseAccentColor = false;
            btnOpenApplyImageManualModal.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new System.Drawing.Point(291, 122);
            materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButton1.Size = new System.Drawing.Size(231, 186);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "APPLY MANUAL";
            materialButton1.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new System.Drawing.Point(558, 122);
            materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButton2.Size = new System.Drawing.Size(231, 186);
            materialButton2.TabIndex = 3;
            materialButton2.Text = "APPLY AUTOMATIC";
            materialButton2.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(817, 380);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(btnOpenApplyImageManualModal);
            Name = "MenuView";
            Text = "MenuView";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialButton btnOpenApplyImageManualModal;
        private MaterialSkinGT.Controls.MaterialButton materialButton1;
        private MaterialSkinGT.Controls.MaterialButton materialButton2;
    }
}