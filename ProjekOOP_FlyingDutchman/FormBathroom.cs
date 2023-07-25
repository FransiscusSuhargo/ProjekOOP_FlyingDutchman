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
    public partial class FormBathroom : Form
    {
        FormTitleScreen mainForm;
        Pet currentPet; 
        public FormBathroom()
        {
            InitializeComponent();
        }

        private void FormBathroom_Load(object sender, EventArgs e)
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string health;
            string energy;
            string happiness;
            currentPet.ReduceStatusOvertime();
            UpdateDisplayBar();
            UpdateCoin();
            currentPet.CheckingStatus(out health,out energy,out happiness);
            if(health == "Very Poor" && energy == "Weak" && happiness == "Unhappy")
            {
                MessageBox.Show("Health : " + health + " Energy : " + energy + " Happiness : " + happiness);
                timer1.Stop();
            }
        }

        private async void vaccine_Click(object sender, EventArgs e)
        {
            if(mainForm.currentUser.Coin >= 1000)
            {
                if(currentPet is Cat)
                {
                    Cat petCat = (Cat)currentPet;
                    if(petCat.Vaccinated == false)
                    {
                        mainForm.currentUser.AddCoins(petCat.Vaccinate());
                        Image prevImage = pictureBoxPet.Image;
                        pictureBoxPet.Image = Properties.Resources.Kucing_Vaksin;
                        await Task.Delay(2000);
                        pictureBoxPet.Image = prevImage;
                        mainForm.currentUser.DeductCoins(1000);
                    }
                }
            }
        }
        private async void pictureBoxBath_Click(object sender, EventArgs e)
        {
            if(currentPet is Cat)
            {
                Cat petCat = (Cat)currentPet;
                mainForm.currentUser.AddCoins(petCat.Bath());
                pictureBoxBath.Visible = false;
                pictureBoxPet.Visible = false;
                this.BackgroundImage = Properties.Resources.Kucing_Mandi;
                await Task.Delay(2000);
                pictureBoxBath.Visible = true;
                pictureBoxPet.Visible = true;
                this.BackgroundImage = Properties.Resources.BackgroundBathroom2;
            }
        }

        private void pictureBoxLivingRoom_Click(object sender, EventArgs e)
        {
            FormHomeScreen newForm = new FormHomeScreen();
            newForm.Owner = mainForm;
            newForm.Show();
            this.Close(); 
        }
    }
}
