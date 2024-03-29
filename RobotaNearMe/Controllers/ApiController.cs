﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RobotaNearMe.Data;
using RobotaNearMe.Lib;
using RobotaNearMe.Services;

namespace RobotaNearMe.Controllers
{
    public class ApiController : Controller
    {
        private readonly DbService _service;
        public ApiController(ApplicationDbContext context, UserManager<IdentityUser> manager)
        {
            _service = new DbService(context, manager);

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet(Endpoints.V1.GETOFFERS)]
        public List<JobOffer> GetOffers()
        {
            
            List<JobOffer> offers = _service.GetJobOffers();
            if (offers == null)
            {
                JobOffer jobOffer = new JobOffer()
                {
                    Id = Guid.NewGuid(),
                    Description = "ahoj",
                    Added = DateTime.Now.ToUniversalTime(),
                    CompanyId = Guid.NewGuid(),
                    JobFieldId = 1,
                    LastUpdated = DateTime.Now.ToUniversalTime(),
                    StillValid = true,
                    Title = "Neco",
                    LocationId = LocationRegion.Pardubicky,
                };
                _service.AddJobOffer(jobOffer);
                List<JobOffer> offeros = _service.GetJobOffers();
                return offeros;
            }
            else
            {
                return offers;
            }
        }
        [HttpPost(Endpoints.V1.POSTUSER)]
        public bool PostUser([FromBody] User model)
        {
            if (model == null)
            {
                return false;
            }
            _service.AddUser(model);

            return true;
        }
        [HttpPost(Endpoints.V1.POSTOFFERINUSER)]
        public bool PostOfferInUser([FromBody] OfferInUser model)
        {
            if (model == null)
            {
                return false;
            }
            JobOffer jo = _service.GetJobOffers().Where(x => x.Id == model.JobOfferId).FirstOrDefault();
            jo.IntrestedInIt += 1;
            _service.UpdateOffer(jo);
            _service.AddOfferInUser(model);

            return true;
        }
        [HttpPut(Endpoints.V1.PUTFILE)]
        public bool PutFileForUser([FromBody] FileTable model)
        {
            if (model == null)
            {
                return false;
            }
            _service.UpdateFileForUser(model);

            return true;
        }
        [HttpPut(Endpoints.V1.PUTJOBOFFER)]
        public bool PutOffer([FromBody] JobOffer model)
        {
            if (model == null)
            {
                return false;
            }
            _service.UpdateOffer(model);

            return true;
        }
        [HttpPut(Endpoints.V1.PUTUSERPROFILE)]
        public bool PutUserProfile([FromBody] User model)
        {
            if (model == null)
            {
                return false;
            }
            _service.UpdateProfile(model);

            return true;
        }
        [HttpPut(Endpoints.V1.PUTCOMPANYPROFILE)]
        public bool PutCompanyProfile([FromBody] Company model)
        {
            if (model == null)
            {
                return false;
            }
            _service.UpdateCompanyProfile(model);

            return true;
        }
        [HttpPost(Endpoints.V1.POSTCONTACT)]
        public bool PostContact([FromBody] Contact model)
        {
            if (model == null)
            {
                return false;
            }
            _service.AddContact(model);

            return true;
        }
        [HttpPost(Endpoints.V1.POSTCOMPANYCONTACT)]
        public bool PostCompanyContact([FromBody] ContactCompany model)
        {
            if (model == null)
            {
                return false;
            }
            _service.AddCompanyContact(model);

            return true;
        }
        [HttpPost(Endpoints.V1.POSTJOBOFFER)]
        public bool PostCompanyContact([FromBody] JobOffer model)
        {
            if (model == null)
            {
                return false;
            }
            _service.AddJobOffer(model);

            return true;
        }
        [HttpPost(Endpoints.V1.POSTEDU)]
        public bool PostEdu([FromBody] Education model)
        {
            if (model == null)
            {
                return false;
            }
            _service.AddEdu(model);

            return true;
        }
        [HttpPost(Endpoints.V1.POSTCOMPANY)]
        public async Task<bool> PostCompany([FromBody] Company model)
        {
            if (model == null)
            {
                return false;
            }

            await _service.AddCompany(model);

            return true;
        }
        [HttpPost(Endpoints.V1.POSTFILE)]
        public async Task<bool> PostFileTable([FromBody] FileTable model)
        {
            if (model == null)
            {
                return false;
            }

            await _service.AddFile(model);

            return true;
        }

        [HttpGet(Endpoints.V1.GETJOBFIELDS)]
        public List<JobField> GetJobFields()
        {
            //Random rnd = new();
            //JobField jobField = new JobField()
            //{
            //    Id = rnd.Next(rnd.Next(0, 100)),
            //    Description = "IT",
            //    Field = "IT specialista"
            //};
            //_service.AddJobField(jobField);
            List<JobField> fields = _service.GetJobFields();
            return fields;
        }
        [HttpGet(Endpoints.V1.GETUSERS)]
        public List<User> GetUsers()
        {
            List<User> useros = _service.GetUsers();
            return useros;
        }
        [HttpGet(Endpoints.V1.GETUSERBYNAME + "/{name}")]
        public User GetUserByName(string name)
        {
            User user = _service.GetUser(name);
            return user;
        }
        [HttpGet(Endpoints.V1.GETCOMPANY + "/{userId}")]
        public Company GetCompanyById(Guid userId)
        {
            Company cmp = _service.GetCompanyById(userId);
            return cmp;
        }
        [HttpGet(Endpoints.V1.GETFILEFORUSER + "/{userId}")]
        public FileTable GetFileForUser(Guid userId)
        {
            FileTable cmp = _service.GetFileForUser(userId);
            return cmp;
        }
        [HttpGet(Endpoints.V1.GETCOMPANYBYCOMPANYID + "/{companyId}")]
        public Company GetCompanyByCompanyId(Guid companyId)
        {
            Company cmp = _service.GetCompanyByCompanyId(companyId);
            return cmp;
        }
        [HttpGet(Endpoints.V1.GETOFFERSINUSER + "/{offerId}")]
        public List<OfferInUser> GetOffersInUser(Guid offerId)
        {
            List<OfferInUser> offerosinUser = _service.GetOffersInUser(offerId);
            return offerosinUser;
        }
        [HttpGet(Endpoints.V1.GETOFFERINUSERFORCOMPANY + "/{companyId}")]
        public List<string> GetOffersInUserForCompany(Guid companyId)
        {
            List<string> offerosinUser = _service.GetOffersInUserForCompany(companyId);
            return offerosinUser;
        }
    }
}
