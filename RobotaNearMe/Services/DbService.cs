using Microsoft.EntityFrameworkCore;
using RobotaNearMe.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RobotaNearMe.Services
{
    public class DbService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public DbService(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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
        public IEnumerable<IdentityUserRole<string>> GetRolesByIdentity()
        {
            try
            {
                return _context.UserRoles.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        //public async Task AddToRole(IdentityUser useros)
        //{
        //    try
        //    {
        //        //var id = co.Admin.IdentityUserId;
        //        //var useros = await _userManager.FindByIdAsync(id);
        //        string roleName = "SuperMegaAdmin";
        //        await _userManager.AddToRoleAsync(useros, roleName);
                
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log or handle the exception
        //        Console.WriteLine($"An error occurred: {ex.Message}");
        //    }
        //}
        public async Task AddCompany(Company co)
        {
            try
            {
                var id = co.Admin.IdentityUserId;
                var useros = await _userManager.FindByIdAsync(id);
                var smth = "";
                if (useros != null)
                {
                    string userRole = "User";
                    string roleName = "Admin";

                    await _userManager.RemoveFromRoleAsync(useros, userRole);
                    await _userManager.AddToRoleAsync(useros, roleName);
                    co.Admin = null;
                    co.Founded = "1999";
                    co.ContactCompany = null;

                    // Add the company to the DbSet asynchronously
                    _context.Companies.Add(co);

                    // Save changes asynchronously
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public async Task AddFile(FileTable fileTable)
        {
            _context.Files.Add(fileTable);
            await _context.SaveChangesAsync();
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
        public void AddOfferInUser(OfferInUser offinuser)
        {

            if (offinuser != null)
            {
                _context.OfferInUser.Add(offinuser);
                _context.SaveChanges();
            }
        }
        public void UpdateOffer(JobOffer offer)
        {

            if (offer != null)
            {
                _context.JobOffers.Update(offer);
                _context.SaveChanges();
            }
        }
        public void UpdateProfile(User useros)
        {

            if (useros != null)
            {
                _context.User.Update(useros);
                _context.SaveChanges();
            }
        }
        public void UpdateCompanyProfile(Company company)
        {

            if (company != null)
            {
                _context.Companies.Update(company);
                _context.SaveChanges();
            }
        }
        public void UpdateFileForUser(FileTable fileTable)
        {

            if (fileTable != null)
            {
                _context.Files.Update(fileTable);
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
        public void AddCompanyContact(ContactCompany contact)
        {

            if (contact != null)
            {
                _context.ContactsCompany.Add(contact);
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
        public int GetHighestJobFieldId()
        {
            var highestId = _context.JobFields.Max(j => (int?)j.Id) ?? 0;
            return highestId;
        }
        public List<User> GetUsers()
        {
            if (_context.User.ToList() == null)
            {
                return new List<User>();
            }
            return _context.User.Include(x => x.Contact).ToList();
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
                return _context.Companies.Include(x =>x.ContactCompany).Include(x => x.Admin).Include(x => x.Admin.Education).Include(x => x.Admin.Contact).FirstOrDefault(x => x.UserId == id);
            }
        }
        public FileTable GetFileForUser(Guid id)
        {
            if (_context.Files.FirstOrDefault(x => x.UserId == id) == null)
            {
                return new FileTable();
            }
            else
            {
                return _context.Files.FirstOrDefault(x => x.UserId == id);
            }
        }
        public Company GetCompanyByCompanyId(Guid companyId)
        {
            if (_context.Companies.FirstOrDefault(x => x.Id == companyId) == null)
            {
                return new Company();
            }
            else
            {
                return _context.Companies.Include(x => x.ContactCompany).Include(x => x.Admin).FirstOrDefault(x => x.Id == companyId);
            }
        }
        public List<string> GetOffersInUserForCompany(Guid companyId)
        {
            List<string> list = new List<string>();
            if (_context.JobOffers.Where(x => x.CompanyId == companyId) != null)
            {
                List<JobOffer> offers = _context.JobOffers.Where(x => x.CompanyId == companyId).ToList();
                foreach (var item in offers)
                {
                    if (_context.OfferInUser.Where(x => x.Id == item.Id) != null)
                    {
                        List<OfferInUser> of = _context.OfferInUser.Where(x => x.JobOfferId== item.Id).Include(x => x.User).Include(x => x.User.Contact).ToList();
                        foreach (var itemik in of)
                        {
                            if (!list.Contains(itemik.User.Contact.Email))
                            {
                                list.Add(itemik.User.Contact.Email);
                            }
                        }
                    }
                }
                return list;

            }
            else
            {
                return new List<string>();
            }
        }
        public List<OfferInUser> GetOffersInUser(Guid offerId)
        {
            if (_context.OfferInUser.Where(x => x.JobOfferId == offerId) != null)
            {
                return _context.OfferInUser.Include(x => x.User.Contact).Include(x => x.User.Education).Include(x => x.User).Include(x => x.JobOffer).Where(x => x.JobOfferId == offerId).ToList();

            }
            else
            {
                return new List<OfferInUser>(); 
            }
        }

    }
}
