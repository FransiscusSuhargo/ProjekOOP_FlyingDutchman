namespace ProjekOOP_FlyingDutchman
{
    partial class FormInventory
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
            this.pictureBoxTikus = new System.Windows.Forms.PictureBox();
            this.pictureBoxBulu = new System.Windows.Forms.PictureBox();
            this.pictureBoxBola = new System.Windows.Forms.PictureBox();
            this.X = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTikus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBulu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTikus
            // 
            this.pictureBoxTikus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTikus.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Tikus;
            this.pictureBoxTikus.Location = new System.Drawing.Point(204, 113);
            this.pictureBoxTikus.Name = "pictureBoxTikus";
            this.pictureBoxTikus.Size = new System.Drawing.Size(89, 84);
            this.pictureBoxTikus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTikus.TabIndex = 1;
            this.pictureBoxTikus.TabStop = false;
            this.pictureBoxTikus.Click += new System.EventHandler(this.pictureBoxTikus_Click);
            // 
            // pictureBoxBulu
            // 
            this.pictureBoxBulu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBulu.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Bulu;
            this.pictureBoxBulu.Location = new System.Drawing.Point(109, 114);
            this.pictureBoxBulu.Name = "pictureBoxBulu";
            this.pictureBoxBulu.Size = new System.Drawing.Size(89, 84);
            this.pictureBoxBulu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBulu.TabIndex = 2;
            this.pictureBoxBulu.TabStop = false;
            this.pictureBoxBulu.Click += new System.EventHandler(this.pictureBoxBulu_Click);
            // 
            // pictureBoxBola
            // 
            this.pictureBoxBola.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBola.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Bola;
            this.pictureBoxBola.Location = new System.Drawing.Point(14, 114);
            this.pictureBoxBola.Name = "pictureBoxBola";
            this.pictureBoxBola.Size = new System.Drawing.Size(89, 84);
            this.pictureBoxBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBola.TabIndex = 3;
            this.pictureBoxBola.TabStop = false;
            this.pictureBoxBola.Click += new System.EventHandler(this.pictureBoxBola_Click);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.X;
            this.X.Location = new System.Drawing.Point(242, 31);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(38, 50);
            this.X.TabIndex = 4;
            this.X.TabStop = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekOOP_FlyingDutchman.Properties.Resources.Inventory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 300);
            this.Controls.Add(this.pictureBoxTikus);
            this.Controls.Add(this.pictureBoxBulu);
            this.Controls.Add(this.pictureBoxBola);
            this.Controls.Add(this.X);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTikus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBulu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTikus;
        private System.Windows.Forms.PictureBox pictureBoxBulu;
        private System.Windows.Forms.PictureBox pictureBoxBola;
        private System.Windows.Forms.PictureBox X;
    }
}