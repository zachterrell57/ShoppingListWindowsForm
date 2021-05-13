using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListWindowsForm
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// List of all items that have been checked off
        /// </summary>
        private List<int> checkedIndices = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EraseButton_Click(object sender, EventArgs e)
        {
            ItemListBox.Items.Clear();
        }

        /// <summary>
        /// Easy way to add common items to list with once click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonItemsButton_Click(object sender, EventArgs e)
        {
            ItemListBox.Items.Add("Bread");
            ItemListBox.Items.Add("Chicken");
            ItemListBox.Items.Add("Cheese");
            ItemListBox.Items.Add("Milk");
            ItemListBox.Items.Add("Mac N Cheese");
            ItemListBox.Items.Add("Soap");
            ItemListBox.Items.Add("Coffee");
            ItemListBox.Items.Add("Fruit");
            ItemListBox.Items.Add("Eggs");
        }              

        /// <summary>
        /// Adds item from textbox to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(ItemTextBox.Text != null)
            {
                ItemListBox.Items.Add(ItemTextBox.Text);
                ItemTextBox.Clear();
            }
        }

        /// <summary>
        /// Checks off the item and adds the time for easy reference
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckButton_Click(object sender, EventArgs e)
        {

            // Makes sure the item hasn't already been checked
            bool flag = false;
            foreach (int index in checkedIndices)
            {
                if (index == ItemListBox.SelectedIndex)
                {
                    flag = true;
                }
            }

            if (!(flag == true))
            {
                ItemListBox.Items[ItemListBox.SelectedIndex] = ItemListBox.SelectedItem + " | Got it! | " + DateTime.Now.ToShortTimeString();
                checkedIndices.Add(ItemListBox.SelectedIndex);
            }
            Application.DoEvents(); // updates listbox, found on Microsoft website
        }
    }
}
