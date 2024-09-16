namespace JImage.Server.Views.Views.Admin
{
    partial class AdminView
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
            materialComboBox1 = new MaterialSkinGT.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkinGT.Controls.MaterialLabel();
            materialTextBox21 = new MaterialSkinGT.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkinGT.Controls.MaterialLabel();
            btnLogin = new MaterialSkinGT.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Test Enginner VI", "Test Enginner III", "Test Engineer II", "Test Engineer I" });
            materialComboBox1.Location = new System.Drawing.Point(36, 170);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkinGT.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new System.Drawing.Size(300, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(36, 148);
            materialLabel1.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(36, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "User:";
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
            materialTextBox21.Location = new System.Drawing.Point(36, 264);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkinGT.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '*';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new System.Drawing.Size(300, 48);
            materialTextBox21.TabIndex = 2;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(36, 242);
            materialLabel2.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(75, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new System.Drawing.Point(272, 321);
            btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            btnLogin.Size = new System.Drawing.Size(64, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(373, 412);
            Controls.Add(btnLogin);
            Controls.Add(materialLabel2);
            Controls.Add(materialTextBox21);
            Controls.Add(materialLabel1);
            Controls.Add(materialComboBox1);
            Name = "AdminView";
            Text = "AdminView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel1;
        private MaterialSkinGT.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel2;
        private MaterialSkinGT.Controls.MaterialButton btnLogin;
    }
}