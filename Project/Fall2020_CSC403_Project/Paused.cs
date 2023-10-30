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
    public partial class Paused : Form
    {
        public Paused()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "Pause Menu";
            label.Font = new Font("Arial", 24, FontStyle.Bold); // Optional: set font size and style
            label.TextAlign = ContentAlignment.MiddleCenter; // Optional: center the text

            // Measure the size of the text and set the label's size accordingly
            Size textSize = TextRenderer.MeasureText(label.Text, label.Font);
            label.Size = textSize;

            // Position the label in the top-left corner with a margin
            label.Location = new Point(20, 20);

            Controls.Add(label);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form currentForm = MyApplicationContext.GetCurrentInstance();

            if(currentForm is FrmLevel)
            {
                FrmLevel.enablePlayerMove();
            }
            if (currentForm is FrmLevel2)
            { 
                FrmLevel2.enablePlayerMove();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Items form2 = new Items();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quit form3 = new Quit();
            form3.ShowDialog();
        }
    }
}
