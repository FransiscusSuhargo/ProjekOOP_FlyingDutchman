using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekOOP_FlyingDutchman
{
    public partial class FormInventory : Form
    {
        FormTitleScreen mainForm; 
        public FormInventory()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxBola_Click(object sender, EventArgs e)
        {
            if(mainForm.currentUser.Pet is Cat)
            {
                Cat petCat = (Cat)mainForm.currentUser.Pet;
                Toy newToy = new Toy("Bola", 20);
                mainForm.currentUser.AddCoins(petCat.Play(newToy));
            }
        }

        private void pictureBoxBulu_Click(object sender, EventArgs e)
        {
            if(mainForm.currentUser.Pet is Cat)
            {
                Cat petCat = (Cat)mainForm.currentUser.Pet;
                Toy newToy = new Toy("Bulu", 30);
                mainForm.currentUser.AddCoins(petCat.Play(newToy));
            }
        }

        private void pictureBoxTikus_Click(object sender, EventArgs e)
        {
            if (mainForm.currentUser.Pet is Cat)
            {
                Cat petCat = (Cat)mainForm.currentUser.Pet;
                Toy newToy = new Toy("Tikus", 50);
                mainForm.currentUser.AddCoins(petCat.Play(newToy));
            }
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            mainForm = (FormTitleScreen)this.Owner;
            pictureBoxBola.Visible = false;
            pictureBoxBulu.Visible = false;
            pictureBoxTikus.Visible = false;

            foreach (Toy toy in mainForm.currentUser.ListOfToys)
            {
                {
                    if (toy.Name == "Bola")
                    {
                        pictureBoxBola.Visible = true;
                    }
                    if (toy.Name == "Bulu")
                    {
                        pictureBoxBulu.Visible = true;
                    }
                    if (toy.Name == "Tikus")
                    {
                        pictureBoxTikus.Visible = true;
                    }
                }
            }
        }
    }
}
