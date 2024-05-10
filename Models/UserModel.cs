using Microsoft.AspNetCore.Identity;

namespace Register.Models
{
    public class UserModel : IdentityUser
    {
        public string FirsName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string PhoneNumber { get; set; } = "";

        public DateTime CreatedAt { get; set; }

    }
}
