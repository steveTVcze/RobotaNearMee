namespace RobotaNearMe.Lib.Modelos
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        public Guid UserId { get; set; }
        public virtual User Admin { get; set; }
        public string Website {  get; set; }
        public string Info { get; set; }
        public string ProfilePicture { get; set; }
    }
}
