namespace WebApplication1.Appsrc.DataBase
{
    public class ConnectionString
    {
        public static string Connectionstring { get; set; }
        public ConnectionString()
        {
            Connectionstring = @"Data Source=DESKTOP-7648UU0\SQLEXPRESS; Initial Catalog=WebApp1; User Id=sa; Password=123456; TrustServerCertificate=True;";
        }
    }
}
