using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз6
{
    public partial class Form2 : Form
    {

        //public Product prod = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           
            Products.Items.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Products.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to remove it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Products.Items.RemoveAt(Products.SelectedIndex);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Products.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to edit it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.Yes;
            
        }
    }
}
