using WebApplication1.Appsrc.Contract;
using WebApplication1.Appsrc.DataBase;
using WebApplication1.Appsrc.Repository;
using WebApplication1.Models;

namespace WebApplication1.Appsrc.Service
{
    public class UserService: IUserService
    {
        private IUserRepository userepository = new UserRepository();

        public List<User> GetAllUsers()
        {
            var users =  userepository.GetAll();
            if (users == null)
            {
                throw new NullReferenceException("NO User were found!");
            }
            else
            {
                return users;
            }
        }

		public bool login(string email, string password)
        {
            bool isemailcorrect = userepository.DoesEmailExist(email);
            bool ispasscorrect = userepository.DoesPasswordExist(password);
            if(isemailcorrect && ispasscorrect )
            {
                OnlineUser.Onlineuser = userepository.GetByEmail(email);
                return true;
            }
            return false;
        }

        public bool Register(string name, string email, string password,int age)
        {
            if(password == " ")
            {
                return false;
            }
            bool doesemailexist = userepository.DoesEmailExist(email);
            bool doespassexist = userepository.DoesPasswordExist(password);
            if (!doesemailexist && !doespassexist)
            {
                if (age > 0 || age<160)
                {
                    userepository.CreateUser(name, email, password,age);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if(!doesemailexist)
            {
                return false ;
            }
            if (!doespassexist)
            {
                return false;
            }
            return false;
        }
    }
}
