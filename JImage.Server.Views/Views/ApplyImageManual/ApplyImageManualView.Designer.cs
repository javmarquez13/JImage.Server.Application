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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "", "AmazonImg1", "AmazonImg2", "AmazonImg3", "" }, -1);
            materialListView1 = new MaterialSkinGT.Controls.MaterialListView();
            materialLabel1 = new MaterialSkinGT.Controls.MaterialLabel();
            btnApplyImage = new MaterialSkinGT.Controls.MaterialButton();
            btnSelectRootPath = new MaterialSkinGT.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.HideSelection = false;
            materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            materialListView1.Location = new System.Drawing.Point(6, 110);
            materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            materialListView1.MouseState = MaterialSkinGT.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new System.Drawing.Size(788, 219);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(6, 88);
            materialLabel1.MouseState = MaterialSkinGT.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(57, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Images:";
            // 
            // btnApplyImage
            // 
            btnApplyImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnApplyImage.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplyImage.Depth = 0;
            btnApplyImage.HighEmphasis = true;
            btnApplyImage.Icon = null;
            btnApplyImage.Location = new System.Drawing.Point(726, 486);
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
            // btnSelectRootPath
            // 
            btnSelectRootPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSelectRootPath.Density = MaterialSkinGT.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSelectRootPath.Depth = 0;
            btnSelectRootPath.HighEmphasis = true;
            btnSelectRootPath.Icon = null;
            btnSelectRootPath.Location = new System.Drawing.Point(678, 338);
            btnSelectRootPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnSelectRootPath.MouseState = MaterialSkinGT.MouseState.HOVER;
            btnSelectRootPath.Name = "btnSelectRootPath";
            btnSelectRootPath.NoAccentTextColor = System.Drawing.Color.Empty;
            btnSelectRootPath.Size = new System.Drawing.Size(116, 36);
            btnSelectRootPath.TabIndex = 3;
            btnSelectRootPath.Text = "SELECT PATH";
            btnSelectRootPath.Type = MaterialSkinGT.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSelectRootPath.UseAccentColor = false;
            btnSelectRootPath.UseVisualStyleBackColor = true;
            // 
            // ApplyImageManualView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 531);
            Controls.Add(btnSelectRootPath);
            Controls.Add(btnApplyImage);
            Controls.Add(materialLabel1);
            Controls.Add(materialListView1);
            Name = "ApplyImageManualView";
            Text = "ApplyImageManualView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkinGT.Controls.MaterialListView materialListView1;
        private MaterialSkinGT.Controls.MaterialLabel materialLabel1;
        private MaterialSkinGT.Controls.MaterialButton btnApplyImage;
        private MaterialSkinGT.Controls.MaterialButton btnSelectRootPath;
    }
}