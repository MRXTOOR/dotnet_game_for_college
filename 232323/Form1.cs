using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.Diagnostics;

namespace _232323
{
    public partial class Form1 : Form
    {
        PictureBox[] cloud;
        int backgroundspeed;
        Random rnd;
        int playerspeed;
        PictureBox[] bullets;
        int bulletspeed;
#pragma warning disable IDE0044 // Добавить модификатор только для чтения
        int i;
#pragma warning restore IDE0044 // Добавить модификатор только для чтения
        PictureBox[] enemies;
        int sizeEnemy;
        int enemiesSpeed;
        WindowsMediaPlayer shoot;
        WindowsMediaPlayer GameSong;
        WindowsMediaPlayer shadow;
        WindowsMediaPlayer gachi;

        int Score;
        int level;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed;
                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }

            }

            for (int i = cloud.Length; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed -10;
                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Left;
                }

            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 5;
            cloud = new PictureBox[20];
            rnd = new Random();
            playerspeed = 1;
            bullets = new PictureBox[1];
            bulletspeed = 90;
            shoot = new WindowsMediaPlayer();
            shoot.URL = "assets\\prostoy.mp3";
            shadow = new WindowsMediaPlayer();
            shadow.URL = "assets\\shadowraze.mp3";

            gachi = new WindowsMediaPlayer();
            gachi.URL = "assets\\Sound44.mp3";

           

            Score = 0;
            level = 1;


            enemies = new PictureBox[4];
            int sizeEnemy = rnd.Next(60, 80);
            enemiesSpeed = 3;

            Image easyEnemies = Image.FromFile("assets\\b23def5.gif");

           
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = easyEnemies;
                enemies[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 1080, rnd.Next(450, 600));

                this.Controls.Add(enemies[i]);
            }


            for (int i = 0; i < bullets.Length; i++)
            { 
            bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(20, 5);
                bullets[i].BackColor = Color.White;

                this.Controls.Add(bullets[i]);
            }

                for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(120, 329));
                if (i % 2 == 1)
                {
                    cloud[i].Size = new Size(rnd.Next(100, 255), rnd.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
                }
                else
                {
                    cloud[i].Size = new Size(150, 25);
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
                }
                this.Controls.Add(cloud[i]);


            }
            shadow.controls.play();
        }

       

        public void leftmv_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left > 10)
            {
                mainPlayer.Left -= playerspeed;
            }
        }

        public void rightmv_Tick(object sender, EventArgs e)
        {
            
            
                if (mainPlayer.Left < 1150)
                {
                    mainPlayer.Left += playerspeed; 
                }
        }

        public void upmv_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top -= playerspeed;
        }

        public void Downmv_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top += playerspeed;
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources._6a4bcdfb_df31_4fc1_b17b_5f53af936a00;

            if (e.KeyCode == Keys.Left)
            {
                leftmv.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                rightmv.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                upmv.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
               Downmv.Start();
            }
            
            if (e.KeyCode == Keys.Space)
            {
                shoot.controls.play();
                for (int i = 0; i < bullets.Length; i++);
                {

                    Intersect();
                    if (bullets[i].Left > 1280)
                    {
                        bullets[i].Location = new Point(mainPlayer.Location.X + 100 + i + 50, mainPlayer.Location.Y + 50);
                    }
                    
                }
            }
        }

       

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.Снимок_экрана_2022_04_03_094324;


            leftmv.Stop();
            rightmv.Stop();
            upmv.Stop();
            Downmv.Stop();

        }

        private void mvbullet(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++);
            {
                bullets[i].Left += bulletspeed;
            }
        }

        private void mvEnemies_Tick(object sender, EventArgs e)
        {
            mvEnenies(enemies, enemiesSpeed);            
        }
        private void mvEnenies(PictureBox[] enimies,int speed)
        {
            for (int i = 0; i < enimies.Length; i++)
            {
              enemies[i].Left -= speed + (int)(Math.Sin(enemies[i].Left * Math.PI / 180) + Math.Cos(enemies[i].Left * Math.PI / 180));
            }

            Intersect();


            if (enemies.Length < this.Left)
            {
                int sizeEnemy = rnd.Next(60, 90);
                enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                enemies[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1080,rnd.Next(450, 650));
            }
        }

        private void Intersect()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (bullets[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    Score += 1;
                    labelScore.Text = (Score <10) ? "0" + Score.ToString() : Score.ToString();

                    if (Score % 10 == 0)
                    {
                        level += 1;
                        labelLevel.Text = (level < 10) ? "0" + level.ToString() : level.ToString();

                        if (enemiesSpeed <= 3)
                        {
                            enemiesSpeed++;

                        }

                        if (level == 10)
                        {
                            GameOver("HAHAHAHAHA HARD");
                        }

                    }


                    enemies[i].Location = new Point(rnd.Next(150, 250) + 1280, rnd.Next(420,600));
                    bullets[0].Location = new Point(2000, mainPlayer.Location.Y + 50);
                    
                }
                if (mainPlayer.Bounds.IntersectsWith(enemies[i].Bounds))
                { 
                    mainPlayer.Visible = false;

                    GameOver("Game over");
                }
            }
        }
        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(500, 50);
            label1.Visible = true;

            shadow.controls.stop();
            mvEnemies.Stop(); 
            gachi.controls.play();
        }

        
    }
}
