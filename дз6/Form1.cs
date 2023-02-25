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
   public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Product prod = null;
        public Product p = null;
        int index;
        public Form1()
        {
            InitializeComponent();
            Ok.Enabled = false;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || numericUpDown1.Value == 0|| numericUpDown2.Value==0)
            {
                MessageBox.Show("Name can't be empty. Cost can't be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            prod = new Product(textBox1.Text, numericUpDown1.Value, numericUpDown2.Value);
            form2.Products.Items.Add(prod);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
  
           DialogResult result = form2.ShowDialog();
           if(result== DialogResult.OK)
            {
                textBox1.Text = "";
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
            }
           if(result == DialogResult.Yes) {
                
                index = form2.Products.SelectedIndex;
                Product p = (Product)form2.Products.SelectedItem;
                
                this.textBox1.Text = p.Name;
                this.numericUpDown1.Value = p.Cost;
                this.numericUpDown2.Value = p.Count;
                this.numericUpDown3.Value = p.FinalCost;
                Ok.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;

            }
           
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            prod = new Product(textBox1.Text, numericUpDown1.Value, numericUpDown2.Value);
            form2.Products.Items.RemoveAt(index);
            form2.Products.Items.Insert(index, prod.ToString());
            Ok.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Value = numericUpDown2.Value * numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Value = numericUpDown2.Value * numericUpDown1.Value;
        }

    }
}
