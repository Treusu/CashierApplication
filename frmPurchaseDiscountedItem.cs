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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip menu = new MenuStrip();
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");

            ToolStripMenuItem logoutItem = new ToolStripMenuItem("Logout");
            logoutItem.Click += (s, e) => {
                this.Close();
                new frmLoginAccount().Show();
            };

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += (s, e) => Application.Exit();

            fileMenu.DropDownItems.Add(logoutItem);
            fileMenu.DropDownItems.Add(exitItem);
            menu.Items.Add(fileMenu);

            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
        }
    }
}
