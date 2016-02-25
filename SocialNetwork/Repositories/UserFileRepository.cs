using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SocialNetwork.Repositories
{
    class UserFileRepository : IUserRepository
    {
        readonly string path;

        public UserFileRepository(string path)
        {
            if (string.IsNullOrWhiteSpace(path) == true)
                throw new ArgumentNullException(nameof(path));

            this.path = path;

            // Да сме сигурни, че ще има създаден файл
            if (File.Exists(path) == false)
                File.Create(path);
        }

        // Това не връща true / false зареди Tell don't ask 
        // http://www.c-sharpcorner.com/UploadFile/b1df45/tell-dont-ask-design-principle/
        public void Create(User user)
        {
            Validate(user);

            //Writing user info in the file
            try
            {
                // Виж https://msdn.microsoft.com/en-us/library/yh598w02.aspx
                using (var stream = new FileStream(path, FileMode.Append, FileAccess.Write))
                using (var sw = new StreamWriter(stream))
                {
                    sw.WriteLine(user.UserName);
                    sw.WriteLine(user.Password);
                    sw.WriteLine(user.FirstName);
                    sw.WriteLine(user.LastName);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public User Get(string userName)
        {
            // Това е супер не ефективно.. всеки пък като търсим един взимаме всичките... ама файлове :)
            var allUsers = GetAll();
            // разгледай c# Linq
            return allUsers.SingleOrDefault(x => x.UserName == userName);
        }

        public IList<User> GetAll()
        {
            var users = new List<User>();
            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var reader = new StreamReader(stream))
                {
                    while (reader.EndOfStream == false)
                    {
                        try
                        {
                            var user = new User(reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine()); ;
                            users.Add(user);
                        }
                        catch (Exception ex)
                        {
                            // # Продължаваме напред, Давай Кобра
                            // Само на дебъг ще гръмне
#if DEBUG
                            throw ex;
#endif
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return users;
        }

        void Validate(User user)
        {
            var found = Get(user.UserName);
            if (ReferenceEquals(found, null) == false)
                throw new Exception("User already exists");
        }
    }
}
