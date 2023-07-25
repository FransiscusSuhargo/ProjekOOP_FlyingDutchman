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
    public partial class FormShop : Form
    {
        FormTitleScreen mainForm; 
        public FormShop()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            mainForm = (FormTitleScreen)this.Owner;

            foreach (Toy toy in mainForm.currentUser.ListOfToys)
            {
                {
                    if(toy.Name == "Bola")
                    {
                        pictureBoxBola.Image = Properties.Resources.BolaSold; 
                    }
                    if(toy.Name == "Bulu")
                    {
                        pictureBoxBulu.Image = Properties.Resources.BuluSold ;
                    }    
                    if(toy.Name == "Tikus")
                    {
                        pictureBoxTikus.Image = Properties.Resources.TikusSold ; 
                    }
                }
            }

        }

        private void pictureBoxBola_Click(object sender, EventArgs e)
        {
            if(mainForm.currentUser.Coin >= 500)
            {
                Toy newToy = new Toy("Bola", 20);
                mainForm.currentUser.ListOfToys.Add(newToy);
                pictureBoxBola.Image = Properties.Resources.BolaSold;
                mainForm.currentUser.DeductCoins(500);
            }
        }

        private void pictureBoxBulu_Click(object sender, EventArgs e)
        {
            if (mainForm.currentUser.Coin >= 1000)
            {
                Toy newToy = new Toy("Bulu", 30);
                mainForm.currentUser.ListOfToys.Add(newToy);
                pictureBoxBulu.Image = Properties.Resources.BuluSold;
                mainForm.currentUser.DeductCoins(1000);
            }
        }

        private void pictureBoxTikus_Click(object sender, EventArgs e)
        {
            if (mainForm.currentUser.Coin >= 2000)
            {
                Toy newToy = new Toy("Tikus", 50);
                mainForm.currentUser.ListOfToys.Add(newToy);
                pictureBoxTikus.Image = Properties.Resources.TikusSold;
                mainForm.currentUser.DeductCoins(2000);
            }
        }
    }
}
