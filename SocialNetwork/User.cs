using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class User
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;


        public User()
        {

        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value == string.Empty)
                {
                    //throw new Exception("You cannot leave a blank field");
                }
                else
                {
                    this.username = value;
                }
            }

        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }




        public static List<User> GetAllUsers()
        {
            var users = new List<User>();
            if (File.Exists("users.txt"))
            {
                var stream = new FileStream("users.txt", FileMode.Open, FileAccess.Read);
                var reader = new StreamReader(stream);

                while (reader.EndOfStream == false)
                {
                    var user = new User();
                    user.Username = reader.ReadLine();
                    user.Password = reader.ReadLine();
                    user.FirstName = reader.ReadLine();
                    user.LastName = reader.ReadLine();
                    users.Add(user);
                }
                reader.Close();
                stream.Close();

            }
            return users;
        }
    }
}
