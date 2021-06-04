using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace market
{
    public partial class CustomerCart : Form
    {
        public CustomerCart()
        {
            InitializeComponent();
        }

        private void CustomerCart_Load(object sender, EventArgs e)
        {
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                if(item.PurchaseStatus=="خریده شد")
                {
                    var row = new string[] { item.Name, System.Convert.ToString(item.Price),item.PurchaseCount, item.Group, item.SubGroup, item.Date, item.PurchaseStatus };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = item;
                    listView1.Items.Add(lvi);
                }
            }      
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems) { listView1.Items.Remove(eachItem); }
        }
    }
}
