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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            var ID = Program.context.Product.Select(t => t.ID).ToList();
            var Name = Program.context.Product.Select(t => t.Name).ToList();
            var gp = Program.context.Product.Select(t => t.Group).ToList();
            var subgp = Program.context.Product.Select(h => h.SubGroup).ToList();
            foreach (var item in gp)
            {
                Combogp.Items.Add(item);
            }

            foreach (var item in subgp)
            {
                Combosubgp.Items.Add(item);
            }
            foreach (var item in ID)
            {
                ComboId.Items.Add(item);
            }
            foreach (var item in Name)
            {
                ComboName.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.context.Product.Add(new Products() { ID = ComboId.Text , Name =ComboName.Text, Price=int.Parse(Price_txt.Text), Stock = int.Parse(Price_txt.Text), Group= Combogp.Text, SubGroup=Combosubgp.Text, Date = dateTimePicker1.Text });
            //MessageBox.Show($"کالا {ComboName.Text} با موفقیت ثبت شد","ثبت کالا",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                var row = new string[] { item.ID, item.Name, System.Convert.ToString(item.Price), System.Convert.ToString(item.Stock), item.Group, item.SubGroup, item.Date, };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                var row = new string[] {item.ID, item.Name,System.Convert.ToString(item.Price), System.Convert.ToString(item.Stock),item.Group,item.SubGroup,item.Date,};
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var itemToRemove = Program.context.Product.FirstOrDefault(r => r.ID == ComboId.Text);
            Program.context.Product.Remove(itemToRemove);
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                var row = new string[] { item.ID, item.Name, System.Convert.ToString(item.Price), System.Convert.ToString(item.Stock), item.Group, item.SubGroup, item.Date, };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var CurrentProduct = Program.context.Product.FirstOrDefault(t => t.ID == ComboId.Text);
            CurrentProduct.ID = ComboId.Text;
            CurrentProduct.Name = ComboName.Text;
            CurrentProduct.Price = float.Parse(Price_txt.Text);
            CurrentProduct.Stock = int.Parse(Stock_txt.Text);
            CurrentProduct.Group = Combogp.Text;
            CurrentProduct.SubGroup = Combosubgp.Text;
            var Product = Program.context.Product.ToList();
            listView1.Items.Clear();
            foreach (var item in Product)
            {
                var row = new string[] { item.ID, item.Name, System.Convert.ToString(item.Price), System.Convert.ToString(item.Stock), item.Group, item.SubGroup, item.Date, };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void ComboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentUser = Program.context.Product.FirstOrDefault(u => u.ID == ComboId.Text.ToLower());
            ComboName.Text = currentUser.Name;
            Price_txt.Text =System.Convert.ToString(currentUser.Price);
            Stock_txt.Text = System.Convert.ToString(currentUser.Stock);
            Combogp.Text = currentUser.Group;
            Combosubgp.Text = currentUser.SubGroup;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
