using System;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class RegisterForm : Form
    {
        readonly IUserRepository userRepository;

        public RegisterForm(IUserRepository userRepository)
        {
            if (ReferenceEquals(userRepository, null) == true)
                throw new ArgumentNullException(nameof(userRepository));

            this.userRepository = userRepository;
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_LastName_Click(object sender, EventArgs e)
        {

        }

        private void textBox_RepeatPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.Text != textBox_RepeatPassword.Text)
            {
                label_PasswordMatch.Visible = true;
            }
            else
            {
                label_PasswordMatch.Visible = false;
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            // Checking if passwords match
            if (textBox_Password.Text != textBox_RepeatPassword.Text)
            {
                MessageBox.Show("Passwords doesn't match", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;// за да не продължи надолу
            }
            try
            {
                var userName = textBox_Username.Text.ToString().Trim();
                var password = textBox_Password.Text.ToString().Trim();
                var firstName = textBox_FirstName.Text.ToString().Trim();
                var lastName = textBox_LastName.Text.ToString().Trim();
                var user = new User(userName, password, firstName, lastName);

                userRepository.Create(user);

                //Returning to the Inittial Form
                MessageBox.Show("You have successfully registered!", "Registration Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void label_Password_Click(object sender, EventArgs e)
        {

        }
    }


}
