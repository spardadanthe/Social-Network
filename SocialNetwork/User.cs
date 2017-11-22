using System;


namespace SocialNetwork
{

    public class User
    {
        public User(string userName, string password, string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(userName) == true)
                throw new ArgumentNullException(nameof(userName));

            if (string.IsNullOrWhiteSpace(password) == true)
                throw new ArgumentNullException(nameof(password));

            if (string.IsNullOrWhiteSpace(firstName) == true)
                throw new ArgumentNullException(nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName) == true)
                throw new ArgumentNullException(nameof(lastName));

            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        public string UserName { get; private set; }

        public string Password { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}
