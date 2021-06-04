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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            var usernames = Program.context.Users.Select(t => t.UserName).ToList();
            var roles = Program.context.Users.Select(t => t.Role).ToList();
            foreach (var item in usernames)
            {
                comboBox1.Items.Add(item);
            }
            foreach (var item in roles)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentUser = Program.context.Users.FirstOrDefault(u => u.UserName.ToLower() == comboBox1.Text.ToLower());
            txtpassword.Text = currentUser.Password;
            txtpassword.Text = currentUser.Password;
            comboBox2.Text = currentUser.Role;
            txtphone.Text = currentUser.PhoneNumber;
            txtaddress.Text = currentUser.Address;
        }

        private object Users()
        {
            throw new NotImplementedException();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentUser = Program.context.Users.FirstOrDefault(u => comboBox1.Text.ToLower() == u.UserName.ToLower());
            currentUser.UserName = comboBox1.Text;
            currentUser.Password = txtpassword.Text;
            currentUser.Role = comboBox2.Text ;
            currentUser.PhoneNumber = txtphone.Text;
            currentUser.Address = txtaddress.Text;
            MessageBox.Show("تغییرات ثبت شد");
            this.Close();
            new ManageUsers().Show();
            
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            var user = Program.context.Users.ToList();
            listViewpeople.Items.Clear();
            foreach (var person in user)
            {
                var row = new string[] { person.UserName, person.Password, person.Role, person.PhoneNumber, person.Address };
                var lvi = new ListViewItem(row);
                lvi.Tag = person;
                listViewpeople.Items.Add(lvi);
            }
        }

        private void listViewpeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var itemToRemove = Program.context.Users.Single(r => r.UserName == comboBox1.Text);
            Program.context.Users.Remove(itemToRemove);
            var user = Program.context.Users.ToList();
            listViewpeople.Items.Clear();
            foreach (var person in user)
            {
                var row = new string[] { person.UserName, person.Password, person.Role, person.PhoneNumber, person.Address };
                var lvi = new ListViewItem(row);
                lvi.Tag = person;
                listViewpeople.Items.Add(lvi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.context.Users.Add(new User() { UserName = comboBox1.Text, Password = txtpassword.Text, Role = comboBox2.Text, PhoneNumber = txtphone.Text, Address = txtaddress.Text, });
            var user = Program.context.Users.ToList();
            listViewpeople.Items.Clear();
            foreach (var person in user)
            {
                var row = new string[] { person.UserName, person.Password, person.Role, person.PhoneNumber, person.Address };
                var lvi = new ListViewItem(row);
                lvi.Tag = person;
                listViewpeople.Items.Add(lvi);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Manager().Show();
            this.Close();
        }
    }
}
