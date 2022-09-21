namespace MinimalApi.Models.Repositories
{
    public static class UserRepository
    {
        public static User? Get(string username, string password)
        {
            var users = new List<User>
            {
                new User (1, "admin", "admin", "manager"),
                new User (2, "employee", "employee", "employee")
            };
            return users.Where(u => u.Username.ToLower() == username && u.Password.ToLower() == password).FirstOrDefault();
        }
    }
}
