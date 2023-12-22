using Phonestore.Domain.Enum;

namespace Phonestore.Domain.Entity.User
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
