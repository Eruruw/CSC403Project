using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        public FrmLevel frmLevel;
        public Enemy enemy;
        public Player player;
        public bool potion_chance = true;

        private FrmBattle()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;
        

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle()
        {
            buttonFlee.Visible = false;
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;
            

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
           
        }

        public static FrmBattle GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
                
            }
            return instance;
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;
            player.OnAttack(-4);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                FrmLevel.hideEnemy(enemy);
                instance = null;
                Close();
            }
            enemy.AttackEvent -= PlayerDamage;
            player.AttackEvent -= EnemyDamage;
        }

        private void potion_button_Click(object sender, EventArgs e)
        {
            if (potion_chance)
            {
                enemy.AttackEvent += PlayerDamage;
                player.AttackEvent += EnemyDamage;
                potion_chance = false;
                
                //random number generation
                Random random = new Random();


                int randomNumber = random.Next(2) + 1;
                if (randomNumber == 1)
                {
                    enemy.OnAttack(-4);
                }
                else
                {
                    player.OnAttack(-4);
                }
                UpdateHealthBars();
                if (player.Health <= 0 || enemy.Health <= 0)
                {
                    FrmLevel.hideEnemy(enemy);
                    instance = null;
                    Close();
                }
                Potion_image.Image = Properties.Resources.Empty;

            }
        }

        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
            buttonFlee.Visible = true;
        }

        private void buttonFlee_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int randInt = rng.Next(2);
            if (randInt == 0)
            {
                instance = null;
                Close();
            }
            else
            {
                enemy.AttackEvent += PlayerDamage;
                enemy.OnAttack(-2);
                UpdateHealthBars();
                if (player.Health <= 0)
                {
                    instance = null;
                    Close();
                }
                enemy.AttackEvent -= PlayerDamage;
            }
        }

        private void FrmBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

       
    }
}
