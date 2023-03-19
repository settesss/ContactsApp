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
    internal class Project
    {
        /// <summary>
        /// Возвращает или задаёт список контактов.
        /// </summary>
        public List<Model.Contact> Contacts {get; set;} = new List<Model.Contact>();

        /// <summary>
        /// Сортирует контакты по полному имени и возвращает отсортированный список.
        /// </summary>
        public ListBox SortContactsByFullName(ListBox listBox, string contactName)
        {
            ListBox listBoxSorted = new ListBox();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].ToString() == contactName)
                {
                    listBoxSorted.Items.Add(listBox.Items[i]);
                }
            }
            return listBoxSorted;
        }

        /// <summary>
        /// Сортирует контакты по подстроке и возвращает отсортированный список.
        /// </summary>
        public ListBox SortContactsBySubstring(ListBox listBox, string substring) 
        { 
            ListBox listBoxSorted = new ListBox();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].ToString().Contains(substring))
                {
                    listBoxSorted.Items.Add(listBox.Items[i]);
                }
            }
            return listBoxSorted;
        }

        /// <summary>
        /// Ищет контакты людей, у которых сегодня день рождения, и возвращает строку 
        /// с объединенными контактами.
        /// </summary>
        public string FindContactsOfBirthdayPeople(ListBox listBox, List<Model.Contact> contacts)
        {
            string birthdayList = "";
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (contacts[i].BirthDate == DateTime.Today)
                {
                    birthdayList += listBox.Items[i].ToString() + "; ";
                }
            }
            return birthdayList;
        }
    }
}
