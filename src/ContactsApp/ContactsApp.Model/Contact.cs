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
        private string fullName;
        private string email;
        private string phoneNumber;
        private DateTime birthDate;
        private string VKid;

        public Contact() { }

        public string FullName
        {
            get { return fullName; }
            set 
            {
                if (value.Length <= 100)
                {
                    /*Непроработанный до конца метод, работает только с первой буквой*/
                    value = value[0].ToString().ToUpper() + value.Substring(1);
                    fullName = value;
                }
                else
                {
                    string exception = "Your name '" + value + "' is too long. Try to enter shorter, please.";
                    throw new ArgumentOutOfRangeException(exception);
                }
            }
        }
        
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Length <= 100)
                {
                    email = value;
                }
                else
                {
                    string exception = "E-mail '" + value + "' is too long. Try to enter shorter, please.";
                    throw new ArgumentOutOfRangeException(exception);
                }
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                DateTime minDate = new DateTime(1900, 01, 01);
                DateTime maxDate = DateTime.Now;
                if (value > minDate && value <= maxDate)
                {
                    birthDate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The date can't be like this.");
                }
            }
        }

        public string VKID
        {
            get { return VKid; }
            set
            {
                if (value.Length <= 50)
                {
                    VKid = value;
                }
                else
                {
                    string exception = "VK-ID '" + value + "' is too long. Try to enter shorter, please.";
                    throw new ArgumentOutOfRangeException(exception);
                }
            }
        }

        public Contact(string name, string phone)
        {
            fullName = name;
            phoneNumber = phone;
        }

        public Contact(string name, string mail, string phone, DateTime birth, string vk) : this(name, phone)
        {
            email = mail;
            birthDate = birth;
            VKid = vk;
        }

    }
}