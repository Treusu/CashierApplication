namespace CashierApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginAccount()); 
        }
    }
}

namespace UserAccountNamespace
{
    public abstract class UserAccount
    {
        protected string username;
        protected string password;
        protected string full_name;
        protected string department;

        public UserAccount(string name, string dept, string uname, string pwd)
        {
            full_name = name;
            department = dept;
            username = uname;
            password = pwd;
        }

        public abstract bool validateLogin(string uname, string pwd);
    }

    public class Cashier : UserAccount
    {
        public Cashier(string name, string dept, string uname, string pwd)
            : base(name, dept, uname, pwd) { }

        public override bool validateLogin(string uname, string pwd)
        {
            return username.Equals(uname) && password.Equals(pwd);
        }

        public string WelcomeMessage => $"Welcome {full_name} of {department}";
    }
}

namespace ItemNamespace
{
    public abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
        }

        public abstract double getTotalPrice();

        public virtual void setPayment(double amount)
        {
            total_price = getTotalPrice();
        }
    }

    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            item_discount = discount * 0.01; 
        }

        public override double getTotalPrice()
        {
            discounted_price = item_price - (item_price * item_discount);
            return discounted_price * item_quantity;
        }

        public override void setPayment(double amount)
        {
            base.setPayment(amount);
            payment_amount = amount;
            change = payment_amount - getTotalPrice();
        }

        public double getChange()
        {
            return change;
        }
    }
}