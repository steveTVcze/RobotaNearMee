namespace RobotaNearMe.Data
{
    public class Company
    {
        public Guid Id { get; set; }
        public Guid ContactCompanyId { get; set; }
        public virtual ContactCompany? ContactCompany { get; set; }
        public Guid UserId { get; set; }
        public virtual User? Admin { get; set; }
        public string Website {  get; set; }
        public string Info { get; set; }
        public string ProfilePicture { get; set; }
        public string Name { get; set; }
        public string Founded { get; set; }

    }
}
