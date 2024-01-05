using cw12.Enums;

namespace cw12.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public RoleEnum Role { get; set; }

    }
}
