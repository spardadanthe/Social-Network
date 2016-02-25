using System;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class InitialForm : Form
    {
        IUserRepository userRepository;
        public InitialForm(IUserRepository userRepository)
        {
            if (ReferenceEquals(userRepository, null) == true)
                throw new ArgumentNullException(nameof(userRepository));

            this.userRepository = userRepository;
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(userRepository);
            Hide();
            registerForm.ShowDialog();
            Show();
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(userRepository);
            Hide();
            loginForm.ShowDialog();
            Show();
        }
    }
}
