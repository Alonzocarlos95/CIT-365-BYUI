﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void backMenuDisplay_Click(object sender, EventArgs e)
        {
            Form exit = new MainMenu();
            exit.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backMenuAdd_Click(object sender, EventArgs e)
        {
            Form exit = new MainMenu();
            exit.Show();
            this.Close();
        }
    }
}
