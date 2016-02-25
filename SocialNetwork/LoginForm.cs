using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class LoginForm : Form
    {
        public User loggedUser;
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var initialForm = new InitialForm();
            if (initialForm.Visible == false)
            {
                initialForm.Show();
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            List<User> users = User.GetAllUsers();
            bool logged = false;
            string currentUser = textBox_Username.Text.ToString().Trim();
            string currentPass = textBox_Password.Text.ToString().Trim();
            foreach (User user in users)
            {
                if (currentUser == user.Username && currentPass == user.Password)
                {
                    logged = true;
                    loggedUser = user;
                    break;
                }
            }
            if (logged)
            {
                this.Hide();
                var mainWindow = new MainWindow();
                mainWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
