using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Expense_Manager
{
    public partial class enterd : Form
    {
        int date;
        double todAmt;
        double spentAmt;
        double tomAmt;
        public enterd()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
            else if (textBox1.Text != string.Empty)
                textBox3.Text = textBox1.Text;
            else textBox3.Text = "0000";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
            else if (textBox1.Text != string.Empty)
                textBox3.Text = textBox1.Text;
            else textBox3.Text = "0000";
        }
    }
}