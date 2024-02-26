namespace RobotaNearMe.Lib.Modelos
{
    public class PrevJobsInUser
    {
        public Guid Id { get; set; }
        public Guid PreviousJobsId { get; set; }
        public PreviousJobs PreviousJobs { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
