using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekOOP_FlyingDutchman
{
    public partial class FormHomeScreen : Form
    {
        FormTitleScreen mainForm;
        Pet currentPet;
        public FormHomeScreen()
        {
            InitializeComponent();
        }

        private void FormHomeScreen_Load(object sender, EventArgs e)
        {
            mainForm = (FormTitleScreen)this.Owner;
            currentPet = mainForm.currentUser.Pet;
            labelPetName.Text = currentPet.Name;
            UpdateCoin();
            UpdateDisplayBar();
            if (currentPet is Cat)
            {
                Cat petCat = (Cat)currentPet;
                pictureBoxPet.Image = Properties.Resources.Kucing_Netral;
                pictureBoxPet.Location = new Point(286, 172);
                pictureBoxPetFood.Image = Properties.Resources.CatFood_Normal_;
                pictureBoxDrawer.Enabled = true;
                pictureBoxLamp.Enabled = true;
            }
            else if(currentPet is Fish)
            {
                Fish petFish = (Fish)currentPet;
                pictureBoxPet.Image = Properties.Resources.AkuariumIkan_2;
                pictureBoxPet.Location = new Point(290, 138);
                pictureBoxPetFood.Image = Properties.Resources.FoodBag_Ikan;
                pictureBoxDrawer.Enabled = false;
                pictureBoxLamp.Enabled = false; 
            }
            else if(currentPet is Chameleon)
            {
                Chameleon petChameleon = (Chameleon)currentPet;
            }
        }

        public void UpdateDisplayBar()
        {
            int health = currentPet.Health;
            int energy = currentPet.Energy;
            int happiness = currentPet.Happiness;

            healthBar.Width = (int)((health / 100.0) * 118);
            energyBar.Width = (int)((energy / 100.0) * 118);
            happinessBar.Width = (int)((happiness / 100.0) * 118);
        }

        public void UpdateCoin()
        {
            labelCoin.Text = mainForm.currentUser.Coin.ToString(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string health;
            string energy;
            string happiness;
            currentPet.ReduceStatusOvertime();
            UpdateDisplayBar();
            UpdateCoin();
            currentPet.CheckingStatus(out health, out energy, out happiness);
            if (health == "Very Poor" && energy == "Weak" && happiness == "Unhappy")
            {
                MessageBox.Show("Health : " + health + " Energy : " + energy + " Happiness : " + happiness);
                timer1.Stop();
            }
        }

        private async void pictureBoxPetFood_Click(object sender, EventArgs e)
        {
            mainForm.currentUser.AddCoins(currentPet.Feed());
            if (currentPet is Cat)
            {
                Cat petCat = (Cat)currentPet;
                mainForm.currentUser.AddCoins(petCat.Feed());
                Image prevImage = pictureBoxPet.Image;
                pictureBoxPet.Image = Properties.Resources.Kucing_Makan;
                await Task.Delay(2000);
                pictureBoxPet.Image = prevImage;
            }
            else if (currentPet is Fish)
            {
                Fish petFish = (Fish)currentPet;
            }
            else if (currentPet is Chameleon)
            {
                Chameleon petChameleon = (Chameleon)currentPet;
            }
        }

        private async void pictureBoxLamp_Click(object sender, EventArgs e)
        {
            Cat petCat = (Cat)currentPet;
            mainForm.currentUser.AddCoins(petCat.Sleep());
            Image prevImage = pictureBoxPet.Image;
            pictureBoxPet.Image = Properties.Resources.Kucing_Tidur;
            await Task.Delay(2000);
            pictureBoxPet.Image = prevImage;
        }

        private void pictureBoxBathroom_Click(object sender, EventArgs e)
        {
            FormBathroom newForm = new FormBathroom();
            newForm.Owner = mainForm;
            newForm.ShowDialog();
            this.Close();
        }

        private void pictureBoxPetShop_Click(object sender, EventArgs e)
        {
            FormPetShop newForm = new FormPetShop();
            newForm.Owner = mainForm;
            newForm.ShowDialog();
            this.Close();
        }

        private void pictureBoxDrawer_Click(object sender, EventArgs e)
        {
            FormInventory newForm = new FormInventory();
            newForm.Owner = mainForm;
            newForm.ShowDialog();
        }
    }
}
