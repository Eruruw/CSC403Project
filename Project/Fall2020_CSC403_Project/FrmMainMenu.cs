using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            InitializeComponent();
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
    }
}
