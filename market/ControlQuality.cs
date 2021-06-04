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
    public partial class ControlQuality : Form
    {
        public ControlQuality()
        {
            InitializeComponent();
            var name = Program.context.Product.Select(t => t.Name).ToList();
            foreach (var item in name)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ControlQuality_Load(object sender, EventArgs e)
        {
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                var row = new string[] { item.ID,item.Name,item.Date,item.QualityStatus };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentproduct = Program.context.Product.FirstOrDefault(t => t.Name == comboBox1.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == currentproduct.ID)
                {
                    item.SubItems[3].Text = "تایید شده";
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentproduct = Program.context.Product.FirstOrDefault(t => t.Name == comboBox1.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == currentproduct.ID)
                {
                    item.SubItems[3].Text = "تایید نشد";
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
