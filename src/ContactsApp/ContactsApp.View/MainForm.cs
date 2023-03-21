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
        private Model.Project _project = new Model.Project();

        /// <summary>
        /// Массив полных имен.
        /// </summary>
        private string[] _names = { "никита", "артем", "илья", "мария", "анастасия", "елена" };

        /// <summary>
        /// Массив адресов электронной почты.
        /// </summary>
        private string[] _mails = { 
            "lola2012@gmail.com", 
            "akiraISdead@mail.ru", 
            "bubochka1488@bk.ru", 
            "booker_pooker@gmail.com", 
            "doglover@gmail.com", 
            "pautinka@gmail.com" 
        };

        /// <summary>
        /// Массив номеров телефона.
        /// </summary>
        private string[] _numbers = { 
            "9069778977", 
            "9022278977", 
            "9232211977", 
            "9069772211", 
            "9069771488", 
            "9033378977" 
        };

        /// <summary>
        /// Массив дат рождения.
        /// </summary>
        private DateTime[] _dates = { 
            new DateTime(1980, 02, 12), 
            new DateTime(1956, 12, 27), 
            new DateTime(1976, 05, 14) 
        };

        /// <summary>
        /// Массив уникальных идентификаторов пользователей VK.
        /// </summary>
        private string[] _ids = { 
            "vk.com/locker", 
            "vk.com/chzh", 
            "vk.com/pooker", 
            "vk.com/mikrochel", 
            "vk.com/sadist", 
            "vk.com/maria-ra" 
        };

        /// <summary>
        /// Очищает все элементы ListBox, возвращает обновленный список контактов.
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
        /// Получает объект по индексу из поля _project, заполняет данные 
        /// на правой панели MainForm.
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
        /// Очищает все элементы управления на правой панели MainForm.
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
            Model.Contact user = new Model.Contact();
            user.FullName = _names[new Random().Next(0, _names.Length)];
            user.Email = _mails[new Random().Next(0, _mails.Length)];
            user.PhoneNumber = _numbers[new Random().Next(0, _numbers.Length)];
            user.BirthDate = _dates[new Random().Next(0, _dates.Length)];
            user.VKID = _ids[new Random().Next(0, _ids.Length)];
            _project.Contacts.Add(user);
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
        /// Строит пользовательский интерфейс в MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает форму MainForm.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        /// <summary>
        /// Открывает форму ContactForm и добавляет контакт (пока что без связи с ContactForm).
        /// </summary>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            ContactForm AddContactForm = new ContactForm();
            AddContactForm.Show();
            AddContact();
            UpdateListBox();
        }

        /// <summary>
        /// Открывает форму ContactForm.
        /// </summary>
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            ContactForm EditContactForm = new ContactForm();
            EditContactForm.Show();
        }

        /// <summary>
        /// Вызывает функцию удаления контакта и обновления UsersListBox.
        /// </summary>
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            RemoveContact(UsersListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Открывает форму AboutForm нажатием F1.
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
        /// "Закрывает" уведомление о днях рождения.
        /// </summary>
        private void NotificationCloseButton_Click(object sender, EventArgs e)
        {
            NotificationCloseButton.Visible = false;
            NotificationPanel.Visible = false;
            NotificationBirthLabel.Visible = false;
            NotificationPictureBox.Visible = false;
        }

        /// <summary>
        /// Выводит информацию по выбранному в UsersListBox индексу 
        /// на правую панель MainForm.
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
        /// Вызывает MessageBox при закрытии MainForm.
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
