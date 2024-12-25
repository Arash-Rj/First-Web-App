using WebApplication1.Appsrc.Contract;
using WebApplication1.Appsrc.DataBase;
using WebApplication1.Models;

namespace WebApplication1.Appsrc.Repository
{
    public class UserRepository : IUserRepository
    {
        private WebApp1DbContext WebApp1DbContext = new WebApp1DbContext();

        public bool CreateUser(string name, string email, string password, int age)
        {
            User user = new User(name,email,password,age);
            WebApp1DbContext.users.Add(user);
            WebApp1DbContext.SaveChanges();
            return true;
        }

        public bool DoesEmailExist(string email)
        {
           return WebApp1DbContext.users.Any(u => u.Email == email);
        }

        public bool DoesPasswordExist(string password)
        {
            return WebApp1DbContext.users.Any(u => u.Password.Equals(password));
        }

        public List<User> GetAll()
        {
            return WebApp1DbContext.users.ToList();
        }

		public User GetByEmail(string email)
		{
			return WebApp1DbContext.users.First(u => u.Email == email);
		}
	}
}
