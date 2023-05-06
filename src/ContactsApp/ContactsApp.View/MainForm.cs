namespace ContactsApp.View
{
    using ContactsApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

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
        /// Сериализатор.
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();

        /// <summary>
        /// Строит пользовательский интерфейс <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            _project = _projectSerializer.LoadFromFile();
            InitializeComponent();

            _currentContacts = 
                _project.FindContactsBySubstring(_project.Contacts, FindTextBox.Text);
            UpdateListBox();
        }

        /// <summary>
        /// Сохраняет данные в указанный файл.
        /// </summary>
        private void SaveContactsToFile()
        {
            try
            {
                _projectSerializer.SaveToFile(_project);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save project: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Очищает все элементы <see cref="UsersListBox"/>, возвращает 
        /// обновленный список контактов.
        /// </summary>
        /// <returns></returns>
        private ListBox UpdateListBox()
        {
            _currentContacts.Sort(_project.SortContactsByFullName);
            UsersListBox.Items.Clear();
            UsersListBox.Items.AddRange(_currentContacts.Select(c => c.FullName).ToArray());
            if (NotificationPanel.Visible == true)
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
            var contact = _currentContacts[index];
            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneTextBox.Text = contact.PhoneNumber;
            BirthDateMaskedTextBox.Text = contact.DateOfBirth.ToString("yyyy.MM.dd");
            VKTextBox.Text = contact.VKID;
        }

        /// <summary>
        /// Очищает все элементы управления на правой панели <see cref="MainForm"/>.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Clear();
            EmailTextBox.Clear();
            PhoneTextBox.Clear();
            BirthDateMaskedTextBox.Clear();
            VKTextBox.Clear();
        }

        /// <summary>
        /// Открывает <see cref="ContactForm"/> для редактирования контакта.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="contacts"></param>
        private void EditContact(int index)
        {
            var form = new ContactForm(_currentContacts[index]);
            Contact contactToEdit;
            contactToEdit = (Contact)_currentContacts[index].Clone();
            form.Contact = contactToEdit;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Contact editedContact = form.Contact;
                int contactIndex = _project.Contacts.FindIndex(c => c == _currentContacts[index]);
                _project.Contacts[contactIndex] = editedContact;
                UsersListBox.Items[index] = editedContact.FullName;
                _currentContacts[index] = editedContact;
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
            var resultRemove = MessageBox.Show("Do you really want to remove "
                + _currentContacts[index].FullName + "?",
                "Deletion message:", MessageBoxButtons.OKCancel);
            if (resultRemove != DialogResult.OK)
            {
                return;
            }
            _project.Contacts.Remove(_currentContacts[index]);
            _currentContacts.RemoveAt(index);
        }

        /// <summary>
        /// Открывает форму <see cref="ContactForm"/> и добавляет контакт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var AddContactForm = new ContactForm();
            AddContactForm.ShowDialog();
            var contact = _project.Contacts;
            if (AddContactForm.DialogResult == DialogResult.OK)
            {
                Contact newContact = AddContactForm.Contact;
                contact.Add(newContact);
                _currentContacts.Add(newContact);
                UpdateListBox();
            }
            SaveContactsToFile();
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
            EditContact(selectedIndex);
            UpdateListBox();
            SaveContactsToFile();
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
            SaveContactsToFile();
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
            SaveContactsToFile();
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
            _currentContacts = _project.FindContactsBySubstring(_project.Contacts,
                FindTextBox.Text);
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
            AddUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.AccentBlueBackground);
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="AddUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_MouseLeave(object sender, EventArgs e)
        {
            AddUserButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="EditUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserButton_MouseEnter(object sender, EventArgs e)
        {
            EditUserButton.Image = Properties.Resources.edit_contact_32x32;
            EditUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.AccentBlueBackground);
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="EditUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserButton_MouseLeave(object sender, EventArgs e)
        {
            EditUserButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="RemoveUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveUserButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveUserButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.AccentRedBackground);
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="RemoveUserButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveUserButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveUserButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveUserButton.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
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
        /// Запрещает ввод символов в <see cref="PhoneTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
