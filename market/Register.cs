using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MoqTest.Context.Models;

namespace market
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(password_reg.Text == password_reg2.Text)
            {
                Program.context.Users.Add(new User() { UserName = username_reg.Text , Password = password_reg.Text, Role = "Customer",PhoneNumber=phonenumber_txt.Text,Address=address_txt.Text, });
                //MessageBox.Show("ثبت نام با موفقیت انجام شد","registering",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
                new Login().Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("لطفا اطلاعات را با دقت وارد کنید", "registering", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                new Register().Show();
            }
           

        }
    }
}
