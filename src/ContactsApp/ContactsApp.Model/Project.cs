using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int SortContactsByFullName(Contact firstContact, Contact secondContact)
        {
            return firstContact.FullName.CompareTo(secondContact.FullName);
        }

        /// <summary>
        /// Сортирует контакты по подстроке и возвращает отсортированный список.
        /// </summary>
        public List<Contact> FindContactsBySubstring(List<Contact> list, string substring) 
        {
            List<Contact> listBoxSorted = new List<Contact>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FullName.Contains(substring))
                {
                    listBoxSorted.Add(list[i]);
                }
            }
            return listBoxSorted;
        }

        /// <summary>
        /// Ищет контакты людей, у которых сегодня день рождения, и возвращает строку 
        /// с объединенными контактами.
        /// </summary>
        public string FindContactsOfBirthdayPeople(ListBox listBox, List<Contact> contacts)
        {
            string birthdayList = "";
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (contacts[i].BirthDate.Month == DateTime.Today.Month
                    && contacts[i].BirthDate.Day == DateTime.Today.Day)
                {
                    birthdayList += listBox.Items[i].ToString() + "; ";
                }
            }
            return birthdayList;
        }
    }
}
