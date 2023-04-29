namespace ContactsApp.Model
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Описывает валидатор контакта телефонной книги.
    /// </summary>
    internal class ContactValidator
    {
        /// <summary>
        /// Время 01.01.0001.
        /// </summary>
        private DateTime _dateError = new DateTime(0001, 01, 01);

        /// <summary>
        /// Минимальная дата для ввода.
        /// </summary>
        private DateTime _minDate = new DateTime(1900, 01, 01);

        /// <summary>
        /// Максимальная дата для ввода, равная текущей.
        /// </summary>
        private DateTime _maxDate = DateTime.Now;

        /// <summary>
        /// Возвращает булевое значения для корректного ввода <see cref="Contact.FullName"/>.
        /// Длина строки не должна превышать 100 символов.
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool ValidateFullName(ref string fullName, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (fullName.Length > 100)
            {
                errorMessage = $"Your name '{fullName}' is too long. " +
                        $"Try to enter a shorter name, please!";
                return false;
            }
            if (string.IsNullOrEmpty(fullName))
            {
                fullName = "Empty Name";
            }
            return true;
        }

        /// <summary>
        /// Возвращает булевое значения для корректного ввода <see cref="Contact.Email"/>.
        /// Длина строки не должна превышать 100 символов.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool ValidateEmail(string email, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (email.Length > 100)
            {
                errorMessage = $"Your e-mail '{email}' is too long. " +
                        $"Try to enter a shorter e-mail, please!";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Возвращает булевое значения для корректного ввода <see cref="Contact.PhoneNumber"/>.
        /// По шаблону "+7XXXXXXXXXX", "7XXXXXXXXXX" или "+7 (XXX) XXX-XX-XX".
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool ValidatePhoneNumber(string phoneNumber, out string errorMessage)
        {
            errorMessage = string.Empty;
            phoneNumber = 
                new string(phoneNumber.Where(c => char.IsDigit(c) || c == '+').ToArray());
            if (phoneNumber.Length == 11 && phoneNumber.StartsWith("7"))
            {
                return true;
            }
            else if (phoneNumber.Length == 12 && phoneNumber.StartsWith("+7"))
            {
                return true;
            }
            else if (phoneNumber.Length == 11 && phoneNumber.StartsWith("8"))
            {
                return true;
            }
            else if (Regex.IsMatch(phoneNumber, @"^\+7\s\(\d{3}\)\s\d{3}-\d{2}-\d{2}$"))
            {
                return true;
            }
            else
            {
                errorMessage = $"Invalid phone number format '{phoneNumber}'. " +
                    $"The format should be '7XXXXXXXXXX', '+7XXXXXXXXXX', " +
                    $"or '+7 (XXX) XXX-XX-XX'.";
                return false;
            }
        }

        /// <summary>
        /// Возвращает булевое значения для корректного ввода <see cref="Contact.DateOfBirth"/>.
        /// Дата не должна быть меньше 1900.01.01 и больше текущей.
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool ValidateDateOfBirth(ref DateTime dateOfBirth, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (dateOfBirth == _dateError)
            {
                dateOfBirth = _minDate;
            }
            if (dateOfBirth < _minDate || dateOfBirth >= _maxDate)
            {
                errorMessage = $"The entered date " +
                        $"'{dateOfBirth.ToShortDateString()}' " +
                        $"must be less than the current one and more than 1900.01.01!";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Возвращает булевое значения для корректного ввода <see cref="Contact.VKID"/>.
        /// Длина строки не должна превышать 50 символов.
        /// </summary>
        /// <param name="vkId"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool ValidateVkId(string vkId, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (vkId.Length > 50)
            {
                errorMessage = $"Your VK-ID '{vkId}' is too long. " +
                    $"Try to enter a shorter ID, please!";
                return false;
            }
            return true;
        }
    }
}
