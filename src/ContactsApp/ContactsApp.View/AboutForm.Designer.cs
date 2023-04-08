namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.AuthorEmailLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MITTextBox = new System.Windows.Forms.TextBox();
            this.PictureRightsLabel = new System.Windows.Forms.Label();
            this.PictureRightsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonsPanel.Controls.Add(this.OKButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 353);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(509, 46);
            this.ButtonsPanel.TabIndex = 20;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.LightGray;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Location = new System.Drawing.Point(430, 13);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 13);
            this.OKButton.Name = "OKButton";
            this.OKButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OKButton.Size = new System.Drawing.Size(68, 21);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(10, 29);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 35, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(135, 26);
            this.TitleLabel.TabIndex = 21;
            this.TitleLabel.Text = "ContactsApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 55);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(31, 13);
            this.VersionLabel.TabIndex = 22;
            this.VersionLabel.Text = "v 1.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 85);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 23;
            this.AuthorLabel.Text = "Author:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 108);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 24;
            this.EmailLabel.Text = "E-mail:";
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.Location = new System.Drawing.Point(90, 85);
            this.AuthorNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(82, 13);
            this.AuthorNameLabel.TabIndex = 25;
            this.AuthorNameLabel.Text = "Nikita Manakov";
            // 
            // AuthorEmailLabel
            // 
            this.AuthorEmailLabel.AutoSize = true;
            this.AuthorEmailLabel.Location = new System.Drawing.Point(90, 108);
            this.AuthorEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorEmailLabel.Name = "AuthorEmailLabel";
            this.AuthorEmailLabel.Size = new System.Drawing.Size(127, 13);
            this.AuthorEmailLabel.TabIndex = 26;
            this.AuthorEmailLabel.Text = "nnmanakovv@gmail.com";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(12, 130);
            this.GithubLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(41, 13);
            this.GithubLabel.TabIndex = 27;
            this.GithubLabel.Text = "Github:";
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.AutoSize = true;
            this.GithubLinkLabel.Location = new System.Drawing.Point(90, 130);
            this.GithubLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(138, 13);
            this.GithubLinkLabel.TabIndex = 28;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "https://github.com/settesss";
            this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
            // 
            // MITTextBox
            // 
            this.MITTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MITTextBox.BackColor = System.Drawing.Color.White;
            this.MITTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MITTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MITTextBox.Location = new System.Drawing.Point(14, 159);
            this.MITTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MITTextBox.Multiline = true;
            this.MITTextBox.Name = "MITTextBox";
            this.MITTextBox.ReadOnly = true;
            this.MITTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MITTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MITTextBox.Size = new System.Drawing.Size(482, 160);
            this.MITTextBox.TabIndex = 29;
            this.MITTextBox.Text = resources.GetString("MITTextBox.Text");
            // 
            // PictureRightsLabel
            // 
            this.PictureRightsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureRightsLabel.AutoSize = true;
            this.PictureRightsLabel.Location = new System.Drawing.Point(12, 321);
            this.PictureRightsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PictureRightsLabel.Name = "PictureRightsLabel";
            this.PictureRightsLabel.Size = new System.Drawing.Size(182, 13);
            this.PictureRightsLabel.TabIndex = 30;
            this.PictureRightsLabel.Text = "All used images are downloaded from";
            // 
            // PictureRightsLinkLabel
            // 
            this.PictureRightsLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureRightsLinkLabel.AutoSize = true;
            this.PictureRightsLinkLabel.Location = new System.Drawing.Point(198, 321);
            this.PictureRightsLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PictureRightsLinkLabel.Name = "PictureRightsLinkLabel";
            this.PictureRightsLinkLabel.Size = new System.Drawing.Size(61, 13);
            this.PictureRightsLinkLabel.TabIndex = 31;
            this.PictureRightsLinkLabel.TabStop = true;
            this.PictureRightsLinkLabel.Text = "icons8.com";
            this.PictureRightsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PictureRightsLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 399);
            this.Controls.Add(this.PictureRightsLinkLabel);
            this.Controls.Add(this.PictureRightsLabel);
            this.Controls.Add(this.MITTextBox);
            this.Controls.Add(this.GithubLinkLabel);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.AuthorEmailLabel);
            this.Controls.Add(this.AuthorNameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ButtonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutForm_KeyDown);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Label AuthorEmailLabel;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.LinkLabel GithubLinkLabel;
        private System.Windows.Forms.TextBox MITTextBox;
        private System.Windows.Forms.Label PictureRightsLabel;
        private System.Windows.Forms.LinkLabel PictureRightsLinkLabel;
    }
}