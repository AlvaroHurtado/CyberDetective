namespace CyberDetective
{
    partial class frmCyberDetective
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.pctDoor = new System.Windows.Forms.PictureBox();
            this.pctKey = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.GeneralTimer);
            // 
            // pctDoor
            // 
            this.pctDoor.Image = global::CyberDetective.Properties.Resources.tp;
            this.pctDoor.Location = new System.Drawing.Point(570, 346);
            this.pctDoor.Name = "pctDoor";
            this.pctDoor.Size = new System.Drawing.Size(123, 102);
            this.pctDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDoor.TabIndex = 8;
            this.pctDoor.TabStop = false;
            this.pctDoor.Tag = "door";
            // 
            // pctKey
            // 
            this.pctKey.Image = global::CyberDetective.Properties.Resources.keycard;
            this.pctKey.Location = new System.Drawing.Point(800, 408);
            this.pctKey.Name = "pctKey";
            this.pctKey.Size = new System.Drawing.Size(29, 18);
            this.pctKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctKey.TabIndex = 7;
            this.pctKey.TabStop = false;
            this.pctKey.Tag = "key";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CyberDetective.Properties.Resources.Sentinela_left;
            this.pictureBox5.Location = new System.Drawing.Point(250, 289);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "enemy";
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = global::CyberDetective.Properties.Resources.Cyber_right;
            this.pctPlayer.Location = new System.Drawing.Point(106, 391);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(67, 50);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlayer.TabIndex = 5;
            this.pctPlayer.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Brown;
            this.pictureBox4.Location = new System.Drawing.Point(236, 346);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 18);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Brown;
            this.pictureBox3.Location = new System.Drawing.Point(374, 444);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(529, 18);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.Location = new System.Drawing.Point(273, 444);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 18);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.Location = new System.Drawing.Point(91, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 18);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pctBackground
            // 
            this.pctBackground.Image = global::CyberDetective.Properties.Resources.background1;
            this.pctBackground.Location = new System.Drawing.Point(0, 0);
            this.pctBackground.Name = "pctBackground";
            this.pctBackground.Size = new System.Drawing.Size(1200, 463);
            this.pctBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBackground.TabIndex = 0;
            this.pctBackground.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Brown;
            this.pictureBox6.Location = new System.Drawing.Point(66, 289);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(68, 18);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // frmCyberDetective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pctDoor);
            this.Controls.Add(this.pctKey);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pctPlayer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctBackground);
            this.Name = "frmCyberDetective";
            this.Text = "CyberDetective";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pctDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBackground;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pctKey;
        private System.Windows.Forms.PictureBox pctDoor;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

