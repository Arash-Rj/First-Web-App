namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public List<Product> Products { get; set; }  
        public User() { }
        public User (string name,string email,string password,int age) 
        {
            Name = name;
            Email = email;
            Password = password;
            Age = age;
        }
        public string GetPassword(string password)
        {
            if(password == Password)
            {
                return Password;
            }
            return " ";
        }
    }
}
