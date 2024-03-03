namespace RobotaNearMe.Data
{
    public class PreviousJobs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Ended { get; set; }
        public string CompanyName { get; set; }
        public int JobFieldId { get; set; }
        public virtual JobField JobField { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
