using Microsoft.AspNetCore.Identity;

namespace RobotaNearMe.Data
{
    public class CompanyAdmin
    {
        public Guid Id { get; set; }
        public string IdentityUserId { get; set; }
        public virtual IdentityUser User { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Guid ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
