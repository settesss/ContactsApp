namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveUserButton = new System.Windows.Forms.PictureBox();
            this.EditUserButton = new System.Windows.Forms.PictureBox();
            this.AddUserButton = new System.Windows.Forms.PictureBox();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BirthDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NotificationPanel = new System.Windows.Forms.Panel();
            this.BirthdayUsersLabel = new System.Windows.Forms.Label();
            this.NotificationBirthLabel = new System.Windows.Forms.Label();
            this.NotificationPictureBox = new System.Windows.Forms.PictureBox();
            this.NotificationCloseButton = new System.Windows.Forms.Button();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveUserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditUserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUserButton)).BeginInit();
            this.NotificationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Panel1.Controls.Add(this.ButtonsTableLayoutPanel);
            this.SplitContainer.Panel1.Controls.Add(this.UsersListBox);
            this.SplitContainer.Panel1.Controls.Add(this.FindTextBox);
            this.SplitContainer.Panel1.Controls.Add(this.FindLabel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Panel2.Controls.Add(this.PhoneMaskedTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.BirthDateMaskedTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.NotificationPanel);
            this.SplitContainer.Panel2.Controls.Add(this.VKTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.VKLabel);
            this.SplitContainer.Panel2.Controls.Add(this.BirthDateLabel);
            this.SplitContainer.Panel2.Controls.Add(this.PhoneLabel);
            this.SplitContainer.Panel2.Controls.Add(this.EmailTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.EmailLabel);
            this.SplitContainer.Panel2.Controls.Add(this.FullNameTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.FullNameLabel);
            this.SplitContainer.Panel2.Controls.Add(this.UserPictureBox);
            this.SplitContainer.Size = new System.Drawing.Size(800, 450);
            this.SplitContainer.SplitterDistance = 250;
            this.SplitContainer.SplitterWidth = 3;
            this.SplitContainer.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveUserButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditUserButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddUserButton, 0, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(6, 412);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(238, 35);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveUserButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveUserButton.Location = new System.Drawing.Point(158, 0);
            this.RemoveUserButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(80, 35);
            this.RemoveUserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveUserButton.TabIndex = 7;
            this.RemoveUserButton.TabStop = false;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            this.RemoveUserButton.MouseEnter += new System.EventHandler(this.RemoveUserButton_MouseEnter);
            this.RemoveUserButton.MouseLeave += new System.EventHandler(this.RemoveUserButton_MouseLeave);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditUserButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditUserButton.Location = new System.Drawing.Point(79, 0);
            this.EditUserButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(79, 35);
            this.EditUserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditUserButton.TabIndex = 6;
            this.EditUserButton.TabStop = false;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            this.EditUserButton.MouseEnter += new System.EventHandler(this.EditUserButton_MouseEnter);
            this.EditUserButton.MouseLeave += new System.EventHandler(this.EditUserButton_MouseLeave);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUserButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddUserButton.Location = new System.Drawing.Point(0, 0);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(79, 35);
            this.AddUserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddUserButton.TabIndex = 5;
            this.AddUserButton.TabStop = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            this.AddUserButton.MouseEnter += new System.EventHandler(this.AddUserButton_MouseEnter);
            this.AddUserButton.MouseLeave += new System.EventHandler(this.AddUserButton_MouseLeave);
            // 
            // UsersListBox
            // 
            this.UsersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.IntegralHeight = false;
            this.UsersListBox.Location = new System.Drawing.Point(6, 30);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(238, 382);
            this.UsersListBox.TabIndex = 2;
            this.UsersListBox.SelectedIndexChanged += new System.EventHandler(this.UsersListBox_SelectedIndexChanged);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindTextBox.Location = new System.Drawing.Point(38, 6);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(206, 20);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(3, 9);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "Find:";
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.PhoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(112, 133);
            this.PhoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneMaskedTextBox.Mask = "+7 (999) 000-00-00";
            this.PhoneMaskedTextBox.MinimumSize = new System.Drawing.Size(143, 22);
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.ReadOnly = true;
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(175, 20);
            this.PhoneMaskedTextBox.TabIndex = 13;
            // 
            // BirthDateMaskedTextBox
            // 
            this.BirthDateMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.BirthDateMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BirthDateMaskedTextBox.Location = new System.Drawing.Point(112, 182);
            this.BirthDateMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BirthDateMaskedTextBox.Mask = "00/00/0000";
            this.BirthDateMaskedTextBox.MinimumSize = new System.Drawing.Size(143, 22);
            this.BirthDateMaskedTextBox.Name = "BirthDateMaskedTextBox";
            this.BirthDateMaskedTextBox.ReadOnly = true;
            this.BirthDateMaskedTextBox.Size = new System.Drawing.Size(175, 20);
            this.BirthDateMaskedTextBox.TabIndex = 12;
            this.BirthDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.NotificationPanel.Controls.Add(this.BirthdayUsersLabel);
            this.NotificationPanel.Controls.Add(this.NotificationBirthLabel);
            this.NotificationPanel.Controls.Add(this.NotificationPictureBox);
            this.NotificationPanel.Controls.Add(this.NotificationCloseButton);
            this.NotificationPanel.Location = new System.Drawing.Point(6, 370);
            this.NotificationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(544, 80);
            this.NotificationPanel.TabIndex = 11;
            // 
            // BirthdayUsersLabel
            // 
            this.BirthdayUsersLabel.AutoSize = true;
            this.BirthdayUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayUsersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayUsersLabel.Location = new System.Drawing.Point(83, 41);
            this.BirthdayUsersLabel.Name = "BirthdayUsersLabel";
            this.BirthdayUsersLabel.Size = new System.Drawing.Size(0, 13);
            this.BirthdayUsersLabel.TabIndex = 14;
            // 
            // NotificationBirthLabel
            // 
            this.NotificationBirthLabel.AutoSize = true;
            this.NotificationBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationBirthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.NotificationBirthLabel.Location = new System.Drawing.Point(82, 20);
            this.NotificationBirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NotificationBirthLabel.Name = "NotificationBirthLabel";
            this.NotificationBirthLabel.Size = new System.Drawing.Size(146, 13);
            this.NotificationBirthLabel.TabIndex = 12;
            this.NotificationBirthLabel.Text = "Today is the Birthday of:";
            // 
            // NotificationPictureBox
            // 
            this.NotificationPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NotificationPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48_empty;
            this.NotificationPictureBox.Location = new System.Drawing.Point(6, 5);
            this.NotificationPictureBox.Name = "NotificationPictureBox";
            this.NotificationPictureBox.Size = new System.Drawing.Size(71, 69);
            this.NotificationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NotificationPictureBox.TabIndex = 1;
            this.NotificationPictureBox.TabStop = false;
            // 
            // NotificationCloseButton
            // 
            this.NotificationCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotificationCloseButton.FlatAppearance.BorderSize = 0;
            this.NotificationCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32_empty;
            this.NotificationCloseButton.Location = new System.Drawing.Point(512, 5);
            this.NotificationCloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.NotificationCloseButton.Name = "NotificationCloseButton";
            this.NotificationCloseButton.Size = new System.Drawing.Size(26, 28);
            this.NotificationCloseButton.TabIndex = 0;
            this.NotificationCloseButton.UseVisualStyleBackColor = true;
            this.NotificationCloseButton.Click += new System.EventHandler(this.NotificationCloseButton_Click);
            // 
            // VKTextBox
            // 
            this.VKTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VKTextBox.Location = new System.Drawing.Point(112, 231);
            this.VKTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VKTextBox.MinimumSize = new System.Drawing.Size(143, 22);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(175, 20);
            this.VKTextBox.TabIndex = 10;
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
            // 
            // VKLabel
            // 
            this.VKLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(112, 216);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(112, 167);
            this.BirthDateLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(69, 13);
            this.BirthDateLabel.TabIndex = 7;
            this.BirthDateLabel.Text = "Date of Birth:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(112, 118);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Location = new System.Drawing.Point(112, 86);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(143, 22);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(432, 20);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(112, 71);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-Mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTextBox.Location = new System.Drawing.Point(112, 25);
            this.FullNameTextBox.MinimumSize = new System.Drawing.Size(143, 22);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(432, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(112, 9);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.InitialImage = null;
            this.UserPictureBox.Location = new System.Drawing.Point(6, 6);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(100, 100);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(514, 375);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveUserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditUserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUserButton)).EndInit();
            this.NotificationPanel.ResumeLayout(false);
            this.NotificationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Panel NotificationPanel;
        private System.Windows.Forms.Button NotificationCloseButton;
        private System.Windows.Forms.PictureBox NotificationPictureBox;
        private System.Windows.Forms.Label NotificationBirthLabel;
        private System.Windows.Forms.MaskedTextBox BirthDateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Label BirthdayUsersLabel;
        private System.Windows.Forms.PictureBox AddUserButton;
        private System.Windows.Forms.PictureBox EditUserButton;
        private System.Windows.Forms.PictureBox RemoveUserButton;
    }
}

