namespace ContactsApp.View
{
    using System;

    /// <summary>
    /// Описывает генерацию данных.
    /// </summary>
    static internal class ContactFactory 
    {
        /// <summary>
        /// Массив полных имен.
        /// </summary>
        static string[] _names = { "никита", "артем", "илья", "мария", "анастасия", "елена" };

        /// <summary>
        /// Массив адресов электронной почты.
        /// </summary>
        static string[] _mails = {
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
        static string[] _numbers = {
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
        static DateTime[] _dates = {
            new DateTime(1980, 02, 12),
            new DateTime(1956, 12, 27),
            new DateTime(1976, 05, 14)
        };

        /// <summary>
        /// Массив уникальных идентификаторов пользователей VK.
        /// </summary>
        static string[] _ids = {
            "vk.com/locker",
            "vk.com/chzh",
            "vk.com/pooker",
            "vk.com/mikrochel",
            "vk.com/sadist",
            "vk.com/maria-ra"
        };

        /// <summary>
        /// Использует программную генерацию данных.
        /// </summary>
        /// <param name="user"></param>
        public static void GenerateRandom(Model.Contact user)
        {
            user.FullName = _names[new Random().Next(0, _names.Length)];
            user.Email = _mails[new Random().Next(0, _mails.Length)];
            user.PhoneNumber = _numbers[new Random().Next(0, _numbers.Length)];
            user.DateOfBirth = _dates[new Random().Next(0, _dates.Length)];
            user.VKID = _ids[new Random().Next(0, _ids.Length)];
        }
    }
}
