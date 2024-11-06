using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsGrowApp
{
    public partial class WelcomeForm : Form
    {
        private static WelcomeForm instance;
        public WelcomeForm()
        {
            InitializeComponent();
            btnRegister.Click += btnRegister_Click;
            btnLogin.Click += btnLogin_Click;
        }

        public static WelcomeForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WelcomeForm();
            }
            return instance;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
