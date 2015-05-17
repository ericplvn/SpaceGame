using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceGame.Icons;

namespace SpaceGame
{
    public partial class MainForm : Form
    {
        StarShipIcon starShip = new StarShipIcon();
        int starShipSpeed = 10;
        int asteroidSpeed = 2;

        //Projectiles
        List<ProjectileIcon> Projectiles = new List<ProjectileIcon>();
        List<AsteroidIcon> Asteroids = new List<AsteroidIcon>();

        //Game State
        Timer GameTimer = new Timer();
        int GameSpeed = 30;
        Random randomSide = new Random();
        Random randomLoc = new Random();
        int Score = 0;

        private bool _paused = true;
        public bool Paused 
        {
            get
            {
                return _paused;
            }
            set
            {
                _paused = value;
                if (value)
                {
                    //GameTimer.Stop();
                    pausedToolStripStatusLabel.Text = "Paused";
                }
                else
                {
                    //GameTimer.Start();
                    pausedToolStripStatusLabel.Text = "Running";
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            
            //lambda events
            splitContainer1.KeyDown += (s, e) => KeyPressed(e.KeyCode);
            levelMap.MouseClick += (s, e) => fireCannon(starShip, e.X, e.Y);
            GameTimer.Tick += (s, e) => ProgressTime();
            starShip.ShipDestroyed += (s, e) => EndGame();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            starShip.Size = new Size(levelMap.Height / 20, levelMap.Height / 20);
            levelMap.Controls.Add(starShip);
            starShip.Size = new Size(levelMap.Height / 20, levelMap.Height / 20);
            starShip.Location = new Point(levelMap.Width / 2, levelMap.Height * 9 / 10 - starShip.Height);

            scoreStatusLabel.Text = Score.ToString();


            //set timer
            GameTimer.Interval = GameSpeed;
            GameTimer.Start();
        }




        //Ship Actions
        private void KeyPressed(Keys keyCode)
        {
            if (!Paused)
            {
                //Console.WriteLine("Key");
                switch (keyCode)
                {
                    case Keys.Left:
                        if (starShip.Left - starShipSpeed > 0)
                            starShip.Left = starShip.Left - starShipSpeed;
                        else if (starShip.Left > 0)
                            starShip.Left = 0;
                        break;
                    case Keys.Right:
                        if (starShip.Left + starShip.Size.Width + starShipSpeed < levelMap.Width)
                            starShip.Left = starShip.Left + starShipSpeed;
                        else if (starShip.Left + starShip.Size.Width < levelMap.Width)
                            starShip.Left = levelMap.Width - starShip.Size.Width;
                        break;
                    case Keys.Up:
                        if (starShip.Top - starShipSpeed > 0)
                            starShip.Top = starShip.Top - starShipSpeed;
                        else if (starShip.Top > 0)
                            starShip.Top = 0;
                        break;
                    case Keys.Down:
                        if (starShip.Top + starShip.Size.Height + starShipSpeed < levelMap.Height)
                            starShip.Top = starShip.Top + starShipSpeed;
                        else if (starShip.Top + starShip.Size.Height < levelMap.Height)
                            starShip.Top = levelMap.Height - starShip.Size.Height;
                        break;
                    default:
                        break;
                }
            }
            if (keyCode == Keys.Enter)
                Paused = !Paused;
        }

        public void fireCannon(StarShipIcon ship, int x, int y)
        {
            splitContainer1.Focus();
            if (!Paused)
            {
                ProjectileIcon newProjectile = ship.FireCannon();
                energyProgressBar.Value = ship.Energy;
                if (newProjectile != null)
                {
                    newProjectile.SetVelocity(x - (ship.Left + ship.Width / 2), y - (ship.Top + ship.Height / 2), 10);
                    newProjectile.Location = new Point(ship.Left + ship.Width / 2, ship.Top + ship.Height / 2);
                    levelMap.Controls.Add(newProjectile);
                    Projectiles.Add(newProjectile);
                }
            }
        }

        public void ProgressTime()
        {
            if (!Paused)
            {
                List<ProjectileIcon> deleteProjectileIcons = new List<ProjectileIcon>();
                List<AsteroidIcon> deleteAsteroidIcons = new List<AsteroidIcon>();

                //Move Asteroids
                foreach (AsteroidIcon asteroid in Asteroids)
                {
                    if (!asteroid.MoveIcon(levelMap))
                    {
                        if (!deleteAsteroidIcons.Contains(asteroid))
                        {
                            deleteAsteroidIcons.Add(asteroid);
                        }
                    }
                    if (starShip.CheckCollision(asteroid))
                    {
                        if (!deleteAsteroidIcons.Contains(asteroid))
                        {
                            deleteAsteroidIcons.Add(asteroid);
                        }
                        starShip.Shields -= 10;
                        if (starShip.Shields > 0)
                        {
                            shieldsProgressBar.Value = starShip.Shields;
                        }
                        else
                        {
                            Paused = true;
                            MessageBox.Show(String.Format("You Lost\n\nFinal Score: {0}", Score + 10));
                            this.Close();
                        }
                    }
                }

                //Move Projectiles
                foreach (ProjectileIcon projectile in Projectiles)
                {
                    if (!projectile.MoveIcon(levelMap))
                    {
                        if (!deleteProjectileIcons.Contains(projectile))
                        {
                            deleteProjectileIcons.Add(projectile);
                        }
                    }

                    //See if any projectiles hit any asteroids
                    foreach (AsteroidIcon asteroid in Asteroids)
                    {
                        if (asteroid.CheckCollision(projectile))
                        {
                            if (!deleteProjectileIcons.Contains(projectile))
                            {
                                deleteProjectileIcons.Add(projectile);
                            }
                            if (!deleteAsteroidIcons.Contains(asteroid))
                            {
                                deleteAsteroidIcons.Add(asteroid);
                            }
                        }
                    }
                }


                switch (randomSide.Next(0, 200))
                {
                    case 0:
                        AddAsteroid(1, 0, 1, randomLoc.Next(levelMap.Height));
                        break;
                    case 1:
                        AddAsteroid(-1, 0, levelMap.Width - 1, randomLoc.Next(levelMap.Height));
                        break;
                    case 2:
                        AddAsteroid(0, 1, randomLoc.Next(levelMap.Width), 1);
                        break;
                    case 3:
                        AddAsteroid(0, -1, randomLoc.Next(levelMap.Width), levelMap.Height - 1);
                        break;
                    default:
                        break;

                }



                DeleteProjectiles(deleteProjectileIcons);
                DeleteAsteroids(deleteAsteroidIcons);


            }
        }

        public void AddAsteroid(int velX, int velY, int locX, int locY)
        {
            AsteroidIcon newAsteroid = new AsteroidIcon();
            newAsteroid.Size = new Size(levelMap.Height / 20, levelMap.Height / 20);
            newAsteroid.SetVelocity(velX, velY, asteroidSpeed);
            newAsteroid.Location = new Point(locX, locY);
            levelMap.Controls.Add(newAsteroid);
            Asteroids.Add(newAsteroid);
        }

        public void DeleteProjectiles(List<ProjectileIcon> deleteIcons)
        {
            foreach (ProjectileIcon projectile in deleteIcons)
            {
                levelMap.Controls.Remove(projectile);
                Projectiles.Remove(projectile);
            }
        }
        public void DeleteAsteroids(List<AsteroidIcon> deleteIcons)
        {
            foreach (AsteroidIcon asteroids in deleteIcons)
            {
                levelMap.Controls.Remove(asteroids);
                Asteroids.Remove(asteroids);
                Score += 100;
                scoreStatusLabel.Text = Score.ToString();
            }
        }

        public void EndGame()
        {
            
        }

       


    }
}
