using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekOOP_FlyingDutchman
{
    public partial class FormTitleScreen : Form
    {
        public List<User> listOfUser = new List<User>();
        public User currentUser;

        public FormTitleScreen()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormLoad newForm = new FormLoad();
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormNewGame newForm = new FormNewGame();
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private void FormTitleScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
