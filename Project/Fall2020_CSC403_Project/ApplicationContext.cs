using Fall2020_CSC403_Project.code;
using MyGameLibrary;
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
        public static Form currentForm;
        public static InventorySystem inventory = new InventorySystem();
        public static int cash = 0;

        public static Potion potion = new Potion();
        public static Money money = new Money();   

        public MyApplicationContext()
        {
            //load inventory
            CheckpointManager.LoadInventory();

            // Start with MainMenuForm as the main form
            currentForm = new FrmMainMenu();
            currentForm.Show();
        }
        public static Form GetCurrentInstance()
        {
            return currentForm;
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
            currentForm.Close();

            currentForm = new FrmMainMenu();
            currentForm.Show();
        }
        public static void SwitchToFrmIntermisson() {
            currentForm.Close();

            currentForm = new FrmIntermisson();
            currentForm.Show();
        }
        public static void SwtichToFrmLevel2()
        {
            currentForm.Close();

            currentForm = new FrmLevel2();
            currentForm.Show();
        }
    }
}
