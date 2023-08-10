using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.user.models;
using onlineShop.user.service;
using onlineShop.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.loginPage
{
    internal class LoginPage : Panel
    {
        private UserService users;
        private Panel pnlLoginData = new Panel();
        private PictureBox login = new PictureBox();
        private MainPage form;
        private ProductService produse;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        private TextBox password;
        private TextBox username;

        public LoginPage(MainPage mainPage, ProductService productService, OrderService orders, OrderDetailsService orderDetails, UserService userService)
        {
            this.Name = Constants.LOGIN_PANEL;

            this.users = userService;

            setMainContainer();
            setLoginContainer();

            this.form = mainPage;
            this.produse = productService;
            this.orderService = orders;
            this.orderDetailsService=orderDetails;

            mainPage.Controls.Add(this);
        }


        public bool verifyUser(string username, string password)
        {
            for(int i=0; i < users.Users.Count(); i++)
            {
                if (users.Users[i].Username.Equals(username) == true && users.Users[i].Password.Equals(password) == true)
                {
                    return true;
                }
            }

            return false;
        }
         
        public bool validateLogin(TextBox username, TextBox password)
        {
            string text = "";

            if (username.Text.Equals(""))
            {
                text += "Enter your username\n";
            }
            if (password.Text.Equals(""))
            {
                text += "Enter your password\n";
            }

            if (text.Length > 0)
            {
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void setLoginContainer()
        {
            PictureBox usernameIcon = new PictureBox();
            PictureBox passwordIcon = new PictureBox();

            usernameIcon.Image = Image.FromFile("D:\\mycode\\icons\\1160865.png");
            usernameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            usernameIcon.Location = new Point(0, 58);
            usernameIcon.Size = new Size(52, 41);

            passwordIcon.Image = Image.FromFile("D:\\mycode\\icons\\download.png");
            passwordIcon.SizeMode = PictureBoxSizeMode.Zoom;
            passwordIcon.Location = new Point(0, 150);
            passwordIcon.Size = new Size(52, 47);

            username = new TextBox();
            Panel pnlLine1 = new Panel();

            username.PlaceholderText = " Username";
            username.Font = new Font("Century Gothic", 16, FontStyle.Regular);
            username.Multiline = true;
            username.Location = new Point(55, 50);
            username.Size = new Size(500, 50);

            pnlLine1.Location = new Point(0, 100);
            pnlLine1.Size = new Size(500, 3);
            pnlLine1.BackColor = Color.PaleTurquoise;


            password = new TextBox();
            Panel pnlLine2 = new Panel();

            password.PlaceholderText = " Password";
            password.Font = new Font("Century Gothic", 16, FontStyle.Regular);
            password.Multiline = true;
            password.Location = new Point(55, 151);
            password.Size = new Size(500, 50);

            pnlLine2.Location = new Point(0, 200);
            pnlLine2.Size = new Size(500, 3);
            pnlLine2.BackColor = Color.PaleTurquoise;

            CheckBox remember = new CheckBox();

            remember.Text = "Remember me";
            remember.Location = new Point(20, 350);
            remember.Size = new Size(300, 30);

            pnlLoginData.BackColor = Color.White;
            pnlLoginData.Location = new Point(750, 300);
            pnlLoginData.Size = new(500, 400);

            pnlLoginData.Controls.Add(usernameIcon);
            pnlLoginData.Controls.Add(username);
            pnlLoginData.Controls.Add(pnlLine1);
            pnlLoginData.Controls.Add(passwordIcon);
            pnlLoginData.Controls.Add(password);
            pnlLoginData.Controls.Add(pnlLine2);
            pnlLoginData.Controls.Add(remember);

            this.Controls.Add(pnlLoginData);


        }

        private void setMainContainer()
        {
            Label titlu = new Label();
            Label forgotPassword = new Label();

            login.Image = Image.FromFile("D:\\mycode\\icons\\login.png");
            login.SizeMode = PictureBoxSizeMode.Zoom;
            login.Location = new Point(900, 700);
            login.Size = new Size(200, 200);

            login.Click += login_Click;

            titlu.Text = "Online Shop";
            titlu.Size = new Size(300, 100);
            titlu.Location = new Point(850, 130);
            titlu.Font = new Font("Century Gothic", 26, FontStyle.Bold);
            titlu.ForeColor = Color.FromArgb(74, 85, 162);

            forgotPassword.Text = "Forgot password";
            forgotPassword.Location = new Point(950, 900);

            this.BackColor = Color.FromArgb(197, 223, 248);
            this.Dock = DockStyle.Fill;

            setLoginContainer();

            this.Controls.Add(titlu);
            this.Controls.Add(login);
            

        }

        private void login_Click(object sender, EventArgs e)
        {

            if (validateLogin(username, password) == true)
            {
                if (verifyUser(username.Text, password.Text) == true)
                {
                    form.removeControl("pnlLogin");

                    this.PerformLayout();

                    form.setProductsPage(produse, orderService, orderDetailsService);
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
