﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int g = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g++;
            label3.Text = g.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 shopForm = new Form2();
            // Show the shop form
            shopForm.Show();
        }
    }
}
