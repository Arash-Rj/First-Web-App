using WebApplication1.Models;

namespace WebApplication1.Appsrc.Contract
{
    public interface IUserService
    {
        public bool login(string email, string password);
        public bool Register(string name,string email, string password,int age);
        public List<User> GetAllUsers();
    }
}
