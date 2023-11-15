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
    public partial class FrmMainMenu : Form
    {
        private bool leaveFrmMainMenu = false;
        public FrmMainMenu()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Menu_Music);
            simpleSound.Play();
            InitializeComponent();
            LevelSelectPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leaveFrmMainMenu = true;
            MyApplicationContext.SwitchToFrmLevel();
            
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (leaveFrmMainMenu == true)
            {
                //do nothing
            }
            else {
                Application.Exit();
            }
        }

        private void LevelSelectButton_Click(object sender, EventArgs e)
        {
            //grab completed levels as booleans 
            var loadedCompletion = CheckpointManager.LoadLevelCompletion();
            bool isLevel1Complete = loadedCompletion.ContainsKey("Level1") ? loadedCompletion["Level1"] : false;
            bool isLevel2Complete = loadedCompletion.ContainsKey("Level2") ? loadedCompletion["Level2"] : false;
            if (!isLevel1Complete) 
            {
                Level_1_Button.BackgroundImage = Properties.Resources.Level1Locked;
                Level_1_Button.BackgroundImageLayout = ImageLayout.Stretch;
                Level_1_Button.Enabled = false;
            }
            if (!isLevel2Complete)
            { 
                Level_2_Button.BackgroundImage= Properties.Resources.Level2Locked;
                Level_2_Button.BackgroundImageLayout = ImageLayout.Stretch;
                Level_2_Button.Enabled = false;
            }
            Console.WriteLine("Help button clicked");
            LevelSelectPanel.Show();
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            LevelSelectPanel.Hide();
        }

        private void Level_1_Button_Click_1(object sender, EventArgs e)
        {
            leaveFrmMainMenu = true;
            MyApplicationContext.SwitchToFrmLevel();
        }

        private void Level_2_Button_Click_1(object sender, EventArgs e)
        {
            leaveFrmMainMenu = true;
            MyApplicationContext.SwtichToFrmLevel2();
        }

        private void LevelSelectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Help button clicked");

            Help_Panel.Show();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Help_Panel.Hide();
        }

        
    }
}
