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
    public partial class FormPetShop : Form
    {
        FormTitleScreen mainForm;
        public FormPetShop()
        {
            InitializeComponent();
        }

        private void FormPetShop_Load(object sender, EventArgs e)
        {
            mainForm = (FormTitleScreen)this.Owner;
            UpdateCoin();
        }
        public void UpdateCoin()
        {
            labelCoin.Text = mainForm.currentUser.Coin.ToString();
        }

        private void pictureBoxShop_Click(object sender, EventArgs e)
        {
            FormShop newForm = new FormShop();
            newForm.Owner = mainForm;
            newForm.ShowDialog();
        }

        private void pictureBoxLivingRoom_Click(object sender, EventArgs e)
        {
            FormHomeScreen newForm = new FormHomeScreen();
            newForm.Owner = mainForm;
            newForm.Show();
            this.Close(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCoin();
        }
    }
}
