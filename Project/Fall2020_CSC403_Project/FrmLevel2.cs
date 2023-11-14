using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private bool healthShown = false;
        private bool fought = false;
        private bool goToInterScreen = false;

        private Player player;

        private Character[] walls;
        private static Timer playerMove;
        private DateTime timeBegin;
        private FrmBattle frmBattle;

  

        public FrmLevel2()
        {
            InitializeComponent();
            lblPlayerHealthFull.Hide();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Level2);
            simpleSound.Play();
            const int PADDING = 7;
            const int NUM_WALLS = 8;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            playerMove = tmrPlayerMove;

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
        }
        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel2_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies

            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            fought = true;
            healthShown = false;
            lblPlayerHealthFull.Hide();
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();


        }

        private void FrmLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                PauseGame();
            }
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;

                case Keys.Tab:
                    UpdateHealth();
                    if (healthShown)
                    {
                        lblPlayerHealthFull.Hide();
                        healthShown = false;
                    }
                    else
                    {
                        lblPlayerHealthFull.Show();
                        healthShown = true;
                    }
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }
        private void PauseGame()
        {
            //pauseMenuForm.ShowDialog();
            Form pause = new Paused();
            pause.Show();
            tmrPlayerMove.Enabled = false;
        }
        public static void enablePlayerMove()
        {
            playerMove.Enabled = true;
        }

        public void UpdateHealth()
        {
            if (fought)
            {
                float playerHealthPer = frmBattle.player.Health / (float)frmBattle.player.MaxHealth;
                const int MAX_HEALTHBAR_WIDTH = 226;
                lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
                lblPlayerHealthFull.Text = frmBattle.player.Health.ToString();
            }
            else
            {
                float playerHealthPer = 1;
                const int MAX_HEALTHBAR_WIDTH = 226;
                lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
                lblPlayerHealthFull.Text = 20.ToString();
            }
        }

        private void FrmLevel2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && goToInterScreen == false)
            {
                Application.Exit();
            }
        }
    }
}
