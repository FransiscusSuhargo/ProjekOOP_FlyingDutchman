namespace ProjekOOP_FlyingDutchman
{
    partial class FormShop
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBola = new System.Windows.Forms.PictureBox();
            this.pictureBoxBulu = new System.Windows.Forms.PictureBox();
            this.pictureBoxTikus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBulu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTikus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.X;
            this.pictureBox1.Location = new System.Drawing.Point(240, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxBola
            // 
            this.pictureBoxBola.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBola.ErrorImage = global::ProjekOOP_FlyingDutchman.Properties.Resources.BolaSold;
            this.pictureBoxBola.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Toy1;
            this.pictureBoxBola.Location = new System.Drawing.Point(12, 99);
            this.pictureBoxBola.Name = "pictureBoxBola";
            this.pictureBoxBola.Size = new System.Drawing.Size(89, 125);
            this.pictureBoxBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBola.TabIndex = 0;
            this.pictureBoxBola.TabStop = false;
            this.pictureBoxBola.Click += new System.EventHandler(this.pictureBoxBola_Click);
            // 
            // pictureBoxBulu
            // 
            this.pictureBoxBulu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBulu.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Toy2;
            this.pictureBoxBulu.Location = new System.Drawing.Point(107, 99);
            this.pictureBoxBulu.Name = "pictureBoxBulu";
            this.pictureBoxBulu.Size = new System.Drawing.Size(89, 125);
            this.pictureBoxBulu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBulu.TabIndex = 0;
            this.pictureBoxBulu.TabStop = false;
            this.pictureBoxBulu.Click += new System.EventHandler(this.pictureBoxBulu_Click);
            // 
            // pictureBoxTikus
            // 
            this.pictureBoxTikus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTikus.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Toy3;
            this.pictureBoxTikus.Location = new System.Drawing.Point(202, 99);
            this.pictureBoxTikus.Name = "pictureBoxTikus";
            this.pictureBoxTikus.Size = new System.Drawing.Size(89, 122);
            this.pictureBoxTikus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTikus.TabIndex = 0;
            this.pictureBoxTikus.TabStop = false;
            this.pictureBoxTikus.Click += new System.EventHandler(this.pictureBoxTikus_Click);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekOOP_FlyingDutchman.Properties.Resources.Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 299);
            this.Controls.Add(this.pictureBoxTikus);
            this.Controls.Add(this.pictureBoxBulu);
            this.Controls.Add(this.pictureBoxBola);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBulu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTikus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxBola;
        private System.Windows.Forms.PictureBox pictureBoxBulu;
        private System.Windows.Forms.PictureBox pictureBoxTikus;
    }
}