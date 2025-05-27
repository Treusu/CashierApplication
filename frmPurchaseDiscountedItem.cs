using ItemNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Compute_Click(object sender, EventArgs e)
        {
            try
            {
                DiscountedItem item = new DiscountedItem(
                    Item.Text,
                    Convert.ToDouble(Price.Text),
                    Convert.ToInt32(Quantity.Text),
                    Convert.ToDouble(Discount.Text));

                Total.Text = item.getTotalPrice().ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                DiscountedItem item = new DiscountedItem(
                    Item.Text,
                    Convert.ToDouble(Price.Text),
                    Convert.ToInt32(Quantity.Text),
                    Convert.ToDouble(Discount.Text));

                item.setPayment(Convert.ToDouble(Payment.Text));
                Change.Text = item.getChange().ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
