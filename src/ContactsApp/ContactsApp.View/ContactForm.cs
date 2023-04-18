using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает форму контакта.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Контакт.
        /// </summary>
        private Model.Contact _contact = new Model.Contact();

        /// <summary>
        /// Возвращает контакт.
        /// </summary>
        public Model.Contact Contact { get; set; }

        /// <summary>
        /// Текст ошибки ввода в <see cref="FullNameTextBox"/>.
        /// </summary>
        private string _fullNameError;

        /// <summary>
        /// Текст ошибки ввода в <see cref="EmailTextBox"/>.
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Текст ошибки ввода в <see cref="PhoneMaskedTextBox"/>.
        /// </summary>
        private string _phoneNumberError;

        /// <summary>
        /// Текст ошибки ввода в <see cref="BirthDateMaskedTextBox"/>.
        /// </summary>
        private string _birthDateError;

        /// <summary>
        /// Текст ошибки ввода в <see cref="VKTextBox"/>.
        /// </summary>
        private string _vkIdError;

        /// <summary>
        /// Строит пользовательский интерфейс <see cref="ContactForm"/>.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        /// <summary>
        /// Берёт данные из поля контакта, выводит их в соответствующие поля 
        /// <see cref="ContactForm"/>.
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneMaskedTextBox.Text = _contact.PhoneNumber;
            BirthDateMaskedTextBox.Text = _contact.DateOfBirth.ToString();
            VKTextBox.Text = _contact.VKID;
        }

        /// <summary>
        /// Проверяет форму на все возможные ошибки.
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            List<string> errorsList = new List<string>() 
            {
                _fullNameError,
                _emailError,
                _phoneNumberError,
                _birthDateError,
                _vkIdError
            };
            var mixedError = string.Join("\n", errorsList.Where(c => c != null));
            if (string.IsNullOrEmpty(mixedError))
            {
                return true;
            }
            else
            {
                MessageBox.Show(mixedError);
                return false;
            }
        }
 
        /// <summary>
        /// Обновляет данные в объекте <see cref="_contact"/>.
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneMaskedTextBox.Text;
            _contact.DateOfBirth = 
                DateTime.ParseExact(BirthDateMaskedTextBox.Text, "M.dd.yyyy", null); 
            _contact.VKID = VKTextBox.Text;
        }

        /// <summary>
        /// Закрывает форму при нажатии на кнопку, не сохраняет изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Сохраняет контакт при нажатии на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors() == true)
            {
                DialogResult = DialogResult.OK;
                UpdateContact();
                Close();
            }
        }

        /// <summary>
        /// Обрабатывает введённые данные в <see cref="FullNameTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                _fullNameError = null;
                FullNameTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
            }
            catch (Exception exception)
            {
                _fullNameError = exception.Message;
                FullNameTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.lightPink);
            }
        }

        /// <summary>
        /// Обрабатывает введённые данные в <see cref="EmailTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                _emailError = null;
                EmailTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
            }
            catch (Exception exception)
            {
                _emailError = exception.Message;
                EmailTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.lightPink);
            }
        }

        /// <summary>
        /// Обрабатывает введённые данные в <see cref="PhoneMaskedTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PhoneMaskedTextBox.MaskCompleted)
                {
                    _contact.PhoneNumber = PhoneMaskedTextBox.Text;
                    _phoneNumberError = null;
                    PhoneMaskedTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
                }
            }
            catch (Exception exception)
            {
                _phoneNumberError = exception.Message;
                PhoneMaskedTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.lightPink);
            }
        }

        /// <summary>
        /// Обрабатывает введённые данные в <see cref="BirthDateMaskedTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthDateMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BirthDateMaskedTextBox.MaskCompleted)
                {
                    _contact.DateOfBirth = 
                        DateTime.ParseExact(BirthDateMaskedTextBox.Text, "M.dd.yyyy", null);
                    _birthDateError = null;
                    BirthDateMaskedTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
                }
            }
            catch (Exception exception)
            {
                _birthDateError = exception.Message;
                BirthDateMaskedTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.lightPink);
            }
        }

        /// <summary>
        /// Обрабатывает введённые данные в <see cref="VKTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VKID = VKTextBox.Text;
                _vkIdError = null;
                VKTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
            }
            catch (Exception exception)
            {
                _vkIdError = exception.Message;
                VKTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.lightPink);
            }
        }

        /// <summary>
        /// Обрабатывает наведение на кнопку <see cref="AddPhotoButton"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
            AddPhotoButton.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Обрабатывает событие при сведении мыши с <see cref="AddPhotoButton"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.BackColor = ColorTranslator.FromHtml(ColorCodes.white);
        }
    }
}
