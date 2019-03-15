namespace restApi.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}