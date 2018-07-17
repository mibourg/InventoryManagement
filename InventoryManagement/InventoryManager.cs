using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventoryManagement
{
    public partial class InventoryManager : Form
    {
        public InventoryManager()
        {
            InitializeComponent();
        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("InventoryDatabase.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string name = line;
                double price = Convert.ToDouble(streamReader.ReadLine());
                int supply = Convert.ToInt32(streamReader.ReadLine());
                streamReader.ReadLine();
                Inventory.Items.Add(new Item(name, price, supply));
            }
            streamReader.Close();

            //Populate listbox
            itemsListBox.DataSource = Inventory.Items;
            itemsListBox.DisplayMember = "Name";
        }

        private void InventoryManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("InventoryDatabase.txt");
            foreach (Item item in Inventory.Items)
            {
                streamWriter.WriteLine(item.Name);
                streamWriter.WriteLine(item.Price);
                streamWriter.WriteLine(item.Supply);
                streamWriter.WriteLine();
            }
            streamWriter.Close();
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                priceLabel.Text = "$" + Inventory.Items.ElementAt(itemsListBox.SelectedIndex).Price.ToString();
                supplyLabel.Text = Inventory.Items.ElementAt(itemsListBox.SelectedIndex).Supply.ToString();
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (addNameTextBox.Text.Length > 0 || addPriceTextBox.Text.Length > 0 || addSupplyTextBox.Text.Length > 0)
            {
                string name = addNameTextBox.Text;
                double price;
                try
                {
                    price = Convert.ToDouble(addPriceTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Price/Supply must be a number.");
                    return;
                }

                int supply;
                try
                {
                    supply = Convert.ToInt32(addSupplyTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Price/Supply must be a number.");
                    return;
                }

                Inventory.Items.Add(new Item(name, price, supply));
                addNameTextBox.Clear();
                addPriceTextBox.Clear();
                addSupplyTextBox.Clear();
                addNameTextBox.Select();
                
                //Update listbox
                itemsListBox.DataSource = null;
                itemsListBox.Items.Clear();
                itemsListBox.DataSource = Inventory.Items;
                itemsListBox.DisplayMember = "Name";
                itemsListBox.Refresh();
                itemsListBox.SelectedIndex = itemsListBox.Items.Count - 1;

                updateDatabase();
            }
        }

        private void updatePriceButton_Click(object sender, EventArgs e)
        {
            if (newPriceTextBox.Text.Length > 0)
            {
                double newPrice;

                try
                {
                    newPrice = Convert.ToDouble(newPriceTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Price must be a number.");
                    return;
                }

                Item itemToChange = Inventory.Items.ElementAt(itemsListBox.SelectedIndex);
                itemToChange.Price = newPrice;

                Inventory.Items.RemoveAt(itemsListBox.SelectedIndex);
                Inventory.Items.Insert(itemsListBox.SelectedIndex, itemToChange);

                newPriceTextBox.Clear();

                int index = itemsListBox.SelectedIndex;

                //Update listbox
                itemsListBox.DataSource = null;
                itemsListBox.Items.Clear();
                itemsListBox.DataSource = Inventory.Items;
                itemsListBox.DisplayMember = "Name";
                itemsListBox.Refresh();
                itemsListBox.SelectedIndex = index;

                updateDatabase();
            }
        }

        private void updateSupplyButton_Click(object sender, EventArgs e)
        {
            if (newSupplyTextBox.Text.Length > 0)
            {
                int newSupply;

                try
                {
                    newSupply = Convert.ToInt32(newSupplyTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Supply must be a whole number.");
                    return;
                }

                Item itemToChange = Inventory.Items.ElementAt(itemsListBox.SelectedIndex);
                itemToChange.Supply = newSupply;

                Inventory.Items.RemoveAt(itemsListBox.SelectedIndex);
                Inventory.Items.Insert(itemsListBox.SelectedIndex, itemToChange);

                newSupplyTextBox.Clear();
                int index = itemsListBox.SelectedIndex;

                //Update listbox
                itemsListBox.DataSource = null;
                itemsListBox.Items.Clear();
                itemsListBox.DataSource = Inventory.Items;
                itemsListBox.DisplayMember = "Name";
                itemsListBox.Refresh();
                itemsListBox.SelectedIndex = index;

                updateDatabase();
            }
        }

        private void addNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addPriceTextBox.Select();
            }
        }

        private void addPriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addSupplyTextBox.Select();
            }
        }

        private void addSupplyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addItemButton.PerformClick();
            }
        }

        private void newPriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updatePriceButton.PerformClick();
            }
        }

        private void newSupplyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateSupplyButton.PerformClick();
            }
        }

        private void updateDatabase()
        {
            StreamWriter streamWriter = new StreamWriter("InventoryDatabase.txt");
            foreach (Item item in Inventory.Items)
            {
                streamWriter.WriteLine(item.Name);
                streamWriter.WriteLine(item.Price);
                streamWriter.WriteLine(item.Supply);
                streamWriter.WriteLine();
            }
            streamWriter.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (Inventory.Items.Count > 0)
            {
                int index = itemsListBox.SelectedIndex;
                Inventory.Items.RemoveAt(index);

                if (Inventory.Items.Count == 0)
                {
                    priceLabel.Text = "";
                    supplyLabel.Text = "";
                }

                //Update listbox
                itemsListBox.DataSource = null;
                itemsListBox.Items.Clear();
                itemsListBox.DataSource = Inventory.Items;
                itemsListBox.DisplayMember = "Name";
                itemsListBox.Refresh();
                if (Inventory.Items.Count > 0)
                {
                    itemsListBox.SelectedIndex = 0;
                }
                
                updateDatabase();
            }
        }
    }
}
