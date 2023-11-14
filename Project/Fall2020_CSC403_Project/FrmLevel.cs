using Fall2020_CSC403_Project.code; //importing necessary namespaces
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Media;
using static Fall2020_CSC403_Project.code.InventorySystem;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;
        private bool healthShown = false;
        private bool fought = false;
        private bool goToInterScreen = false;

        private static Enemy enemyPoisonPacket;
        private static Enemy bossKoolaid;
        private static Enemy enemyCheeto;
        private static PictureBox bossPic;
        private static PictureBox poisinPacketPic;
        private static PictureBox cheetoPic;
        private static PictureBox exitDoor;
        
        private Enemy door;
        private Character[] walls;
        private static Timer playerMove;
        private DateTime timeBegin;
        private FrmBattle frmBattle;


        public FrmLevel()
        {
            InitializeComponent();
            lblPlayerHealthFull.Hide();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            MusicForLevel();
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            playerMove = tmrPlayerMove;
            door = new Enemy(CreatePosition(picdoor), CreateCollider(picdoor, PADDING));

            picdoor.Hide();

            player.MaxHealth = 50;
            bossKoolaid.MaxHealth = 150;
            enemyPoisonPacket.MaxHealth = 100;
            enemyCheeto.MaxHealth = 200;

            player.Health = 50;
            bossKoolaid.Health = 150;
            enemyPoisonPacket.Health = 100;
            enemyCheeto.Health = 200;

            player.strength = 4;
            bossKoolaid.strength = 8;
            enemyPoisonPacket.strength = 4;
            enemyCheeto.strength = 2;

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.FromArgb(203, 52, 227);
            enemyCheeto.Color = Color.FromArgb(255, 140, 0);

            bossPic = picBossKoolAid;
            poisinPacketPic = picEnemyPoisonPacket;
            cheetoPic = picEnemyCheeto;
            exitDoor = picdoor;

            player.MaxHealth = 50;
            player.Health = 50;
            
            //Potion potion = new Potion();

            MyApplicationContext.inventory.AddItem(MyApplicationContext.potion, 1);

            InventoryRecord inventoryRecord = MyApplicationContext.inventory.InventoryRecords.First(x => (x.InventoryItem.ID == MyApplicationContext.potion.ID) && (x.Quantity < MyApplicationContext.potion.MaximumStackableQuantity));
            string result = "Inventory Contents:\n";

            foreach (var record in MyApplicationContext.inventory.InventoryRecords)
            {
                result += $"{record.InventoryItem.Name} - Quantity: {record.Quantity}\n";
                Console.WriteLine(record.InventoryItem.Name);
                Console.WriteLine(record.Quantity);
            }

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

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        //save checkpoint
        public void SaveCheckPoint() {
            var loadedCompletion = CheckpointManager.LoadLevelCompletion();
            bool isLevel1Complete = loadedCompletion.ContainsKey("Level1") ? loadedCompletion["Level1"] : false;
            if (isLevel1Complete == false)
            {
                CheckpointManager.SaveLevelCompletion("Level1");
            }
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

            //check collision with door
            if (HitAChar(player, door)) {
                goToInterScreen = true;
                SaveCheckPoint();
                MyApplicationContext.SwitchToFrmIntermisson();
                CheckpointManager.SaveInventory();
            }

            // check collision with enemies
            if (enemyPoisonPacket != null)
            {
                if (HitAChar(player, enemyPoisonPacket))
                {
                    Fight(enemyPoisonPacket);
                }
            }
            if (enemyCheeto != null)
            {
                if (HitAChar(player, enemyCheeto))
                {
                    Fight(enemyCheeto);
                }
            }   
            if (bossKoolaid != null)
            {
                if (HitAChar(player, bossKoolaid))
                {
                    Fight(bossKoolaid);
                }
            }

            // update player's picture box
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

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }

        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
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

        public static void hideEnemy(Enemy deadenemy) 
        {
            if (deadenemy == bossKoolaid)
            {
                bossPic.Hide();
                bossKoolaid = null;
            }
            else if (deadenemy == enemyCheeto)
            {
                cheetoPic.Hide();
                enemyCheeto = null;
            }
            else if (deadenemy == enemyPoisonPacket)
            { 
                poisinPacketPic.Hide();
                enemyPoisonPacket = null;
            }

            //show door if all enemies are dead
            if (bossKoolaid == null && enemyCheeto == null && enemyPoisonPacket == null)
            {
                exitDoor.Show();
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {
        }

        public void UpdateHealth()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblPlayerHealthFull.Text = player.Health.ToString();
        }

        private void FrmLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && goToInterScreen == false)
            {
                Application.Exit();
            }
        }
        public void MusicForLevel()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(Resources.Level1);
                simpleSound.Play();
            }
            catch (Exception ex)
            {
                // Handle exception or log the error
                Console.WriteLine($"Error playing sound: {ex.Message}");
            }
        }
    }
}
