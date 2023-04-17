using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает форму описания приложения.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Строит пользовательский интерфейс <see cref="AboutForm"/>.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переходит по ссылке на Github.
        /// </summary>
        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/settesss");
        }
        
        /// <summary>
        /// Переходит по ссылке на Icons8.
        /// </summary>
        private void PictureRightsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com");
        }

        /// <summary>
        /// Закрывает форму при нажатии на Esc.
        /// </summary>
        private void AboutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /// <summary>
        /// Закрывает форму при нажатии на <see cref="OKButton"/>.
        /// </summary>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
