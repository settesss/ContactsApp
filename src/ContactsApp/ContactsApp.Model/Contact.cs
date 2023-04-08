using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// Возвращает или задает полное имя.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set 
            {
                if (value.Length <= 100)
                {
                    /*Непроработанный до конца метод, работает только с первой буквой*/
                    if (value != "")
                    {
                        value = value[0].ToString().ToUpper() + value.Substring(1);
                        _fullName = value;
                    }
                    else
                    {
                        _fullName = "Empty Name";
                    }
                }
                else
                {
                    string exception = "Your name '" + value + "' is too long. " +
                        "Try to enter shorter, please.";
                    throw new ArgumentException(exception);
                }
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
                if (value.Length <= 100)
                {
                    _email = value;
                }
                else
                {
                    string exception = "E-mail '" + value + "' is too long. " +
                        "Try to enter shorter, please.";
                    throw new ArgumentException(exception);
                }
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает или задает дату рождения.
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                DateTime dateTime = new DateTime(0001, 01, 01);
                DateTime minDate = new DateTime(1900, 01, 01);
                DateTime maxDate = DateTime.Now;
                if (value > minDate && value <= maxDate)
                {
                    _dateOfBirth = value;
                }
                else if (value == dateTime)
                {
                    _dateOfBirth = minDate;
                }
                else
                {
                    throw new ArgumentException("The date can't be like this.");
                }
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
                if (value.Length <= 50)
                {
                    _vkId = value;
                }
                else
                {
                    string exception = "VK-ID '" + value + "' is too long. " +
                        "Try to enter shorter, please.";
                    throw new ArgumentException(exception);
                }
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
        public Contact(string fullName, string email, string phoneNumber, DateTime dateOfBirth, string vkId)
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