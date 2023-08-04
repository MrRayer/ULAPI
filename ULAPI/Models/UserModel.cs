namespace ULAPI.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserModel(string name = "", string password = "", string email = "")
        {
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
