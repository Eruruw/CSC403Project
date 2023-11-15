using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
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
            SoundPlayer simpleSound = new SoundPlayer(Resources.Battle_Music);
            simpleSound.Play();
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // reset TP
            player.Tech = 0;

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle()
        {
            ShowHideButtons(false);
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;
            

            
            SoundPlayer simpleSound2 = new SoundPlayer(Resources.Final_Battle_Music);
            simpleSound2.Play();

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
            if (player.Health <= 0) 
            {
                //Application.Exit();
            }

            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float playerManaPer = player.Mana / (float)player.MaxMana;
            float playerTechPer = player.Tech / (float)player.MaxTech;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblPlayerMP.Width = (int)(MAX_HEALTHBAR_WIDTH * playerManaPer);
            lblPlayerTP.Width = (int)(MAX_HEALTHBAR_WIDTH * playerTechPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblPlayerMP.Text = player.Mana.ToString();
            lblPlayerTP.Text = player.Tech.ToString();
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
            player.Tech += 20;
            if (player.Tech > player.MaxTech)
            {
                player.Tech = player.MaxTech;
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                MyApplicationContext.cash += 100;
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
                    player.OnAttack(-8);
                }
                UpdateHealthBars();
                if (player.Health <= 0 || enemy.Health <= 0)
                {
                    FrmLevel.hideEnemy(enemy);
                    instance = null;
                    Close();
                }
                Potion_image.Image = Properties.Resources.Empty;
                enemy.AttackEvent -= PlayerDamage;
                player.AttackEvent -= EnemyDamage;
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

        private void ShowHideButtons(bool show)
        {
            btnAttack.Visible = show;
            btnFlee.Visible = show;
            btnMagic.Visible = show;
            btnSkills.Visible = show;
            potion_button.Visible = show;
        }

        private void ShowHideMagic(bool show)
        {
            btnCutter.Visible = show;
            btnPray.Visible = show;
            btnPyro.Visible = show;
            btnBackMagic.Visible = show;
        }

        private void ShowHideTech(bool show)
        {
            btnFocus.Visible = show;
            btnMeditate.Visible = show;
            btnStrike.Visible = show;
            btnBackTech.Visible = show;
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
            ShowHideButtons(true);
        }

        private void btnFlee_Click(object sender, EventArgs e)
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
                player.Tech += 20;
                if (player.Tech > player.MaxTech)
                {
                    player.Tech = player.MaxTech;
                }
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

        private void btnMagic_Click(object sender, EventArgs e)
        {
            ShowHideButtons(false);
            ShowHideMagic(true);
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            ShowHideButtons(false);
            ShowHideTech(true);
        }

        private void FrmBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btnCutter_Click(object sender, EventArgs e)
        {
            if (player.Mana >= 5)
            {
                ShowHideMagic(false);
                ShowHideButtons(true);
                player.Mana -= 2;
                player.AttackEvent += EnemyDamage;
                player.OnAttack(-1);
                UpdateHealthBars();
                if (enemy.Health <= 0)
                {
                    FrmLevel.hideEnemy(enemy);
                    instance = null;
                    Close();
                }
                player.AttackEvent -= EnemyDamage;
            }
        }

        private void btnPray_Click(object sender, EventArgs e)
        {
            if (player.Mana >= 10)
            {
                ShowHideMagic(false);
                ShowHideButtons(true);
                player.Mana -= 10;
                player.Health += 20;
                if (player.Health > player.MaxHealth)
                {
                    player.Health = player.MaxHealth;
                }
                UpdateHealthBars();
            }
        }

        private void btnPyro_Click(object sender, EventArgs e)
        {
            if (player.Mana >= 20)
            {
                ShowHideMagic(false);
                ShowHideButtons(true);
                player.Mana -= 20;
                player.AttackEvent += EnemyDamage;
                enemy.AttackEvent += PlayerDamage;
                player.OnAttack(-12);
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
                player.AttackEvent -= EnemyDamage;
                enemy.AttackEvent -= PlayerDamage;
            }
        }

        private void btnBackMagic_Click(object sender, EventArgs e)
        {
            ShowHideMagic(false);
            ShowHideButtons(true);
        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            ShowHideTech(false);
            ShowHideButtons(true);
            player.Tech += 40;
            if (player.Tech > player.MaxTech)
            {
                player.Tech = player.MaxTech;
            }
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

        private void btnMeditate_Click(object sender, EventArgs e)
        {
            if (player.Tech >= 30)
            {
                ShowHideMagic(false);
                ShowHideButtons(true);
                player.Tech -= 30;
                player.Mana += 10;
                if (player.Mana > player.MaxMana)
                {
                    player.Mana = player.MaxMana;
                }
                UpdateHealthBars();
            }
        }

        private void btnStrike_Click(object sender, EventArgs e)
        {
            if (player.Tech >= 60)
            {
                ShowHideMagic(false);
                ShowHideButtons(true);
                player.Tech -= 60;
                player.AttackEvent += EnemyDamage;
                enemy.AttackEvent += PlayerDamage;
                player.OnAttack(-8);
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
                player.AttackEvent -= EnemyDamage;
                enemy.AttackEvent -= PlayerDamage;
            }
        }

        private void btnBackTech_Click(object sender, EventArgs e)
        {
            ShowHideMagic(false);
            ShowHideButtons(true);
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }
    }
}