using System.Security;

namespace RobotaNearMe.Data
{
    public class JobOffer
    {
        public Guid Id { get; set; }
        public DateTime Added { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid? CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public LocationRegion LocationId { get; set; }
        public bool StillValid { get; set; }
        public int JobFieldId { get; set; }
        public virtual JobField JobField { get; set; }
    }
    public enum LocationRegion
    { 
        Liberecky,
        Hradecky,
        Pardubicky,
        Praha,
        Brno,
        Usti,
        KarlovyVary,
        Plzen
    }
}
