namespace Phonestore.Domain.Entity.User
{
    public class Profile
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }
        public User User { get; set; }
        public string UserName { get; set; }
    }
}