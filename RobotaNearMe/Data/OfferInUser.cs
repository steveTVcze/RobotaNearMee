namespace RobotaNearMe.Data
{
    public class OfferInUser
    {
        public Guid Id { get; set; }
        public Guid JobOfferId { get; set; }
        public virtual JobOffer JobOffer { get; set; }  
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
