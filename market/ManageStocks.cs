using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MoqTest.Context.Models;
using market.Context.Models;
using System.Linq;

namespace market
{
    public partial class ManageStocks : Form
    {
        public ManageStocks()
        {
            InitializeComponent();
            var name = Program.context.Product.Select(t => t.Name).ToList();
            foreach (var item in name)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void ManageStocks_Load(object sender, EventArgs e)
        {
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                var row = new string[] { item.ID, item.Name, item.Group, item.SubGroup,System.Convert.ToString(item.Stock)};
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void increasebtn_Click(object sender, EventArgs e)
        {
            var currentproduct = Program.context.Product.FirstOrDefault(t => t.Name == comboBox1.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == currentproduct.ID)
                {
                    item.SubItems[4].Text = System.Convert.ToString(currentproduct.Stock + int.Parse(txtCount.Text));
                    break;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void decreasebtn_Click(object sender, EventArgs e)
        {
            var currentproduct = Program.context.Product.FirstOrDefault(t => t.Name == comboBox1.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == currentproduct.ID)
                {
                    item.SubItems[4].Text = System.Convert.ToString(currentproduct.Stock - int.Parse(txtCount.Text));
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
