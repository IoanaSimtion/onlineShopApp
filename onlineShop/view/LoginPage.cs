using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineShop.view
{
    public partial class LoginPage : Form
    {
        Panel pnlContainer = new Panel();
        Panel pnlLoginData = new Panel();
        PictureBox login = new PictureBox();
        public LoginPage()
        {
            InitializeComponent();
            setMainContainer();

            this.WindowState = FormWindowState.Maximized;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

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

        public void loginEvent(object sender, EventArgs e)
        {
            //login.Click += new EventHandler()
        }

        private void Login_Load(object sender, EventArgs e)
        {

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

            TextBox username = new TextBox();
            Panel pnlLine1 = new Panel();

            username.PlaceholderText = " Username";
            username.Font = new Font("Century Gothic", 16, FontStyle.Regular);
            username.Multiline = true;
            username.Location = new Point(55, 50);
            username.Size = new Size(500, 50);

            pnlLine1.Location = new Point(0, 100);
            pnlLine1.Size = new Size(500, 3);
            pnlLine1.BackColor = Color.PaleTurquoise;


            TextBox password = new TextBox();
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

            pnlContainer.Controls.Add(pnlLoginData);

            base.ActiveControl = null;

        }

        private void setMainContainer()
        {
            Label titlu = new Label();
            Label forgotPassword = new Label();


            login.Image = Image.FromFile("D:\\mycode\\icons\\login.png");
            login.SizeMode = PictureBoxSizeMode.Zoom;
            login.Location = new Point(900, 700);
            login.Size = new Size(200, 200);

            titlu.Text = "Online Shop";
            titlu.Size = new Size(300, 100);
            titlu.Location = new Point(850, 130);
            titlu.Font = new Font("Century Gothic", 26, FontStyle.Bold);
            titlu.ForeColor = Color.FromArgb(74, 85, 162);

            forgotPassword.Text = "Forgot password";
            forgotPassword.Location = new Point(950, 900);

            pnlContainer.BackColor = Color.FromArgb(197, 223, 248);
            pnlContainer.Dock = DockStyle.Fill;

            setLoginContainer();

            pnlContainer.Controls.Add(titlu);
            pnlContainer.Controls.Add(login);

            this.Controls.Add(pnlContainer);

        }
    }
}
