namespace onlineShop
{
    partial class AdminMockup
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
            this.usersButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.editProducts = new System.Windows.Forms.Button();
            this.manageCustomersbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(48, 238);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(117, 36);
            this.usersButton.TabIndex = 0;
            this.usersButton.Text = "Show users";
            this.usersButton.UseVisualStyleBackColor = true;
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(48, 156);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(117, 37);
            this.ordersButton.TabIndex = 1;
            this.ordersButton.Text = "Show orders";
            this.ordersButton.UseVisualStyleBackColor = true;
            // 
            // editProducts
            // 
            this.editProducts.Location = new System.Drawing.Point(48, 312);
            this.editProducts.Name = "editProducts";
            this.editProducts.Size = new System.Drawing.Size(117, 38);
            this.editProducts.TabIndex = 2;
            this.editProducts.Text = "Edit products";
            this.editProducts.UseVisualStyleBackColor = true;
            // 
            // manageCustomersbtn
            // 
            this.manageCustomersbtn.Location = new System.Drawing.Point(48, 386);
            this.manageCustomersbtn.Name = "manageCustomersbtn";
            this.manageCustomersbtn.Size = new System.Drawing.Size(146, 42);
            this.manageCustomersbtn.TabIndex = 6;
            this.manageCustomersbtn.Text = "Manage customers";
            this.manageCustomersbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitlu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(238, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 468);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.ordersButton);
            this.panel2.Controls.Add(this.manageCustomersbtn);
            this.panel2.Controls.Add(this.usersButton);
            this.panel2.Controls.Add(this.editProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 468);
            this.panel2.TabIndex = 8;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitlu.Location = new System.Drawing.Point(246, 23);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(85, 46);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(48, 75);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(105, 38);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button usersButton;
        private Button ordersButton;
        private Button editProducts;
        private Button manageCustomersbtn;
        private Panel panel1;
        private Panel panel2;
        private Label lblTitlu;
        private Button btnDashboard;
    }
}