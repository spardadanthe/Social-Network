using System;
using System.IO;
using System.Windows.Forms;
using SocialNetwork.Repositories;

namespace SocialNetwork
{
    static class SocialNetworkMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "users.txt");
            IUserRepository userRepository = new UserFileRepository(path);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialForm(userRepository));
        }
    }
}
