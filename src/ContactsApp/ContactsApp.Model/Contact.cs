using System;
using System.Globalization;
using System.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт телефонной книги.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        private string _email;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Уникальный идентификатор пользователя VK.
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Валидатор.
        /// </summary>
        private ContactValidator _validator = new ContactValidator();

        /// <summary>
        /// Возвращает или задает полное имя.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set 
            {
                string errorMessage;
                bool isValid = _validator.ValidateFullName(ref value, out errorMessage);
                if (!isValid)
                {
                    throw new ArgumentException(errorMessage); 
                }
                var textInfo = CultureInfo.CurrentCulture.TextInfo;
                _fullName = textInfo.ToTitleCase(value);
            }
        }
        
        /// <summary>
        /// Возвращает или задает адрес электронной почты.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                string errorMessage;
                bool isValid = _validator.ValidateEmail(value, out errorMessage);
                if (!isValid)
                {
                    throw new ArgumentException(errorMessage);
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber ?? "70000000000"; }
            set
            {
                string errorMessage;
                bool isValid = _validator.ValidatePhoneNumber(value, out errorMessage);
                if (!isValid)
                {
                    throw new ArgumentException(errorMessage);
                }
                string phoneNumber = new string(value.Where(char.IsDigit).ToArray());
                if (phoneNumber.Length == 10)
                {
                    _phoneNumber = string.Format("+7 ({0}) {1}-{2}-{3}",
                        phoneNumber.Substring(0, 3),
                        phoneNumber.Substring(3, 3),
                        phoneNumber.Substring(6, 2),
                        phoneNumber.Substring(8, 2));
                }
                else if (phoneNumber.Length == 11)
                {
                    _phoneNumber = string.Format("+7 ({0}) {1}-{2}-{3}",
                        phoneNumber.Substring(1, 3),
                        phoneNumber.Substring(4, 3),
                        phoneNumber.Substring(7, 2),
                        phoneNumber.Substring(9, 2));
                }
                else
                {
                    _phoneNumber = "+" + phoneNumber;
                }
            }
        }

        /// <summary>
        /// Возвращает или задает дату рождения.
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                string errorMessage;
                bool isValid = _validator.ValidateDateOfBirth(ref value, out errorMessage);
                if (!isValid)
                {
                    throw new ArgumentException(errorMessage);
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает уникальный идентификатор пользователя VK.
        /// </summary>
        public string VKID
        {
            get { return _vkId; }
            set
            {
                string errorMessage;
                bool isValid = _validator.ValidateVkId(value, out errorMessage);
                if (!isValid)
                {
                    throw new ArgumentException(errorMessage);
                }
                _vkId = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр <see cref="Contact"/>.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Создает экземпляр <see cref="Contact"/>.
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="vkId"></param>
        public Contact(string fullName, string email, string phoneNumber, 
            DateTime dateOfBirth, string vkId)
        {
            _fullName = fullName;
            _email = email;
            _phoneNumber = phoneNumber;
            _dateOfBirth = dateOfBirth;
            _vkId = vkId;
        }

        /// <summary>
        /// Возвращает новый объект, который является копией текущего объекта.
        /// </summary>
        public object Clone()
        {
            return new Contact(_fullName, _email, _phoneNumber, _dateOfBirth, _vkId);
        }
    }
}