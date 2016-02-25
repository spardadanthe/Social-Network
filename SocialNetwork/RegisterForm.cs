using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var initialForm = new InitialForm();
            if (initialForm.Visible == false)
            {
                initialForm.Show();
            }
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
            try
            {
                if (textBox_Password.Text.ToString() != textBox_RepeatPassword.Text.ToString())
                {
                    throw new Exception("Passwords doesn't match");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }



            //Checking if the user exists
            var user = new User();
            user.Username = textBox_Username.Text.ToString().Trim();
            user.Password = textBox_Password.Text.ToString().Trim();
            user.FirstName = textBox_FirstName.Text.ToString().Trim();
            user.LastName = textBox_LastName.Text.ToString().Trim();
            
            var users = new List<User>();
            users = User.GetAllUsers();
            

            try
            {
                foreach (User person in users)
                {
                    if (user.Username.Equals(person.Username))
                    {
                        throw new Exception("User already exists");
                    }
                    
                }
                //Writing user info in the file
                var stream = new FileStream("users.txt", FileMode.Append, FileAccess.Write);
                var sw = new StreamWriter(stream);
                sw.WriteLine(user.Username);
                sw.WriteLine(user.Password);
                sw.WriteLine(user.FirstName);
                sw.WriteLine(user.LastName);
                sw.Close();
                stream.Close();

                //Returning to the Inittial Form
                MessageBox.Show("You have successfully registered!", "Registration Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            
            
        }

        private void label_Password_Click(object sender, EventArgs e)
        {

        }
    }

    
}
