namespace VSP_46219R_MyProject
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.viper = new System.Windows.Forms.PictureBox();
            this.battleCruiser = new System.Windows.Forms.PictureBox();
            this.starScream = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleCruiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starScream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(508, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 93);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fast ship\r\nSlow Fire Rate\r\nShotgun Style Weapon\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(296, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 93);
            this.label3.TabIndex = 33;
            this.label3.Text = "Slow ship\r\nFast Fire Rate\r\nCannon weapon";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 93);
            this.label5.TabIndex = 32;
            this.label5.Text = "Medium Speed\r\nMedium Fire Rate\r\nDouble Lasers\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // viper
            // 
            this.viper.BackColor = System.Drawing.Color.Transparent;
            this.viper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viper.Image = global::VSP_46219R_MyProject.Properties.Resources.spaceship_png_images_6_original;
            this.viper.Location = new System.Drawing.Point(564, 145);
            this.viper.Name = "viper";
            this.viper.Size = new System.Drawing.Size(193, 195);
            this.viper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viper.TabIndex = 31;
            this.viper.TabStop = false;
            this.viper.Visible = false;
            this.viper.Click += new System.EventHandler(this.viper_Click);
            // 
            // battleCruiser
            // 
            this.battleCruiser.BackColor = System.Drawing.Color.Transparent;
            this.battleCruiser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.battleCruiser.Image = global::VSP_46219R_MyProject.Properties.Resources._2d_space_ship_png_5;
            this.battleCruiser.Location = new System.Drawing.Point(289, 145);
            this.battleCruiser.Name = "battleCruiser";
            this.battleCruiser.Size = new System.Drawing.Size(193, 195);
            this.battleCruiser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.battleCruiser.TabIndex = 30;
            this.battleCruiser.TabStop = false;
            this.battleCruiser.Visible = false;
            this.battleCruiser.Click += new System.EventHandler(this.battleCruiser_Click);
            // 
            // starScream
            // 
            this.starScream.BackColor = System.Drawing.Color.Transparent;
            this.starScream.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.starScream.Image = global::VSP_46219R_MyProject.Properties.Resources._856963_spaceship_sprite_png;
            this.starScream.Location = new System.Drawing.Point(25, 145);
            this.starScream.Name = "starScream";
            this.starScream.Size = new System.Drawing.Size(193, 195);
            this.starScream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starScream.TabIndex = 29;
            this.starScream.TabStop = false;
            this.starScream.Visible = false;
            this.starScream.Click += new System.EventHandler(this.starScream_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(172, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 85);
            this.label6.TabIndex = 28;
            this.label6.Text = "Select A ship";
            this.label6.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(0, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lives: 3";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Score: 00";
            this.label1.Visible = false;
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Player.Location = new System.Drawing.Point(331, 458);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(93, 83);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 25;
            this.Player.TabStop = false;
            this.Player.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VSP_46219R_MyProject.Properties.Resources.BackgroundImage1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viper);
            this.Controls.Add(this.battleCruiser);
            this.Controls.Add(this.starScream);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.viper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleCruiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starScream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox viper;
        private System.Windows.Forms.PictureBox battleCruiser;
        private System.Windows.Forms.PictureBox starScream;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Player;
    }
}

