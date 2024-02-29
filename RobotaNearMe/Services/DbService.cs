using Microsoft.EntityFrameworkCore;
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
                _context.JobFields.Add(jobField);
                _context.SaveChanges();
            }
        }
        public void AddUser(User user)
        {

            if (user != null)
            {
                _context.User.Add(user);
                _context.SaveChanges();
            }
        }
        public void AddEdu(Education model)
        {

            if (model != null)
            {
                _context.Educations.Add(model);
                _context.SaveChanges();
            }
        }
        public void AddContact(Contact contact)
        {

            if (contact != null)
            {
                _context.Contacts.Add(contact);
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
        public User GetUser(string name)
        {
            Contact contactos = _context.Contacts.FirstOrDefault(x => x.Email == name);
            return _context.User.Include(x => x.Contact).Include(x => x.Education).FirstOrDefault(x => x.ContactId == contactos.Id);
        }
        public Company GetCompanyById(Guid id)
        {
            if (_context.Companies.FirstOrDefault(x => x.UserId == id) == null)
            {
                return new Company();
            }
            else
            {
                return _context.Companies.FirstOrDefault(x => x.UserId == id);
            }
        }
    }
}
