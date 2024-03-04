namespace RobotaNearMe.Data
{
    public class FileTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime Added { get; set; }
    }
}
