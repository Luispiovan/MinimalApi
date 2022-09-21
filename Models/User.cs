namespace MinimalApi.Models
{
    public class User
    {
        public User(int id, string username, string password, string role)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Role = role;

        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
