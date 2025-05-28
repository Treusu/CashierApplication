using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private readonly Cashier cashier = new Cashier(
        "Claris Castro",
        "Finance",
        "cashier101",
        "st1@password");

        public frmLoginAccount()
        {
            InitializeComponent();
            cashier = new Cashier(
                "Claris Castro",
                "Finance",
                "cashier101",
                "st1@password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cashier.validateLogin(Username.Text, Password.Text))
            {
                MessageBox.Show(cashier.WelcomeMessage, "Login Success");
                this.Hide();
                new frmPurchaseDiscountedItem().Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed");
            }
        }
    }
}
