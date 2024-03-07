namespace uygulama.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<UserRole> UserRoles{ get; set; }
    }
}
