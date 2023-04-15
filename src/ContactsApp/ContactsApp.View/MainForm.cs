using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        /// Текущие контакты, которые отображаются на экране.
        /// </summary>
        private List<Contact> _currentContacts = new List<Contact>();

        /// <summary>
        /// Проверка нажатия на <see cref="NotificationCloseButton"/>
        /// </summary>
        private bool notificationClose = false;

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
            if (FindTextBox.Text == "")
            {
                for (int i = 0; i < _project.Contacts.Count; i++)
                {
                    UsersListBox.Items.Add(_project.Contacts[i].FullName);
                }
                if (notificationClose == false)
                {
                    BirthdayUsersLabel.Text =
                        _project.FindContactsOfBirthdayPeople(_project.Contacts);
                }
            }
            else
            {
                for (int i = 0; i < _currentContacts.Count; i++)
                {
                    UsersListBox.Items.Add(_currentContacts[i].FullName);
                }
            }
            return UsersListBox;
        }

        /// <summary>
        /// Получает объект по индексу из поля <see cref="_project"/>, заполняет данные 
        /// на правой панели <see cref="MainForm"/>.
        /// </summary>
        private void UpdateSelectedContact(int index)
        {
            var contact = (FindTextBox.Text == "") ? _project.Contacts[index] : _currentContacts[index];
            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneMaskedTextBox.Text = contact.PhoneNumber;
            BirthDateMaskedTextBox.Text = contact.DateOfBirth.ToString();
            VKTextBox.Text = contact.VKID;
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
        private void EditContact(int index, List<Contact> contacts)
        {
            var form = new ContactForm();
            Contact contactToEdit;
            contactToEdit = (Contact)contacts[index].Clone();
            form.Contact = contactToEdit;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var editedContact = form.Contact;
                if (contacts.Count == _currentContacts.Count)
                {
                    for (int i = 0; i < _project.Contacts.Count; i++)
                    {
                        if (_project.Contacts[i] == _currentContacts[index])
                        {
                            _project.Contacts.RemoveAt(i);
                            _project.Contacts.Insert(i, editedContact);
                            break;
                        }
                    }
                }
                UsersListBox.Items.RemoveAt(index);
                contacts.RemoveAt(index);
                contacts.Insert(index, editedContact);
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
                    if (FindTextBox.Text == "")
                    {
                        _project.Contacts.RemoveAt(index);
                    }
                    else
                    {
                        for (int i = 0; i < _project.Contacts.Count; i++)
                        {
                            if (_project.Contacts[i] == _currentContacts[index])
                            {
                                _project.Contacts.RemoveAt(i);
                                _currentContacts.RemoveAt(index);
                                break;
                            }
                        }
                    }
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
                _project.Contacts.Sort(_project.SortContactsByFullName);
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
                if (FindTextBox.Text == "")
                {
                    EditContact(selectedIndex, _project.Contacts);
                }
                else
                {
                    EditContact(selectedIndex, _currentContacts);
                }
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
            notificationClose = true;
            NotificationPanel.Visible = false;
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

        /// <summary>
        /// Обрабатывает введённый текст в <see cref="FindTextBox"/>
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text != "")
            {
                _currentContacts = 
                    _project.FindContactsBySubstring(_project.Contacts, FindTextBox.Text);
                UpdateListBox();
            }
            else
            {
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="AddUserButton"></see>
        /// </summary>
        private void AddUserButton_MouseEnter(object sender, EventArgs e)
        {
            AddUserButton.Image = Properties.Resources.add_contact_32x32;
            AddUserButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="AddUserButton"/>
        /// </summary>
        private void AddUserButton_MouseLeave(object sender, EventArgs e)
        {
            AddUserButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddUserButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="EditUserButton"></see>
        /// </summary>
        private void EditUserButton_MouseEnter(object sender, EventArgs e)
        {
            EditUserButton.Image = Properties.Resources.edit_contact_32x32;
            EditUserButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="EditUserButton"/>
        /// </summary>
        private void EditUserButton_MouseLeave(object sender, EventArgs e)
        {
            EditUserButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditUserButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="DeleteUserButton"></see>
        /// </summary>
        private void DeleteUserButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteUserButton.Image = Properties.Resources.remove_contact_32x32;
            DeleteUserButton.BackColor = ColorTranslator.FromHtml("#FAF5FF");
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="DeleteUserButton"/>
        /// </summary>
        private void DeleteUserButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteUserButton.Image = Properties.Resources.remove_contact_32x32_gray;
            DeleteUserButton.BackColor = Color.White;
        }

        /// <summary>
        /// Запрещает ввод символов в <see cref="FullNameTextBox"/>
        /// </summary>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрещает ввод символов в <see cref="EmailTextBox"/>
        /// </summary>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрещает ввод символов в <see cref="VKTextBox"/>
        /// </summary>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
