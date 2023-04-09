using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает проект.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает или задаёт список контактов.
        /// </summary>
        public List<Contact> Contacts {get; set;} = new List<Contact>();

        /// <summary>
        /// Сортирует контакты по полному имени и возвращает 
        /// расположение одного контакта относительно другого.
        /// </summary>
        /// <param name="firstContact"></param>
        /// <param name="secondContact"></param>
        /// <returns></returns>
        public int SortContactsByFullName(Contact firstContact, Contact secondContact)
        {
            return firstContact.FullName.CompareTo(secondContact.FullName);
        }

        /// <summary>
        /// Сортирует контакты по подстроке и возвращает отсортированный список.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="substring"></param>
        /// <returns></returns>
        public List<Contact> FindContactsBySubstring(List<Contact> list, string substring) 
        {
            return list.Where(contact => contact.FullName.Contains(substring)).ToList();
        }

        /// <summary>
        /// Ищет контакты людей, у которых сегодня день рождения, и возвращает строку 
        /// с объединенными контактами.
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns></returns>
        public string FindContactsOfBirthdayPeople(List<Contact> contacts)
        {
            var birthdayContacts = contacts.Where(c => c.DateOfBirth.Month == DateTime.Now.Month 
            && c.DateOfBirth.Day == DateTime.Now.Day);
            var result = string.Join(", ", birthdayContacts.Select(c => c.FullName));
            return result;
        }
    }
}
