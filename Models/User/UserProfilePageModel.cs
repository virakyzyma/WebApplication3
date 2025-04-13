using WebApplication3.Data.Entities;

namespace WebApplication3.Models.User
{
    public class UserProfilePageModel
    {
        public bool IsFound { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";


        public string Phone {  get; set; } = "";
        public string MostViewed {  get; set; } = "";
        public string Recent {  get; set; } = "";
        public string Role {  get; set; } = "";
        public string PhotoUrl { get; set; } = "";

        public bool IsOwner { get; set; }

        public List<Cart> Carts { get; set; } = [];
    }
}
