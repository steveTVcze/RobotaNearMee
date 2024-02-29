namespace RobotaNearMe.Lib.Modelos
{
    public class Education
    {
        public Guid Id { get; set; }
        public EducationType MaxEduLevelId { get; set; }
        public DateTime GraduationDate { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolName { get; set; }
    }

    public enum EducationType
    {
        Zakladka,
        Stredni,
        Vyssi
    }
}
