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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "Item Menu";
            label.Font = new Font("Arial", 24, FontStyle.Bold); // Optional: set font size and style
            label.TextAlign = ContentAlignment.MiddleCenter; // Optional: center the text
            label.Dock = DockStyle.Fill; // Optional: fill the entire form
            Controls.Add(label);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
