using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public class MyApplicationContext : ApplicationContext
    {
        private static Form currentForm;

        public MyApplicationContext()
        {
            // Start with MainMenuForm as the main form
            currentForm = new FrmMainMenu();
            currentForm.Show();
        }

        public static void SwitchToFrmLevel()
        {
            // Close the current form
            currentForm.Close();

            // Create and show FrmLevel
            currentForm = new FrmLevel();
            currentForm.Show();
        }
        public static void SwitchToFrmMainMenu()
        {
            // Close the current form
            currentForm.Close();

            //Create and Show Main Menu
            currentForm = new FrmMainMenu();
            currentForm.Show();
        }
    }
}
