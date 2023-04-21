using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        /// <returns></returns>
        private ListBox UpdateListBox()
        {
            UsersListBox.Items.Clear();
            UsersListBox.Items.AddRange(FindTextBox.Text == "" ? 
                _project.Contacts.Select(c => c.FullName).ToArray() : 
                _currentContacts.Select(c => c.FullName).ToArray());
            if (notificationClose == false)
            {
                var birthdayUsers = _project.FindContactsOfBirthdayPeople(_project.Contacts);
                BirthdayUsersLabel.Text = birthdayUsers;
            }
            return UsersListBox;
        }

        /// <summary>
        /// Получает объект по индексу из поля <see cref="_project"/>, заполняет данные 
        /// на правой панели <see cref="MainForm"/>.
        /// </summary>
        /// <param name="index"></param>
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
        /// <param name="index"></param>
        /// <param name="contacts"></param>
        private void EditContact(int index, List<Contact> contacts)
        {
            var form = new ContactForm();
            Contact contactToEdit;
            contactToEdit = (Contact)contacts[index].Clone();
            form.Contact = contactToEdit;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Contact editedContact = form.Contact;
                int contactIndex = _project.Contacts.FindIndex(c => c == contacts[index]);
                _project.Contacts[contactIndex] = editedContact;
                UsersListBox.Items[index] = editedContact.FullName;
                contacts[index] = editedContact;
            }
        }

        /// <summary>
        /// Удаляет объект контакта, вызывает форму подтверждения.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                return;
            }
            else
            {
                var resultRemove = MessageBox.Show("Do you really want to remove "
                + _project.Contacts[index].FullName + "?",
                "Deletion message:", MessageBoxButtons.OKCancel);
                if (resultRemove != DialogResult.OK)
                {
                    return;
                }
                if (FindTextBox.Text == "")
                {
                    _project.Contacts.RemoveAt(index);
                }
                else
                {
                    var contactIndex =
                        _project.Contacts.FindIndex(c => c == _currentContacts[index]);
                    if (contactIndex >= 0)
                    {
                        _project.Contacts.RemoveAt(contactIndex);
                        _currentContacts.RemoveAt(index);
                    }
                }
            }
        }

        /// <summary>
        /// Открывает форму <see cref="ContactForm"/> и добавляет контакт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            ContactForm AddContactForm = new ContactForm();
            AddContactForm.ShowDialog();
            var contact = _project.Contacts;
            if (AddContactForm.DialogResult == DialogResult.OK)
            {
                contact.Add(AddContactForm.Contact);
                contact.Sort(_project.SortContactsByFullName);
                UpdateListBox();
            }
        }

        /// <summary>
        /// Открывает форму <see cref="ContactForm"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = UsersListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }
            var contacts = (FindTextBox.Text == "") ? _project.Contacts : _currentContacts;
            EditContact(selectedIndex, contacts);
            UpdateListBox();
        }

        /// <summary>
        /// Вызывает функцию удаления контакта и обновления <see cref="UsersListBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            RemoveContact(UsersListBox.SelectedIndex);
            UpdateListBox();
            ClearSelectedContact();
        }

        /// <summary>
        /// Открывает форму <see cref="AboutForm"/> нажатием F1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationCloseButton_Click(object sender, EventArgs e)
        {
            notificationClose = true;
            NotificationPanel.Visible = false;
        }

        /// <summary>
        /// Выводит информацию по выбранному в <see cref="UsersListBox"/> индексу
        /// на правую панель <see cref="MainForm"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = UsersListBox.SelectedIndex;
            if (selectedIndex != -1) 
            {
                UpdateSelectedContact(selectedIndex);
            }
            else
            {
                ClearSelectedContact();
            }
        }

        /// <summary>
        /// Вызывает MessageBox при закрытии <see cref="MainForm"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to close the program?",
                "Exit Message:", MessageBoxButtons.YesNo);
            e.Cancel = (result == DialogResult.No);
        }

        /// <summary>
        /// Обрабатывает введённый текст в <see cref="FindTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentContacts = (FindTextBox.Text == "") ? _project.Contacts : 
                _project.FindContactsBySubstring(_project.Contacts, FindTextBox.Text);
            UpdateListBox();
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="AddUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_MouseEnter(object sender, EventArgs e)
        {
            AddUserButton.Image = Properties.Resources.add_contact_32x32;
            AddUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.accentBlueBackground);
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="AddUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_MouseLeave(object sender, EventArgs e)
        {
            AddUserButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="EditUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserButton_MouseEnter(object sender, EventArgs e)
        {
            EditUserButton.Image = Properties.Resources.edit_contact_32x32;
            EditUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.accentBlueBackground);
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="EditUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserButton_MouseLeave(object sender, EventArgs e)
        {
            EditUserButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="RemoveUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveUserButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveUserButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.accentRedBackground);
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="RemoveUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveUserButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveUserButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
        }

        /// <summary>
        /// Запрещает ввод символов в <see cref="FullNameTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрещает ввод символов в <see cref="EmailTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрещает ввод символов в <see cref="VKTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
