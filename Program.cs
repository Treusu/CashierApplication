namespace CashierApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPurchaseDiscountedItem());
        }
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