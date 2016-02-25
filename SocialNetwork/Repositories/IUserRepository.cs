using System.Collections.Generic;

namespace SocialNetwork
{
    // Може да имаме конкретни имплементации на този интерфейс с файловата система, някаква база и.т.н
    // но като работим с интерфейс ще сменим само коя импелемтация се ползва т.е на 1 място
    public interface IUserRepository
    {
        void Create(User user);
        User Get(string userName);
        IList<User> GetAll();
    }
}
