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
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.panelNotification = new System.Windows.Forms.Panel();
            this.labelNotificationBirth = new System.Windows.Forms.Label();
            this.pictureBoxNotification = new System.Windows.Forms.PictureBox();
            this.buttonNotificationClose = new System.Windows.Forms.Button();
            this.textBoxVK = new System.Windows.Forms.TextBox();
            this.labelVK = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Panel1.Controls.Add(this.buttonDeleteUser);
            this.SplitContainer.Panel1.Controls.Add(this.buttonEditUser);
            this.SplitContainer.Panel1.Controls.Add(this.buttonAddUser);
            this.SplitContainer.Panel1.Controls.Add(this.listBoxUsers);
            this.SplitContainer.Panel1.Controls.Add(this.textBoxFind);
            this.SplitContainer.Panel1.Controls.Add(this.labelFind);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Panel2.Controls.Add(this.maskedTextBoxPhone);
            this.SplitContainer.Panel2.Controls.Add(this.maskedTextBoxBirthDate);
            this.SplitContainer.Panel2.Controls.Add(this.panelNotification);
            this.SplitContainer.Panel2.Controls.Add(this.textBoxVK);
            this.SplitContainer.Panel2.Controls.Add(this.labelVK);
            this.SplitContainer.Panel2.Controls.Add(this.labelBirthDate);
            this.SplitContainer.Panel2.Controls.Add(this.labelPhone);
            this.SplitContainer.Panel2.Controls.Add(this.textBoxEmail);
            this.SplitContainer.Panel2.Controls.Add(this.labelEmail);
            this.SplitContainer.Panel2.Controls.Add(this.textBoxFullName);
            this.SplitContainer.Panel2.Controls.Add(this.labelFullName);
            this.SplitContainer.Panel2.Controls.Add(this.pictureBoxUser);
            this.SplitContainer.Size = new System.Drawing.Size(874, 495);
            this.SplitContainer.SplitterDistance = 288;
            this.SplitContainer.TabIndex = 0;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteUser.Image")));
            this.buttonDeleteUser.Location = new System.Drawing.Point(205, 439);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(50, 46);
            this.buttonDeleteUser.TabIndex = 4;
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditUser.FlatAppearance.BorderSize = 0;
            this.buttonEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditUser.Image")));
            this.buttonEditUser.Location = new System.Drawing.Point(119, 439);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(50, 46);
            this.buttonEditUser.TabIndex = 3;
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddUser.Image")));
            this.buttonAddUser.Location = new System.Drawing.Point(33, 439);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(50, 46);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 34);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(263, 402);
            this.listBoxUsers.TabIndex = 2;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFind.Location = new System.Drawing.Point(54, 6);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(221, 22);
            this.textBoxFind.TabIndex = 1;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(12, 9);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(36, 16);
            this.labelFind.TabIndex = 0;
            this.labelFind.Text = "Find:";
            // 
            // panelNotification
            // 
            this.panelNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotification.BackColor = System.Drawing.Color.AliceBlue;
            this.panelNotification.Controls.Add(this.labelNotificationBirth);
            this.panelNotification.Controls.Add(this.pictureBoxNotification);
            this.panelNotification.Controls.Add(this.buttonNotificationClose);
            this.panelNotification.Location = new System.Drawing.Point(3, 395);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(569, 100);
            this.panelNotification.TabIndex = 11;
            // 
            // labelNotificationBirth
            // 
            this.labelNotificationBirth.AutoSize = true;
            this.labelNotificationBirth.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotificationBirth.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNotificationBirth.Location = new System.Drawing.Point(81, 30);
            this.labelNotificationBirth.Name = "labelNotificationBirth";
            this.labelNotificationBirth.Size = new System.Drawing.Size(156, 20);
            this.labelNotificationBirth.TabIndex = 12;
            this.labelNotificationBirth.Text = "Today is Birthday of:";
            // 
            // pictureBoxNotification
            // 
            this.pictureBoxNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxNotification.Image = global::ContactsApp.View.Properties.Resources.info_48x48_empty;
            this.pictureBoxNotification.Location = new System.Drawing.Point(15, 19);
            this.pictureBoxNotification.Name = "pictureBoxNotification";
            this.pictureBoxNotification.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNotification.TabIndex = 1;
            this.pictureBoxNotification.TabStop = false;
            // 
            // buttonNotificationClose
            // 
            this.buttonNotificationClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNotificationClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNotificationClose.FlatAppearance.BorderSize = 0;
            this.buttonNotificationClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotificationClose.Image = global::ContactsApp.View.Properties.Resources.close_32x32_empty;
            this.buttonNotificationClose.Location = new System.Drawing.Point(531, 3);
            this.buttonNotificationClose.Name = "buttonNotificationClose";
            this.buttonNotificationClose.Size = new System.Drawing.Size(35, 35);
            this.buttonNotificationClose.TabIndex = 0;
            this.buttonNotificationClose.UseVisualStyleBackColor = true;
            // 
            // textBoxVK
            // 
            this.textBoxVK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVK.Location = new System.Drawing.Point(132, 260);
            this.textBoxVK.MinimumSize = new System.Drawing.Size(190, 22);
            this.textBoxVK.Name = "textBoxVK";
            this.textBoxVK.Size = new System.Drawing.Size(190, 22);
            this.textBoxVK.TabIndex = 10;
            // 
            // labelVK
            // 
            this.labelVK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVK.AutoSize = true;
            this.labelVK.Location = new System.Drawing.Point(129, 241);
            this.labelVK.Name = "labelVK";
            this.labelVK.Size = new System.Drawing.Size(27, 16);
            this.labelVK.TabIndex = 9;
            this.labelVK.Text = "VK:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(129, 183);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(82, 16);
            this.labelBirthDate.TabIndex = 7;
            this.labelBirthDate.Text = "Date of Birth:";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(129, 123);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(97, 16);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "PhoneNumber:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(132, 84);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(440, 22);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(129, 65);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 16);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-Mail:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFullName.Location = new System.Drawing.Point(132, 28);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(440, 22);
            this.textBoxFullName.TabIndex = 2;
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(129, 9);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(71, 16);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full Name:";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.InitialImage = null;
            this.pictureBoxUser.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(108, 108);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // maskedTextBoxBirthDate
            // 
            this.maskedTextBoxBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxBirthDate.Location = new System.Drawing.Point(132, 203);
            this.maskedTextBoxBirthDate.Mask = "00/00/0000";
            this.maskedTextBoxBirthDate.MinimumSize = new System.Drawing.Size(190, 22);
            this.maskedTextBoxBirthDate.Name = "maskedTextBoxBirthDate";
            this.maskedTextBoxBirthDate.Size = new System.Drawing.Size(190, 22);
            this.maskedTextBoxBirthDate.TabIndex = 12;
            this.maskedTextBoxBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(132, 142);
            this.maskedTextBoxPhone.Mask = "+7 (999) 000-0000";
            this.maskedTextBoxPhone.MinimumSize = new System.Drawing.Size(190, 22);
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(190, 22);
            this.maskedTextBoxPhone.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 495);
            this.Controls.Add(this.SplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.panelNotification.ResumeLayout(false);
            this.panelNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxVK;
        private System.Windows.Forms.Label labelVK;
        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.Button buttonNotificationClose;
        private System.Windows.Forms.PictureBox pictureBoxNotification;
        private System.Windows.Forms.Label labelNotificationBirth;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}

