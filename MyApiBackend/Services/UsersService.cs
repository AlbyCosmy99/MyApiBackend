using MyApiBackend.Models;

namespace MyApiBackend.Services
{
    public interface IUsersService
    {
        string getUsername();
        User GetUser();
    }
    public class UsersService : IUsersService
    {
        public string getUsername()
        {
            return "Andrei";
        }

        public User GetUser()
        {
            return new User()
            {
                Id = 1,
                Name = "Andrei",
                Surname = "Albu"
            };
        }
    }
}
