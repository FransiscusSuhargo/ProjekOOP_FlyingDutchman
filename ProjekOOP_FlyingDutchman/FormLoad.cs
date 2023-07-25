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
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            FormTitleScreen owner = (FormTitleScreen)this.Owner;
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
