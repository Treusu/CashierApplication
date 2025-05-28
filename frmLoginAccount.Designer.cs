namespace CashierApplication
{
    partial class frmLoginAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 12F);
            Username.Location = new Point(12, 33);
            Username.Name = "Username";
            Username.Size = new Size(174, 29);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 12F);
            Password.Location = new Point(12, 93);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(174, 29);
            Password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.GhostWhite;
            button1.Location = new Point(12, 130);
            button1.Name = "button1";
            button1.Size = new Size(174, 35);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 184);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "User Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Username;
        private TextBox Password;
        private Label label2;
        private Button button1;
    }
}