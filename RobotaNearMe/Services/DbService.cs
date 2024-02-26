using RobotaNearMe.Data;

namespace RobotaNearMe.Services
{
    public class DbService
    {
        private readonly ApplicationDbContext _context;
        public DbService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<JobOffer> GetJobOffers()
        {
            if (_context.JobOffers.ToList() == null)
            {
                return new List<JobOffer>();
            }
            return _context.JobOffers.ToList();
        }
        public void AddJobOffer(JobOffer jo)
        {

            if (jo != null)
            {
                _context.JobOffers.Add(jo);
                _context.SaveChanges();
            }
        }
        public void AddJobField(JobField jobField)
        {

            if (jobField != null)
            {
                //update this pls
                _context.Add(jobField);
                _context.SaveChanges();
            }
        }
        public List<JobField> GetJobFields()
        {
            if (_context.JobOffers.ToList() == null)
            {
                return new List<JobField>();
            }
            return _context.JobFields.ToList();
        }
        public List<User> GetUsers()
        {
            if (_context.User.ToList() == null)
            {
                return new List<User>();
            }
            return _context.User.ToList();
        }
    }
}
