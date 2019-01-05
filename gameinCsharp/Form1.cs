using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
namespace gameinCsharp
{
    public partial class SpellGame : Form
    {
        public SpellGame()
        {
            InitializeComponent();
        }
        //for sound
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer explosion;

        //for enemy firing
        PictureBox[] enemyMunition;
        int enemyMunitionSpeed;
        //for enemy planes
        PictureBox[] enemies;
        int enemyspeed;
        //for star and bg animation
        PictureBox[] words;
        int bgspeed;
        int playerspeed;
        //for Firings
        PictureBox[] munitions;
        int munitionspeed;
       
        Random rd;

        int score;
        int level;
        int difficulty;
        bool pause;
        bool gameIsOver;

        private void Form1_Load(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            difficulty = 9;

            bgspeed = 4;
            playerspeed = 4;
            munitionspeed = 20;
            munitions = new PictureBox[3];
            enemyspeed = 4;
            enemyMunitionSpeed = 4;

            //load images
            Image munition = Image.FromFile(@"asserts\munition.png");

            Image enimy1 = Image.FromFile("asserts\\E1.png");
            Image enimy2 = Image.FromFile("asserts\\E2.png");
            Image enimy3 = Image.FromFile("asserts\\E3.png");
            Image boss1 = Image.FromFile("asserts\\Boss1.png");
            Image boss2 = Image.FromFile("asserts\\Boss2.png");

            enemies = new PictureBox[10];
            //initialize enemy
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enimy2;
            enemies[2].Image = enimy3;
            enemies[3].Image = enimy1;
            enemies[4].Image = enimy2;
            enemies[5].Image = enimy1;
            enemies[6].Image = enimy3;
            enemies[7].Image = enimy2;
            enemies[8].Image = enimy1;
            enemies[9].Image = boss2;

                for (int i = 0; i < munitions.Length; i++)
                {
                    munitions[i] = new PictureBox();
                    munitions[i].Size = new Size(8, 8);
                    munitions[i].Image = munition;
                    munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                    munitions[i].BorderStyle = BorderStyle.None;
                    this.Controls.Add(munitions[i]);
                }

            //create WMP

            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            //load all songs

            gameMedia.URL = "songs\\GameSong.mp3";
            shootMedia.URL = "songs\\shoot.mp3";
            explosion.URL = "songs\\boom.mp3";

            //setup Song Settings
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 8;
            shootMedia.settings.volume = 2;
            explosion.settings.volume = 6;



            rd = new Random();
            words = new PictureBox[10];
            


            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new PictureBox();
                words[i].BorderStyle = BorderStyle.None;
                words[i].Location = new Point(rd.Next(20, 500), rd.Next(10, 400));
                
                

                if (i % 2 == 1)
                {
                    words[i].Size = new Size(2, 2);
                    words[i].BackColor = Color.DarkGray;
                    
                }
                else
                {
                    words[i].Size = new Size(3, 3);
                    words[i].BackColor = Color.Wheat;

                }
                this.Controls.Add(words[i]);
                
            }
            //enemy Munitions
            enemyMunition = new PictureBox[10];
            for (int i = 0; i < enemyMunition.Length; i++)
            {
                enemyMunition[i] = new PictureBox();
                enemyMunition[i].Size = new Size(2, 25);
                enemyMunition[i].Visible = false;
                enemyMunition[i].BackColor = Color.Yellow;
                int x = rd.Next(0, 10);//randomly selecting enemy
                enemyMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemyMunition[i]);

            }

            gameMedia.controls.play();




        }

        private void movebg_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < words.Length / 2; i++)
            {
                words[i].Top += bgspeed;
                if (words[i].Top >= this.Height)
                {
                    words[i].Top = -words[i].Height;
                }
            }
            for (int i = words.Length / 2; i < words.Length; i++)
            {
                words[i].Top += bgspeed - 2;
                if (words[i].Top >= this.Height)
                {
                    words[i].Top = -words[i].Height;
                }
            }
        }

        private void leftMove_Tick(object sender, EventArgs e)
        {
            if (player.Left > 10)
            {
                player.Left -= playerspeed;
            }
        }

        private void rightMove_Tick(object sender, EventArgs e)
        {
            if (player.Right < 580)
            {
                player.Left += playerspeed;
            }
        }

        private void upMove_Tick(object sender, EventArgs e)
        {
            if (player.Top > 10)
            {
                player.Top -= playerspeed;
            }
        }

        private void downMove_Tick(object sender, EventArgs e)
        {
            if (player.Top <400)
            {
                player.Top += playerspeed;
            }
        }

        private void SpellGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    rightMove.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    leftMove.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    upMove.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    downMove.Start();
                }
            }
            
        }

        private void SpellGame_KeyUp(object sender, KeyEventArgs e)
        {
            leftMove.Stop();
            rightMove.Stop();
            upMove.Stop();
            downMove.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        startTimers();
                        label1.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        gameMedia.controls.pause();
                        stopTimers();
                        pause = true;
                    }
                }
            }

        }

        private void moveMunition_Tick(object sender, EventArgs e)
        {
            shootMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionspeed;

                    Collition();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(player.Location.X + 20, player.Location.Y - i * 30);
                }
            }
        }

        private void moveEnemy_Tick(object sender, EventArgs e)
        {
            moveEnemies(enemies, enemyspeed);
        }

        //function to move enemy
        private void moveEnemies(PictureBox[] array,int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        
        //fuction for collition b/w enemy and bullets
        private void Collition()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) ||
                    munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) ||
                    munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();

                    score += 1;
                    scoreLabel.Text = (score < 10) ? "SCORE:0" + score.ToString() : "SCORE:"+ score.ToString();
                    if (score % 20 == 0)
                    {
                        level += 1;
                        levelLabel.Text = (level < 10) ? "LEVEL:0" + level.ToString() : "LEVEL:"+ level.ToString();
                        if (enemyspeed <= 10 && enemyMunitionSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemyspeed++;
                            enemyMunitionSpeed++;
                        }
                        if (level == 10)
                        {
                            gameOver("WELL PLAYED");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                if (player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    player.Visible = false;
                    gameOver("GAME OVER");

                }
            }
        }

        //function to stop game ewhen collition occures
        private void gameOver(String str)
        {
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            EXIT.Visible = true;
            REPLAY.Visible = true;
            
            gameMedia.controls.stop();
            stopTimers();
        }

        //function to stop timers
        private void stopTimers()
        {
            movebg.Stop();
            moveEnemy.Stop();
            moveMunition.Stop();
            enemyMunitionTimer.Stop();
        }

        //function to start timers
        private void startTimers()
        {
            movebg.Start();
            moveEnemy.Start();
            moveMunition.Start();
            enemyMunitionTimer.Start();
        }

        private void enemyMunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyMunition.Length-difficulty; i++)
            {
                if (enemyMunition[i].Top < this.Height)
                {
                    enemyMunition[i].Visible = true;
                    enemyMunition[i].Top += enemyMunitionSpeed;

                    collitionWithEnemyMunition();
                }
                else
                {
                    enemyMunition[i].Visible = false;
                    int x = rd.Next(0, 10);
                    enemyMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        //function for collide enemy fire with player
        private void collitionWithEnemyMunition()
        {
            for (int i = 0; i < enemyMunition.Length; i++)
            {
                if(enemyMunition[i].Bounds.IntersectsWith(player.Bounds))
                {
                    enemyMunition[i].Visible=false;
                    explosion.settings.volume=30;
                    explosion.controls.play();
                    player.Visible=false;
                    gameOver("GAME OVER");
                }
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void REPLAY_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }
    }

}
