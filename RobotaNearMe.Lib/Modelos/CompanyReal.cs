using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotaNearMe.Lib.Modelos
{
    public class CompanyReal
    {
        public Guid Id { get; set; }
        public Guid ContactCompanyId { get; set; }
        public virtual ContactCompany? ContactCompany { get; set; }
        public Guid UserId { get; set; }
        public virtual User? Admin { get; set; }
        public string Website { get; set; }
        public string Info { get; set; }
        public string ProfilePicture { get; set; }
        public string Name { get; set; }
        public string Founded { get; set; }
    }
}
