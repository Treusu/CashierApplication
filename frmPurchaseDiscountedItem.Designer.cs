
using ItemNamespace;

namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Item = new TextBox();
            label2 = new Label();
            Discount = new TextBox();
            label3 = new Label();
            Price = new TextBox();
            Quantity = new TextBox();
            label4 = new Label();
            Total = new Label();
            Compute = new Button();
            Payment = new TextBox();
            Paymentlbl = new Label();
            Submit = new Button();
            Change = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // Item
            // 
            Item.Font = new Font("Segoe UI", 12F);
            Item.Location = new Point(12, 33);
            Item.Name = "Item";
            Item.Size = new Size(210, 29);
            Item.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(239, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 2;
            label2.Text = "Discount (%):";
            // 
            // Discount
            // 
            Discount.Font = new Font("Segoe UI", 12F);
            Discount.Location = new Point(239, 33);
            Discount.Name = "Discount";
            Discount.Size = new Size(131, 29);
            Discount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI", 12F);
            Price.Location = new Point(65, 68);
            Price.Name = "Price";
            Price.Size = new Size(157, 29);
            Price.TabIndex = 5;
            // 
            // Quantity
            // 
            Quantity.Font = new Font("Segoe UI", 12F);
            Quantity.Location = new Point(318, 68);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(52, 29);
            Quantity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(239, 67);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 6;
            label4.Text = "Quantity:";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 12F);
            Total.Location = new Point(154, 157);
            Total.Name = "Total";
            Total.Size = new Size(0, 21);
            Total.TabIndex = 9;
            // 
            // Compute
            // 
            Compute.Font = new Font("Segoe UI", 12F);
            Compute.Location = new Point(163, 108);
            Compute.Name = "Compute";
            Compute.Size = new Size(82, 31);
            Compute.TabIndex = 11;
            Compute.Text = "Compute";
            Compute.UseVisualStyleBackColor = true;
            Compute.Click += Compute_Click;
            // 
            // Payment
            // 
            Payment.Font = new Font("Segoe UI", 12F);
            Payment.Location = new Point(154, 190);
            Payment.Name = "Payment";
            Payment.Size = new Size(123, 29);
            Payment.TabIndex = 13;
            // 
            // Paymentlbl
            // 
            Paymentlbl.AutoSize = true;
            Paymentlbl.Font = new Font("Segoe UI", 12F);
            Paymentlbl.Location = new Point(9, 190);
            Paymentlbl.Name = "Paymentlbl";
            Paymentlbl.Size = new Size(139, 21);
            Paymentlbl.TabIndex = 12;
            Paymentlbl.Text = "Payment Received:";
            // 
            // Submit
            // 
            Submit.Font = new Font("Segoe UI", 12F);
            Submit.Location = new Point(283, 189);
            Submit.Name = "Submit";
            Submit.Size = new Size(82, 31);
            Submit.TabIndex = 14;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click_1;
            // 
            // Change
            // 
            Change.AutoSize = true;
            Change.Font = new Font("Segoe UI", 12F);
            Change.Location = new Point(154, 234);
            Change.Name = "Change";
            Change.Size = new Size(0, 21);
            Change.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(82, 234);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 16;
            label5.Text = "Change:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(43, 157);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 17;
            label6.Text = "Total Amount:";
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 267);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Change);
            Controls.Add(Submit);
            Controls.Add(Payment);
            Controls.Add(Paymentlbl);
            Controls.Add(Compute);
            Controls.Add(Total);
            Controls.Add(Quantity);
            Controls.Add(label4);
            Controls.Add(Price);
            Controls.Add(label3);
            Controls.Add(Discount);
            Controls.Add(label2);
            Controls.Add(Item);
            Controls.Add(label1);
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted Item";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Submit_Click_1(object sender, EventArgs e)
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
        #endregion

        private Label label1;
        private TextBox Item;
        private Label label2;
        private TextBox Discount;
        private Label label3;
        private TextBox Price;
        private TextBox Quantity;
        private Label label4;
        private Label Total;
        private Button Compute;
        private TextBox Payment;
        private Label Paymentlbl;
        private Button Submit;
        private Label Change;
        private Label label5;
        private Label label6;
    }
}
