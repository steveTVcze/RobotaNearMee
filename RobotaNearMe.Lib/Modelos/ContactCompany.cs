using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotaNearMe.Lib.Modelos
{
    public class ContactCompany
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string IC { get; set; }
        public string DIC { get; set; }
    }
}
