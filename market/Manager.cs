using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace market
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManageUsers().Show();
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProduct().Show();
        }

        private void btnControlQuality_Click(object sender, EventArgs e)
        {
            new ControlQuality().Show();
        }

        private void btnControlPrice_Click(object sender, EventArgs e)
        {
            new ControlPrice().Show();
        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {
            new ManageStocks().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
