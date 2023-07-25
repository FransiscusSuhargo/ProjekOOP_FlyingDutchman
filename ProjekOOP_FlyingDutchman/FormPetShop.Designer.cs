namespace ProjekOOP_FlyingDutchman
{
    partial class FormPetShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxLivingRoom = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxShop = new System.Windows.Forms.PictureBox();
            this.labelCoin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLivingRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLivingRoom
            // 
            this.pictureBoxLivingRoom.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLivingRoom.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Next_2Button;
            this.pictureBoxLivingRoom.Location = new System.Drawing.Point(597, 158);
            this.pictureBoxLivingRoom.Name = "pictureBoxLivingRoom";
            this.pictureBoxLivingRoom.Size = new System.Drawing.Size(80, 67);
            this.pictureBoxLivingRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLivingRoom.TabIndex = 15;
            this.pictureBoxLivingRoom.TabStop = false;
            this.pictureBoxLivingRoom.Click += new System.EventHandler(this.pictureBoxLivingRoom_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMenu.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Menu;
            this.pictureBoxMenu.Location = new System.Drawing.Point(637, 12);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(40, 38);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMenu.TabIndex = 9;
            this.pictureBoxMenu.TabStop = false;
            // 
            // pictureBoxShop
            // 
            this.pictureBoxShop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShop.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.PetShop_Title;
            this.pictureBoxShop.Location = new System.Drawing.Point(257, 48);
            this.pictureBoxShop.Name = "pictureBoxShop";
            this.pictureBoxShop.Size = new System.Drawing.Size(146, 135);
            this.pictureBoxShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShop.TabIndex = 15;
            this.pictureBoxShop.TabStop = false;
            this.pictureBoxShop.Click += new System.EventHandler(this.pictureBoxShop_Click);
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.BackColor = System.Drawing.Color.Transparent;
            this.labelCoin.Font = new System.Drawing.Font("Borsok", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoin.ForeColor = System.Drawing.Color.Snow;
            this.labelCoin.Location = new System.Drawing.Point(504, 17);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(76, 24);
            this.labelCoin.TabIndex = 16;
            this.labelCoin.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekOOP_FlyingDutchman.Properties.Resources.Pet_Shop;
            this.ClientSize = new System.Drawing.Size(688, 387);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.pictureBoxShop);
            this.Controls.Add(this.pictureBoxLivingRoom);
            this.Controls.Add(this.pictureBoxMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPetShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPetShop";
            this.Load += new System.EventHandler(this.FormPetShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLivingRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLivingRoom;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBoxShop;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.Timer timer1;
    }
}