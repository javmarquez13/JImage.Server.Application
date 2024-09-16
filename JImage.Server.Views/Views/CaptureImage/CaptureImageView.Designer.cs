namespace JImage.Server.Views.Views.CaptureImage
{
    partial class CaptureImageView
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
            btnCaptureImage = new MaterialSkinGT.Controls.MaterialButton();
            materialTextBox21 = new MaterialSkinGT.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkinGT.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkinGT.Controls.MaterialLabel();
            materialTextBox22 = new MaterialSkinGT.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkinGT.Controls.MaterialLabel();
            materialTextBox23 = new MaterialSkinGT.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // btnCaptureImage
            // 
            btnCaptureImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnCaptureImage.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCaptureImage.Depth = 0;
            btnCaptureImage.HighEmphasis = true;
            btnCaptureImage.Icon = null;
            btnCaptureImage.Location = new System.Drawing.Point(801, 638);
            btnCaptureImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnCaptureImage.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnCaptureImage.Name = "btnCaptureImage";
            btnCaptureImage.NoAccentTextColor = System.Drawing.Color.Empty;
            btnCaptureImage.Size = new System.Drawing.Size(86, 36);
            btnCaptureImage.TabIndex = 0;
            btnCaptureImage.Text = "CAPTURE";
            btnCaptureImage.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCaptureImage.UseAccentColor = false;
            btnCaptureImage.UseVisualStyleBackColor = true;
            btnCaptureImage.Click += BtnCaptureImage_Click;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBox21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new System.Drawing.Point(156, 165);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkinGT.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new System.Drawing.Size(598, 48);
            materialTextBox21.TabIndex = 1;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(156, 143);
            materialLabel1.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(152, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Capture image name:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(156, 270);
            materialLabel2.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(143, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Path to store image:";
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBox22.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new System.Drawing.Point(156, 292);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkinGT.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new System.Drawing.Size(598, 48);
            materialTextBox22.TabIndex = 3;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel3.Location = new System.Drawing.Point(156, 397);
            materialLabel3.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new System.Drawing.Size(83, 19);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Other thing:";
            // 
            // materialTextBox23
            // 
            materialTextBox23.AnimateReadOnly = false;
            materialTextBox23.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBox23.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            materialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBox23.Depth = 0;
            materialTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBox23.HideSelection = true;
            materialTextBox23.LeadingIcon = null;
            materialTextBox23.Location = new System.Drawing.Point(156, 419);
            materialTextBox23.MaxLength = 32767;
            materialTextBox23.MouseState = MaterialSkinGT.MouseState.OUT;
            materialTextBox23.Name = "materialTextBox23";
            materialTextBox23.PasswordChar = '\0';
            materialTextBox23.PrefixSuffixText = null;
            materialTextBox23.ReadOnly = false;
            materialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            materialTextBox23.SelectedText = "";
            materialTextBox23.SelectionLength = 0;
            materialTextBox23.SelectionStart = 0;
            materialTextBox23.ShortcutsEnabled = true;
            materialTextBox23.Size = new System.Drawing.Size(598, 48);
            materialTextBox23.TabIndex = 5;
            materialTextBox23.TabStop = false;
            materialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBox23.TrailingIcon = null;
            materialTextBox23.UseSystemPasswordChar = false;
            // 
            // CaptureImageView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(894, 683);
            Controls.Add(materialLabel3);
            Controls.Add(materialTextBox23);
            Controls.Add(materialLabel2);
            Controls.Add(materialTextBox22);
            Controls.Add(materialLabel1);
            Controls.Add(materialTextBox21);
            Controls.Add(btnCaptureImage);
            Name = "CaptureImageView";
            Text = "CaptureImageView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialButton btnCaptureImage;
        private MaterialSkinGT.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel1;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel2;
        private MaterialSkinGT.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel3;
        private MaterialSkinGT.Controls.MaterialTextBox2 materialTextBox23;
    }
}