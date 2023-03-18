using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.Model
{
    internal class Project
    {
        private List<Model.Contact> _contacts;

        public Project()
        {
            _contacts = new List<Model.Contact>();
        }

        public List<Model.Contact> Contacts { get { return _contacts; } }

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

        public string GetContactsOfBirthdayPeople(ListBox listBox, List<Model.Contact> contacts)
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
