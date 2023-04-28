namespace ContactsApp.View
{
    using System;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using ContactsApp.Model;

    /// <summary>
    /// Описывает форму контакта.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Контакт.
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// Возвращает контакт.
        /// </summary>
        public Contact Contact { get { return _contact; }  set { _contact = value; } }

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
        /// Текст ошибки ввода в <see cref="DateOfBirthMaskedTextBox"/>.
        /// </summary>
        private string _birthDateError;

        /// <summary>
        /// Текст ошибки ввода в <see cref="VKTextBox"/>.
        /// </summary>
        private string _vkIdError;

        /// <summary>
        /// Строит пользовательский интерфейс <see cref="ContactForm"/>
        /// с переданными в него данными <see cref="Contact"/>.
        /// </summary>
        /// <param name="contact"></param>
        public ContactForm(Contact contact = null)
        {
            InitializeComponent();
            _contact = contact ?? new Contact();
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
            PhoneTextBox.Text = _contact.PhoneNumber;
            DateOfBirthMaskedTextBox.Text = _contact.DateOfBirth.ToString("yyyy.MM.dd");
            VKTextBox.Text = _contact.VKID;
        }

        /// <summary>
        /// Проверяет форму на все возможные ошибки.
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            var errors = new StringBuilder();
            if (!string.IsNullOrEmpty(_fullNameError))
            {
                errors.AppendLine($"- {_fullNameError}\n");
            }
            if (!string.IsNullOrEmpty(_emailError))
            {
                errors.AppendLine($"- {_emailError}\n");
            }
            if (!string.IsNullOrEmpty(_phoneNumberError))
            {
                errors.AppendLine($"- {_phoneNumberError}\n");
            }
            if (!string.IsNullOrEmpty(_birthDateError))
            {
                errors.AppendLine($"- {_birthDateError}\n");
            }
            if (!string.IsNullOrEmpty(_vkIdError))
            {
                errors.AppendLine($"- {_vkIdError}\n");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show("Обнаружены ошибки:\n\n" + errors.ToString());
                return false;
            }
            return true;
        }
 
        /// <summary>
        /// Обновляет данные в объекте <see cref="_contact"/>.
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneTextBox.Text;
            _contact.DateOfBirth = 
                DateTime.ParseExact(DateOfBirthMaskedTextBox.Text, "yyyy.M.dd", null); 
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
                FullNameTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
            }
            catch (Exception exception)
            {
                _fullNameError = exception.Message;
                FullNameTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.ErrorLight);
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
                EmailTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
            }
            catch (Exception exception)
            {
                _emailError = exception.Message;
                EmailTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.ErrorLight);
            }
        }

        /// <summary>
        /// Обрабатывает введённые данные в <see cref="PhoneTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                _contact.PhoneNumber = PhoneTextBox.Text;
                _phoneNumberError = null;
                PhoneTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
            }
            catch (Exception exception)
            {
                _phoneNumberError = exception.Message;
                PhoneTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.ErrorLight);
            }
        }

        /// <summary>
        /// Обрабатывает введённые данные в <see cref="DateOfBirthMaskedTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateOfBirthMaskedTextBox.MaskCompleted)
                {
                    _contact.DateOfBirth =
                        DateTime.ParseExact(DateOfBirthMaskedTextBox.Text, "yyyy.M.dd", null);
                    _birthDateError = null;
                    DateOfBirthMaskedTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
                }
                else
                {
                    throw new Exception("Birth date is not fully entered");
                }
            }
            catch (Exception exception)
            {
                _birthDateError = exception.Message;
                DateOfBirthMaskedTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.ErrorLight);
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
                VKTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
            }
            catch (Exception exception)
            {
                _vkIdError = exception.Message;
                VKTextBox.BackColor = ColorTranslator.FromHtml(ColorCodes.ErrorLight);
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
            AddPhotoButton.BackColor = ColorTranslator.FromHtml(ColorCodes.White);
        }
    }
}
