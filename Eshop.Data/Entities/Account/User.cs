using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.Account
{
    public class User : BaseEntity
    {
        public string MobileNumber { get; set; }
        public string MobileActivationNumer { get; set; }

        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public string? UserCity { get; set; }

        public bool BlockUser { get; set; }
    }
}
