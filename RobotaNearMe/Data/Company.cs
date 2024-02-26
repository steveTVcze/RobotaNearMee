namespace RobotaNearMe.Data
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        public Guid AdminId { get; set; }
        public virtual CompanyAdmin Admin { get; set; }
        public string Website {  get; set; }
        public string Info { get; set; }
        public string ProfilePicture { get; set; }
    }
}
