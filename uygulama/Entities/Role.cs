namespace uygulama.Entities
{
    public class Role
    {
        public int ID { get; set; }
        public string UserRole { get; set; }
        public string Description { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
