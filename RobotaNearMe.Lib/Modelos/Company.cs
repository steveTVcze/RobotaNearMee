namespace RobotaNearMe.Lib.Modelos
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public virtual User? Admin { get; set; }
        public Guid ContactCompanyId { get; set; }
        public virtual ContactCompany? Contact { get; set; }
        public string Website {  get; set; }
        public string Info { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string ICO { get; set; }
        public string DIC { get; set; }
    }
}
