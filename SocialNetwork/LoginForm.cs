using System;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class LoginForm : Form
    {
        public User loggedUser;
        IUserRepository userRepository;
        public LoginForm(IUserRepository userRepository)
        {
            if (ReferenceEquals(userRepository, null) == true)
                throw new ArgumentNullException(nameof(userRepository));

            this.userRepository = userRepository;
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string currentUserName = textBox_Username.Text.ToString().Trim();
            string currentPass = textBox_Password.Text.ToString().Trim();

            var user = userRepository.Get(currentUserName);

            if (ReferenceEquals(user, null) == false && user.Password == currentPass)
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
