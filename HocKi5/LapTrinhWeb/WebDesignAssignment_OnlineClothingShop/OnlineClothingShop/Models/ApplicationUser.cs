using Microsoft.AspNetCore.Identity;

namespace OnlineClothingShop.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
