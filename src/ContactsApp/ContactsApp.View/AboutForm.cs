using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ContactsApp.View
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/settesss");
        }

        private void PictureRightsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com");
        }
    }
}
