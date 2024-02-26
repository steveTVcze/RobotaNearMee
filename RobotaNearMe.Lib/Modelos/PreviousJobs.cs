namespace RobotaNearMe.Lib.Modelos
{
    public class PreviousJobs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Ended { get; set; }
        public string CompanyName { get; set; }
        public string CompanyFieldId { get; set; }
        public string CompanyContact { get; set; }
    }
}
