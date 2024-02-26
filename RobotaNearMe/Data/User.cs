using Microsoft.AspNetCore.Identity;

namespace RobotaNearMe.Data
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityUserId { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
        public Guid EducationId { get; set; }
        public virtual Education Education { get; set; }
        public DateTime Joined { get; set; }
        public DateTime LastOnline { get; set; }
        public bool Newsletter { get; set; }

    }
}
