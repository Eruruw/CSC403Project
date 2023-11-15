using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmIntermisson : Form
    {
        public FrmIntermisson()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Intermission_Music);
            simpleSound.Play();
            InitializeComponent();
            Store_Panel.Hide();
            updateMoney();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyApplicationContext.SwitchToFrmMainMenu();
            CheckpointManager.SaveInventory();
        }

        private void Continue_Button_Click(object sender, EventArgs e)
        {
            MyApplicationContext.SwtichToFrmLevel2();
            CheckpointManager.SaveInventory();
        }

        private void store_button_Click(object sender, EventArgs e)
        {
            Store_Panel.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Store_Panel.Hide();
        }

        private void updateMoney()
        {
            MoneyVal.Text = "$" + MyApplicationContext.cash.ToString();
        }

        private void potion_Click(object sender, EventArgs e)
        {

            var healthPotionRecord = MyApplicationContext.inventory.InventoryRecords.FirstOrDefault(record => record.InventoryItem.Name == "Health Potion");

           
            if (MyApplicationContext.cash >= 100 && InventorySystem.InvFull == false)
            {
                
                MyApplicationContext.inventory.AddItem(MyApplicationContext.potion, 1);
                MyApplicationContext.cash -= 100;
                updateMoney();
                MessageBox.Show("A health potion has been added to your inventory", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            }
            else
            {
                MessageBox.Show("You need more money", "YOU'RE BROKE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
