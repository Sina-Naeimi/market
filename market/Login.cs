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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentUser = Program.context.Users.FirstOrDefault(u => u.UserName.ToLower() == username.Text.ToLower() && u.Password.ToLower() == password.Text.ToLower());
            if (currentUser == null)
            {
                MessageBox.Show("لطفا فیلد هارا با دقت پر کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            else
            {
                switch (currentUser.Role)
                {
                    case "Manager":
                        {
                            new Manager().Show();
                            break;
                        }
                    case "Accountant":
                        {
                            new Accountant().Show();
                            break;
                        }
                    case "Seller":
                        {
                            new Seller().Show();
                            break;
                        }
                    case "Supplier":
                        {
                            new Supplier().Show();
                            break;

                        }
                    case "PriceController":
                        {
                            new PriceController().Show();
                            break;

                        }
                    case "QualityController":
                        {
                            new QualityController().Show();
                            break;

                        }
                    case "Customer":
                        {
                            new Customer().Show();
                            break;
                        }       

                }
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
