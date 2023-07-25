namespace ProjekOOP_FlyingDutchman
{
    partial class FormLoad
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
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.PictureBox();
            this.X = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.Font = new System.Drawing.Font("Kiddosy Free Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(32, 112);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(208, 27);
            this.comboBoxPlayer.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirm.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.Button;
            this.buttonConfirm.Location = new System.Drawing.Point(95, 217);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(110, 45);
            this.buttonConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.TabStop = false;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.Image = global::ProjekOOP_FlyingDutchman.Properties.Resources.X;
            this.X.Location = new System.Drawing.Point(241, 32);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(34, 34);
            this.X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.X.TabIndex = 4;
            this.X.TabStop = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ProjekOOP_FlyingDutchman.Properties.Resources.Load;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 300);
            this.Controls.Add(this.X);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxPlayer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "v";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FormLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.PictureBox buttonConfirm;
        private System.Windows.Forms.PictureBox X;
    }
}