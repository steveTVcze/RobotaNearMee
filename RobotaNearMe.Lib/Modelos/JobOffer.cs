using System.Security;

namespace RobotaNearMe.Lib.Modelos
{
    public class JobOffer
    {
        public Guid Id { get; set; }
        public DateTime Added { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid? CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid LocationId { get; set; }
        public bool StillValid { get; set; }
        public int JobFieldId { get; set; }
    }
}
