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
    public partial class FrmIntermisson : Form
    {
        public FrmIntermisson()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Intermission_Music);
            simpleSound.Play();
            InitializeComponent();
            Store_Panel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyApplicationContext.SwitchToFrmMainMenu();
        }

        private void Continue_Button_Click(object sender, EventArgs e)
        {
            MyApplicationContext.SwtichToFrmLevel2();
        }

        private void store_button_Click(object sender, EventArgs e)
        {
            Store_Panel.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Store_Panel.Hide();
        }
    }
}
