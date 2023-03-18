using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            ContactForm AddContactForm = new ContactForm(/*this.UsersListBox*/);
            AddContactForm.Show();
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            ContactForm EditContactForm = new ContactForm(/*this.UsersListBox*/);
            EditContactForm.Show();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                AboutForm OpenAboutForm = new AboutForm();
                OpenAboutForm.Show();
            }
            /*if (e.KeyData == Keys.F2)
            {
                DateTime birthDate = new DateTime(2023, 03, 18);
                DateTime date = new DateTime(2022, 04, 11);
                Project pr = new Project();
                Model.Contact user1 = new Model.Contact("Nikita", "", "", date, "");
                Model.Contact user2 = new Model.Contact("Artem", "", "", birthDate, "");
                Model.Contact user3 = new Model.Contact("Maxim", "", "", birthDate, "");
                UsersListBox.Items.Add(user1.FullName);
                UsersListBox.Items.Add(user2.FullName);
                UsersListBox.Items.Add(user3.FullName);
                pr.contacts.Add(user1);
                pr.contacts.Add(user2);
                pr.contacts.Add(user3);
                pr.FullNameSort(UsersListBox, "Nikita");
            }*/
        }

        private void NotificationCloseButton_Click(object sender, EventArgs e)
        {
            NotificationCloseButton.Visible = false;
            NotificationPanel.Visible = false;
            NotificationBirthLabel.Visible = false;
            NotificationPictureBox.Visible = false;
        }
    }
}
