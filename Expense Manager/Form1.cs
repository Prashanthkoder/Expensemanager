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
    public partial class Form1 : Form
    {
        string nl = Environment.NewLine;
        public string path {
            get
            {
                if (textBox2.Text != string.Empty) return textBox2.Text;
                else return @"C:/Program Files/ExpenseManager";
            }
            set 
            {
                textBox2.Text = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Expense Mangaer v1.0 ~ Created by S.Prashanth Sriram "+nl+nl+"When you are using this for first time, ", "Welcome To Expense Manager v1.0", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new enterd().ShowDialog();
        }
    }
}
