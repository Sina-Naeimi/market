using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MoqTest.Context.Models;
using market.Context.Models;

namespace market
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            var Name = Program.context.Product.Select(t => t.Name).ToList();
            foreach (var item in Name)
            {
                comboProduct.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = listView1.FindItemWithText(searchtxt.Text);
            if (item1 != null)
            {
                var Product = Program.context.Product.FindAll(t => t.Group == searchtxt.Text || t.Name == searchtxt.Text || t.SubGroup == searchtxt.Text);
                listView1.Items.Clear();
                foreach (var item in Product)
                {
                    if (item.PriceStatus != "تایید نشد" && item.QualityStatus != "تایید نشد")
                    {
                        var row = new string[] { item.Name, System.Convert.ToString(item.Price), System.Convert.ToString(item.Stock), item.Group, item.SubGroup, item.Date, item.PurchaseStatus, };
                        var lvi = new ListViewItem(row);
                        lvi.Tag = item;
                        listView1.Items.Add(lvi);
                    }
                }
            }
            else
            {
                MessageBox.Show("کالا مورد نظر یافت نشد");
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            comboProduct.Text = item.SubItems[0].Text;
            stocktxt.Text = "1";

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                if(item.PriceStatus!= "تایید نشد" && item.QualityStatus!= "تایید نشد")
                {
                    var row = new string[] { item.Name, System.Convert.ToString(item.Price), System.Convert.ToString(item.Stock), item.Group, item.SubGroup, item.Date, item.PurchaseStatus };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = item;
                    listView1.Items.Add(lvi);
                }
                //if (item.QualityStatus=="تایید شده")
                //{
                //    var row = new string[] { item.Name, System.Convert.ToString(item.Price), System.Convert.ToString(item.Stock), item.Group, item.SubGroup, item.Date, };
                //    var lvi = new ListViewItem(row);
                //    lvi.Tag = item;
                //    listView1.Items.Add(lvi);
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CurrentProduct = Program.context.Product.FirstOrDefault(t => t.Name == comboProduct.Text);
            if(CurrentProduct.Stock >= int.Parse(stocktxt.Text))
            {
                CurrentProduct.Stock = CurrentProduct.Stock - int.Parse(stocktxt.Text);
                CurrentProduct.PurchaseCount = stocktxt.Text;
                CurrentProduct.PurchaseStatus = "خریده شد";
            }
            else
            {
                MessageBox.Show("تعداد کالا درخواستی بیشتر از ظرفیت است");
            }
            //if (listView1.SelectedItems.Count == 0)
            //    return;
            //ListViewItem item = listView1.SelectedItems[0];
            //item.SubItems[6].Text = "خریده شد";

            ListViewItem item1 = listView1.FindItemWithText(searchtxt.Text);
            if (item1 != null)
            {
                var Product = Program.context.Product.FindAll(t => t.Group == searchtxt.Text || t.Name == searchtxt.Text || t.SubGroup == searchtxt.Text);
                listView1.Items.Clear();
                foreach (var item2 in Product)
                {
                    if (item2.PriceStatus != "تایید نشد" && item2.QualityStatus != "تایید نشد")
                    {
                        var row = new string[] { item2.Name, System.Convert.ToString(item2.Price), System.Convert.ToString(item2.Stock), item2.Group, item2.SubGroup, item2.Date, item2.PurchaseStatus, };
                        var lvi = new ListViewItem(row);
                        lvi.Tag = item2;
                        listView1.Items.Add(lvi);
                    }
                   
                }
            }
            this.Close();
            new Customer().Show();


            //var currentproduct = Program.context.Product.FirstOrDefault(t => t.Name == comboBox1.Text);
            //foreach (ListViewItem item in listView1.Items)
            //{
            //    if (item.SubItems[0].Text == currentproduct.ID)
            //    {
            //        item.SubItems[3].Text = "تایید شده";
            //        break;
            //    }
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerCart().Show();
            this.Close();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
