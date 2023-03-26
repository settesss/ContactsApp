using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает главную форму.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Проект.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Строит пользовательский интерфейс <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает все элементы <see cref="UsersListBox"/>, возвращает 
        /// обновленный список контактов.
        /// </summary>
        private ListBox UpdateListBox()
        {
            UsersListBox.Items.Clear();
            for (int i = 0; i < _project.Contacts.Count; i++)
            {
                UsersListBox.Items.Add(_project.Contacts[i].FullName);
            }
            return UsersListBox;
        }

        /// <summary>
        /// Получает объект по индексу из поля <see cref="_project"/>, заполняет данные 
        /// на правой панели <see cref="MainForm"/>.
        /// </summary>
        private void UpdateSelectedContact(int index)
        {
            FullNameTextBox.Text = _project.Contacts[index].FullName;
            EmailTextBox.Text = _project.Contacts[index].Email;
            PhoneMaskedTextBox.Text = _project.Contacts[index].PhoneNumber;
            BirthDateMaskedTextBox.Text = _project.Contacts[index].BirthDate.ToString();
            VKTextBox.Text = _project.Contacts[index].VKID;
        }

        /// <summary>
        /// Очищает все элементы управления на правой панели <see cref="MainForm"/>.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Clear();
            EmailTextBox.Clear();
            PhoneMaskedTextBox.Clear();
            BirthDateMaskedTextBox.Clear();
            VKTextBox.Clear();
        }

        /// <summary>
        /// Добавляет новый объект контакта.
        /// </summary>
        private void AddContact()
        {
            Contact user = new Contact();
            ContactFactory.GenerateRandom(user);
            _project.Contacts.Add(user);
        }

        /// <summary>
        /// Открывает <see cref="ContactForm"/> для редактирования контакта.
        /// </summary>
        private void EditContact(int index)
        {
            var form = new ContactForm();
            var contactToEdit = _project.Contacts[index].Clone();
            form.Contact = contactToEdit;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var editedContact = form.Contact;
                UsersListBox.Items.RemoveAt(index);
                _project.Contacts.RemoveAt(index);
                _project.Contacts.Insert(index, editedContact);
            }
            else if (form.DialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        /// <summary>
        /// Удаляет объект контакта, вызывает форму подтверждения.
        /// </summary>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                return;
            }
            else
            {
                var result = MessageBox.Show("Do you really want to remove "
                + _project.Contacts[index].FullName + "?",
                "Deletion message:", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    _project.Contacts.RemoveAt(index);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Загружает форму <see cref="MainForm"/>.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        /// <summary>
        /// Открывает форму <see cref="ContactForm"/> и добавляет контакт.
        /// </summary>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            ContactForm AddContactForm = new ContactForm();
            AddContactForm.ShowDialog();
            if (AddContactForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(AddContactForm.Contact);
                UpdateListBox();
            }
            else if (AddContactForm.DialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        /// <summary>
        /// Открывает форму <see cref="ContactForm"/>.
        /// </summary>
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = UsersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                EditContact(selectedIndex);
                UpdateListBox();
            }
            else 
            { 
                return; 
            }
        }

        /// <summary>
        /// Вызывает функцию удаления контакта и обновления <see cref="UsersListBox"/>.
        /// </summary>
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            RemoveContact(UsersListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Открывает форму <see cref="AboutForm"/> нажатием F1.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                AboutForm OpenAboutForm = new AboutForm();
                OpenAboutForm.Show();
            }
        }

        /// <summary>
        /// Закрывает уведомление о днях рождения.
        /// </summary>
        private void NotificationCloseButton_Click(object sender, EventArgs e)
        {
            NotificationCloseButton.Visible = false;
            NotificationPanel.Visible = false;
            NotificationBirthLabel.Visible = false;
            NotificationPictureBox.Visible = false;
        }

        /// <summary>
        /// Выводит информацию по выбранному в <see cref="UsersListBox"/> индексу
        /// на правую панель <see cref="MainForm"/>.
        /// </summary>
        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedIndex == -1) 
            { 
                ClearSelectedContact();
            }
            else
            {
                UpdateSelectedContact(UsersListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Вызывает MessageBox при закрытии <see cref="MainForm"/>.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to close the program?",
                "Exit Message:", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
