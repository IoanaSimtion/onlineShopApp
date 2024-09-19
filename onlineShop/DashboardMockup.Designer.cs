namespace onlineShop
{
    partial class DashboardMockup
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
            this.lblSales = new System.Windows.Forms.Label();
            this.lblNewOrders = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSales.Location = new System.Drawing.Point(68, 507);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(66, 31);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sales";
            // 
            // lblNewOrders
            // 
            this.lblNewOrders.AutoSize = true;
            this.lblNewOrders.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewOrders.Location = new System.Drawing.Point(519, 507);
            this.lblNewOrders.Name = "lblNewOrders";
            this.lblNewOrders.Size = new System.Drawing.Size(135, 31);
            this.lblNewOrders.TabIndex = 1;
            this.lblNewOrders.Text = "New Orders";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRevenue.Location = new System.Drawing.Point(998, 509);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(109, 29);
            this.lblRevenue.TabIndex = 2;
            this.lblRevenue.Text = "Revenue";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRevenue);
            this.panel1.Controls.Add(this.lblSales);
            this.panel1.Controls.Add(this.lblNewOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 653);
            this.panel1.TabIndex = 3;
            // 
            // DashboardMockup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 653);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardMockup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblSales;
        private Label lblNewOrders;
        private Label lblRevenue;
        private Panel panel1;
    }
}