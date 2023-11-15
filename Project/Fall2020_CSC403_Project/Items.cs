using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Fall2020_CSC403_Project.code.InventorySystem;

namespace Fall2020_CSC403_Project
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();

            InitializeComponent();

            // Create and configure a DataGridView
            DataGridView dgvInventory = new DataGridView();
            dgvInventory.AutoGenerateColumns = false;

            // Create columns for the DataGridView
            DataGridViewTextBoxColumn itemNameColumn = new DataGridViewTextBoxColumn();
            itemNameColumn.HeaderText = "Item Name";
            itemNameColumn.DataPropertyName = "ItemName"; // Bind to a property of the data source
            itemNameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.DataPropertyName = "Quantity";
            quantityColumn.ReadOnly = true;

            // Add columns to the DataGridView
            dgvInventory.Columns.Add(itemNameColumn);
            dgvInventory.Columns.Add(quantityColumn);

            // Add a row for the potion directly to the DataGridView
            dgvInventory.Rows.Add("Money", MyApplicationContext.cash);
            foreach (var record in MyApplicationContext.inventory.InventoryRecords)
            {
                dgvInventory.Rows.Add(record.InventoryItem.Name, record.Quantity);
            }

            // Set the data source for the DataGridView (not really necessary in this case)
            dgvInventory.DataSource = null;

            // Add the DataGridView to the form
            Controls.Add(dgvInventory);

            // Center the DataGridView within the form
            dgvInventory.Left = (ClientSize.Width - dgvInventory.Width) / 2;
            dgvInventory.Top = (ClientSize.Height - dgvInventory.Height) / 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
