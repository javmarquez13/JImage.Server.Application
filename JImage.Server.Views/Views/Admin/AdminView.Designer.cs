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
            cbUsers = new MaterialSkinGT.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkinGT.Controls.MaterialLabel();
            txtPassowrd = new MaterialSkinGT.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkinGT.Controls.MaterialLabel();
            btnLogin = new MaterialSkinGT.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cbUsers
            // 
            cbUsers.AutoResize = false;
            cbUsers.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cbUsers.Depth = 0;
            cbUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cbUsers.DropDownHeight = 174;
            cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbUsers.DropDownWidth = 121;
            cbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cbUsers.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cbUsers.FormattingEnabled = true;
            cbUsers.IntegralHeight = false;
            cbUsers.ItemHeight = 43;
            cbUsers.Location = new System.Drawing.Point(36, 170);
            cbUsers.MaxDropDownItems = 4;
            cbUsers.MouseState = MaterialSkinGT.MouseState.OUT;
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new System.Drawing.Size(300, 49);
            cbUsers.StartIndex = 0;
            cbUsers.TabIndex = 0;
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
            // txtPassowrd
            // 
            txtPassowrd.AnimateReadOnly = false;
            txtPassowrd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtPassowrd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtPassowrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtPassowrd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtPassowrd.Depth = 0;
            txtPassowrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtPassowrd.HideSelection = true;
            txtPassowrd.LeadingIcon = null;
            txtPassowrd.Location = new System.Drawing.Point(36, 264);
            txtPassowrd.MaxLength = 32767;
            txtPassowrd.MouseState = MaterialSkinGT.MouseState.OUT;
            txtPassowrd.Name = "txtPassowrd";
            txtPassowrd.PasswordChar = '*';
            txtPassowrd.PrefixSuffixText = null;
            txtPassowrd.ReadOnly = false;
            txtPassowrd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPassowrd.SelectedText = "";
            txtPassowrd.SelectionLength = 0;
            txtPassowrd.SelectionStart = 0;
            txtPassowrd.ShortcutsEnabled = true;
            txtPassowrd.Size = new System.Drawing.Size(300, 48);
            txtPassowrd.TabIndex = 2;
            txtPassowrd.TabStop = false;
            txtPassowrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtPassowrd.TrailingIcon = null;
            txtPassowrd.UseSystemPasswordChar = false;
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
            // 
            // AdminView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(373, 412);
            Controls.Add(btnLogin);
            Controls.Add(materialLabel2);
            Controls.Add(txtPassowrd);
            Controls.Add(materialLabel1);
            Controls.Add(cbUsers);
            Name = "AdminView";
            Text = "AdminView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialComboBox cbUsers;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel1;
        private MaterialSkinGT.Controls.MaterialTextBox2 txtPassowrd;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel2;
        private MaterialSkinGT.Controls.MaterialButton btnLogin;
    }
}