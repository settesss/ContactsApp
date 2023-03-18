using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.Model
{
    internal class Contact
    {
        private string _fullName;
        private string _email;
        private string _phoneNumber;
        private DateTime _birthDate;
        private string _vkId;

        public Contact() { }

        public string FullName
        {
            get { return _fullName; }
            set 
            {
                if (value.Length <= 100)
                {
                    /*Непроработанный до конца метод, работает только с первой буквой*/
                    value = value[0].ToString().ToUpper() + value.Substring(1);
                    _fullName = value;
                }
                else
                {
                    string exception = "Your name '" + value + "' is too long. " +
                        "Try to enter shorter, please.";
                    throw new ArgumentOutOfRangeException(exception);
                }
            }
        }
        
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
                    throw new ArgumentOutOfRangeException(exception);
                }
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
            }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                DateTime minDate = new DateTime(1900, 01, 01);
                DateTime maxDate = DateTime.Now;
                if (value > minDate && value <= maxDate)
                {
                    _birthDate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The date can't be like this.");
                }
            }
        }

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
                    throw new ArgumentOutOfRangeException(exception);
                }
            }
        }

        public Contact(string name, string phone)
        {
            _fullName = name;
            _phoneNumber = phone;
        }

        public Contact(string name, string mail, string phone, DateTime birth, string vk)
            : this(name, phone)
        {
            _email = mail;
            _birthDate = birth;
            _vkId = vk;
        }
    }
}