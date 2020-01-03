using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VSP_46219R_MyProject
{
    public partial class Form1 : Form
    {
        // Levels
        PictureBox[,] levelOne = new PictureBox[3, 6];
        PictureBox[,] levelTwo = new PictureBox[4, 6];
        // Controls
        bool goLeft;
        bool goUp;
        bool goBack;
        bool goRight;
        bool playerShoot;
        // keep count of score and killd enemies
        int levelOneCount = 15;
        int levelTwoCount = 24;
        int score = 0;
        int killCount = 0;
        int lives = 3;
        // speed of the player and the bullets
        int playerSpeed;
        int bulletSpeed;

        public Form1()
        {
            InitializeComponent();
            StartMenu();
        }
        // start menu genertion
        public void StartMenu()
        {
            this.DoubleBuffered = true;
            this.Controls.Clear();
            // Start Menu
            RoundedButton startBtn = new RoundedButton();
            RoundedButton optionsBtn = new RoundedButton();
            RoundedButton quitBtn = new RoundedButton();
            this.Controls.Add(startBtn);
            this.Controls.Add(optionsBtn);
            this.Controls.Add(quitBtn);
            label1.Text = "Score: 00";
            label2.Text = "Lives: 3";
            levelOneCount = 15;
            levelTwoCount = 24;
            killCount = 0;
            score = 0;
            // Start Button
            startBtn.Location = new Point(215, 160);
            startBtn.Size = new Size(350, 65);
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Text = "Save The Universe";
            startBtn.Font = new Font("MV Boli", 19, FontStyle.Bold);
            startBtn.ForeColor = Color.White;
            startBtn.MouseClick += (sender, e) =>
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                this.Controls.Clear();
                this.Controls.Add(starScream);
                this.Controls.Add(battleCruiser);
                this.Controls.Add(viper);
                this.Controls.Add(label5);
                this.Controls.Add(label3);
                this.Controls.Add(label4);
                this.Controls.Add(label6);


                starScream.Visible = true;
                battleCruiser.Visible = true;
                viper.Visible = true;
                startBtn.Visible = false;
                optionsBtn.Visible = false;
                quitBtn.Visible = false;
                RoundedButton backButton = new RoundedButton();
                backButton.Location = new Point(30, 475);
                backButton.Text = "Back";
                backButton.Font = new Font("MV Boli", 19, FontStyle.Bold);
                backButton.ForeColor = Color.White;
                backButton.Size = new Size(250, 65);
                backButton.FlatStyle = FlatStyle.Flat;
                backButton.BackgroundImage = this.BackgroundImage;
                this.Controls.Add(backButton);
                backButton.MouseClick += (senderr, ee) =>
                {
                    this.Controls.Clear();
                    this.Controls.Add(startBtn);
                    this.Controls.Add(optionsBtn);
                    this.Controls.Add(quitBtn);
                    startBtn.Visible = true;
                    optionsBtn.Visible = true;
                    quitBtn.Visible = true;
                };
            };
            startBtn.BackgroundImage = this.BackgroundImage;

            // Options Button
            optionsBtn.Location = new Point(215, 250);
            optionsBtn.Text = "Options";
            optionsBtn.Font = new Font("MV Boli", 19, FontStyle.Bold);
            optionsBtn.ForeColor = Color.White;
            optionsBtn.Size = new Size(350, 65);
            optionsBtn.FlatStyle = FlatStyle.Flat;
            optionsBtn.BackgroundImage = this.BackgroundImage;
            optionsBtn.MouseClick += (sender, e) =>
            {
                CheckBox vsynCheck = new CheckBox();
                Label vsync = new Label();

                this.Controls.Add(vsync);
                this.Controls.Add(vsynCheck);

                vsync.Text = "VSync";
                vsync.ForeColor = Color.White;
                vsync.Font = new Font("MV Boli", 19, FontStyle.Bold);
                vsync.Location = new Point(215, 200);
                vsync.Height = 50;
                vsync.BackColor = Color.Transparent;

                vsynCheck.Location = new Point(350, 200);
                vsynCheck.FlatStyle = FlatStyle.Flat;
                vsynCheck.Appearance = Appearance.Button;
                vsynCheck.Size = new Size(75, 35);
                vsynCheck.TextAlign = ContentAlignment.MiddleCenter;
                vsynCheck.Text = "ON";
                vsynCheck.Font = new Font("Arial", 10, FontStyle.Bold);
                vsynCheck.ForeColor = Color.White;
                vsynCheck.FlatAppearance.BorderColor = Color.CadetBlue;
                vsynCheck.FlatAppearance.BorderSize = 1;
                vsynCheck.BackgroundImage = this.BackgroundImage;

                vsynCheck.CheckedChanged += (checkMe, a) =>
                {
                    if (vsynCheck.Text == "ON")
                    {
                        vsynCheck.Text = "OFF";
                    }
                    else
                    {
                        vsynCheck.Text = "ON";
                    }
                };
                quitBtn.Visible = false;
                startBtn.Visible = false;
                optionsBtn.Visible = false;
                RoundedButton backButton = new RoundedButton();
                backButton.Location = new Point(30, 475);
                backButton.Text = "Back";
                backButton.Font = new Font("MV Boli", 19, FontStyle.Bold);
                backButton.ForeColor = Color.White;
                backButton.Size = new Size(250, 65);
                backButton.FlatStyle = FlatStyle.Flat;
                backButton.BackgroundImage = this.BackgroundImage;
                this.Controls.Add(backButton);
                backButton.MouseClick += (senderr, ee) =>
                {
                    this.Controls.Clear();
                    this.Controls.Add(startBtn);
                    this.Controls.Add(optionsBtn);
                    this.Controls.Add(quitBtn);
                    startBtn.Visible = true;
                    optionsBtn.Visible = true;
                    quitBtn.Visible = true;
                };
            };

            //Quit Button
            quitBtn.Location = new Point(215, 340);
            quitBtn.Text = "Quit";
            quitBtn.Font = new Font("MV Boli", 19, FontStyle.Bold);
            quitBtn.ForeColor = Color.White;
            quitBtn.Size = new Size(350, 65);
            quitBtn.FlatStyle = FlatStyle.Flat;
            quitBtn.BackgroundImage = this.BackgroundImage;
            quitBtn.MouseClick += (sender, e) =>
            {
                Application.Exit();
            };
        }
        // Ships
        private void starScream_Click(object sender, EventArgs e)
        {
            Player.Image = starScream.Image;
            Player.SizeMode = starScream.SizeMode;
            playerSpeed = 20;
            bulletSpeed = 20;

            this.Controls.Clear();
            this.Controls.Add(Player);
            this.Controls.Add(label2);
            this.Controls.Add(label1);

            LevelOne();
            Player.Visible = true;
            timer1.Start();
        }
        private void battleCruiser_Click(object sender, EventArgs e)
        {
            Player.Visible = true;
            Player.Image = battleCruiser.Image;
            Player.SizeMode = battleCruiser.SizeMode;
            playerSpeed = 10;
            bulletSpeed = 35;
            this.Controls.Clear();
            this.Controls.Add(Player);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            LevelOne();
            Player.Visible = true;
        }
        private void viper_Click(object sender, EventArgs e)
        {
            Player.Visible = true;
            Player.Image = viper.Image;
            Player.SizeMode = viper.SizeMode;
            Player.Width = 75;
            playerSpeed = 25;
            bulletSpeed = 16;
            this.Controls.Clear();
            this.Controls.Add(Player);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            LevelOne();
            Player.Visible = true;
        }
        // Check for key press events
        private void keyisdown(object sender, KeyEventArgs e)
        {
            // if escape is press go to main menu and reset player position
            if (e.KeyCode == Keys.Escape)
            {
                Player.Top = 430;
                Player.Left = 313;
                StartMenu();
                score = 0;
                killCount = 0;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goBack = true;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (Player.Image == viper.Image)
            {
                if (e.KeyCode == Keys.Space && !playerShoot)
                {
                    timer1.Start();
                    playerShoot = true;
                    ShotGun();
                    ShotGunLeft();
                    ShotGunRight();
                }
            }
            if (Player.Image == battleCruiser.Image)
            {
                if (e.KeyCode == Keys.Space && !playerShoot)
                {
                    timer1.Start();
                    playerShoot = true;
                    Cannon();
                }
            }
            if (Player.Image == starScream.Image)
            {
                if (e.KeyCode == Keys.Space && !playerShoot)
                {
                    timer1.Start();
                    playerShoot = true;
                    LaserLeft();
                    LaserRight();
                }
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goBack = false;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (playerShoot)
            {
                playerShoot = false;
            }
        }
        // timer for the game
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move the ship Up,Down,Left and Right stop it from moving out of the form 
            if (goLeft && Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
            else if (goRight && Player.Left < ClientRectangle.Width - 100)
            {
                Player.Left += playerSpeed;
            }
            else if (goUp && Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }
            else if (goBack && Player.Top < this.ClientSize.Height - 100)
            {
                Player.Top += playerSpeed / 2;
            }
            // Remove bullets that go too far
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "bullet")
                {
                    y.Top -= bulletSpeed;
                    if (y.Top < 0)
                    {
                        this.Controls.Remove(y);
                    }
                }
                if (y is PictureBox && y.Tag == "shotGun")
                {
                    y.Top -= bulletSpeed;
                    y.Left += 3;
                    if (y.Top < 0)
                    {
                        this.Controls.Remove(y);
                    }
                }
                if (y is PictureBox && y.Tag == "shotGunLeft")
                {
                    y.Top -= bulletSpeed;
                    y.Left -= 3;
                    if (y.Top < 3)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }
            // Check if player collides with enemy
            // update score and lives, remove enemies when they collide with a bullet
            foreach (Control j in this.Controls)
            {
                // player collides with enemy
                if (j is PictureBox && j.Tag == "enemy")
                {
                    if (j.Bounds.IntersectsWith(Player.Bounds) && lives > 0)
                    {
                        LifeLost();
                    }
                    else if (j.Bounds.IntersectsWith(Player.Bounds))
                    {
                        GameOver();
                    }
                }
                // score and live updates, check if bullets collide with enemies
                // level transitions
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "enemy")
                    {
                        if (i is PictureBox && i.Tag == "bullet" || i.Tag == "shotGun" || i.Tag == "shotGunLeft")
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                killCount++;

                                if (killCount >= 10)
                                {
                                    lives++;
                                    killCount = 0;
                                    label2.Text = $"Lives: {lives}";
                                    label1.Text = $"Score: {score}";
                                }
                                else
                                {
                                    label2.Text = $"Lives: {lives}";
                                    label1.Text = $"Score: {score}";
                                }

                                this.Controls.Remove(i);
                                this.Controls.Remove(j);

                                if (levelOneCount <= 0)
                                {
                                    levelTwoCount--;
                                }

                                levelOneCount--;

                                if (levelOneCount == 0)
                                {
                                    timer1.Stop();
                                    MessageBox.Show("Level Comlete!");
                                    LevelTwo();
                                    Player.Top = 430;
                                    Player.Left = 313;

                                }
                                if (levelTwoCount <= 0)
                                {
                                    timer1.Stop();
                                    MessageBox.Show("You won!");
                                    Application.Restart();
                                }
                            }
                        }
                    }
                }
            }
        }

        // Level creation
        public void LevelOne()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    levelOne[i, k] = new PictureBox();
                    levelOne[i, k].Image = Properties.Resources.hqdefault;
                    levelOne[i, k].SizeMode = PictureBoxSizeMode.StretchImage;
                    levelOne[i, k].Size = new Size(50, 50);
                    levelOne[i, k].Tag = "enemy";
                    levelOne[i, k].Name = "enemy";
                    levelOne[i, k].Location = new Point(k * 60 + 200, i * 60 + 50);
                    this.Controls.Add(levelOne[i, k]);
                }
            }
        }
        public void LevelTwo()
        {
            this.Controls.Clear();
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(Player);
            if (levelOneCount == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        levelTwo[i, k] = new PictureBox();
                        levelTwo[i, k].Image = Properties.Resources.red_SpaceInvader;
                        levelTwo[i, k].Size = new Size(50, 50);
                        levelTwo[i, k].SizeMode = PictureBoxSizeMode.StretchImage;
                        levelTwo[i, k].Tag = "enemy";
                        levelTwo[i, k].Location = new Point(k * 60 + 200, i * 60 + 50);
                        this.Controls.Add(levelTwo[i, k]);
                    }
                }
            }
        }

        // Weapon variants 
        // viper's weapon
        public void ShotGun()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.LightGreen;
            bullet.Size = new Size(15, 15);
            bullet.Tag = "bullet";
            bullet.Left = Player.Left + 35;
            bullet.Top = Player.Top - 35;
            this.Controls.Add(bullet);
        }
        public void ShotGunRight()
        {
            PictureBox bullet2 = new PictureBox();
            bullet2.BackColor = Color.LightGreen;
            bullet2.Size = new Size(15, 15);
            bullet2.Tag = "shotGun";
            bullet2.Left = Player.Left + Player.Width;
            bullet2.Top = Player.Top - 30;
            this.Controls.Add(bullet2);
        }
        public void ShotGunLeft()
        {
            PictureBox bullet3 = new PictureBox();
            bullet3.BackColor = Color.LightGreen;
            bullet3.Size = new Size(15, 15);
            bullet3.Tag = "shotGunLeft";
            bullet3.Left = Player.Left;
            bullet3.Top = Player.Top - 30;
            this.Controls.Add(bullet3);
        }
        // StarScream's weapon
        public void LaserLeft()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.LightBlue;
            bullet.Size = new Size(7, 40);
            bullet.Tag = "bullet";
            bullet.Left = Player.Left + 10;
            bullet.Top = Player.Top - 35;
            this.Controls.Add(bullet);
        }
        public void LaserRight()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.LightBlue;
            bullet.Size = new Size(7, 40);
            bullet.Tag = "bullet";
            bullet.Left = Player.Left + 65;
            bullet.Top = Player.Top - 35;
            this.Controls.Add(bullet);
        }
        // Battlecruiser's weapon
        public void Cannon()
        {
            PictureBox cannon = new PictureBox();
            cannon.BackColor = Color.SandyBrown;
            cannon.Size = new Size(25, 25);
            cannon.Tag = "bullet";
            cannon.Left = Player.Left + 35;
            cannon.Top = Player.Top - 35;
            this.Controls.Add(cannon);
        }
        // Game over
        public void GameOver()
        {
            timer1.Stop();
            label1.Text = $"Score: {score}";
            MessageBox.Show($"Game Over!\nScore: {score}");
            Application.Exit();
        }
        // Losing a life
        public void LifeLost()
        {
            Player.Top = 430;
            Player.Left = 313;
            lives--;
            label2.BringToFront();
            label2.Text = $"Lives: {lives}";
        }

        
    }
    // Class for buttons with rounded edges
    class RoundedButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 60))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
}

