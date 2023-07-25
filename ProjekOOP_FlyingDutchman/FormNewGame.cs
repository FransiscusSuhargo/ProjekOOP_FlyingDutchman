using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekOOP_FlyingDutchman
{
    public partial class FormNewGame : Form
    {
        FormTitleScreen mainForm; 
        public FormNewGame()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            string ownerName = textBoxName.Text;
            string petName = textBoxPetName.Text;
            User newOwner; 
            if(radioButtonCat.Checked)
            {
                Pet newPet = new Cat(petName, ownerName);
                newOwner = new User(ownerName, newPet);
                mainForm.listOfUser.Add(newOwner);
                mainForm.currentUser = newOwner;
            }
            else if(radioButtonIkan.Checked)
            {
                Pet newPet = new Fish(petName, ownerName);
                newOwner = new User(ownerName, newPet);
                mainForm.listOfUser.Add(newOwner);
                mainForm.currentUser = newOwner;
            }
            else if(radioButtonBunglon.Checked)
            {
                Pet newPet = new Chameleon(petName, ownerName);
                newOwner = new User(ownerName, newPet);
                mainForm.listOfUser.Add(newOwner);
                mainForm.currentUser = newOwner;
            }
            FormHomeScreen newHome = new FormHomeScreen();
            newHome.Owner = mainForm;
            newHome.Show();
            this.Close();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewGame_Load(object sender, EventArgs e)
        {
            mainForm = (FormTitleScreen)this.Owner; 
        }
    }
}
