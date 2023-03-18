using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        public ContactForm(/*ListBox listBox*/)
        {
            InitializeComponent();
            /*this.listBox = listBox;*/
        }
        /*Создание поля типа ListBox для передачи в него информации о новом пользователе*/

        /*ListBox listBox;*/

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            /*Добавление в список и вывод на MainForm*/

            /*Model.Contact user = new Model.Contact();
            Project list = new Project();
            user.FullName = FullNameTextBox.Text;
            user.Email = EmailTextBox.Text;
            user.PhoneNumber = PhoneMaskedTextBox.Text;
            user.BirthDate = BirthDateDateTimePicker.Value;
            user.VKID = VKTextBox.Text;
            list.contacts.Add(user);
            listBox.Items.Add(user.FullName);*/

            Close();
        }
    }
}
