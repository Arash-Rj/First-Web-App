using WebApplication1.Models;

namespace WebApplication1.Appsrc.Contract
{
    public interface IUserRepository
    {
        public bool DoesEmailExist(string email);
        public bool DoesPasswordExist(string password);
        public bool CreateUser(string name, string email, string password, int age);
        public List<User> GetAll();
        public User GetByEmail(string email);
    }
}
