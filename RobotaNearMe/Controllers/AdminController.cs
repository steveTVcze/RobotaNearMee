using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RobotaNearMe.Data;
using RobotaNearMe.Lib.AdminModels;
using RobotaNearMe.Lib.Modelos;
using RobotaNearMe.Services;

namespace RobotaNearMe.Controllers
{
    [Authorize(Roles = "SuperMegaAdmin")]
    public class AdminController : Controller
    {
        private DbService _service;
        private MailService _mailService;
        private readonly UserManager<IdentityUser> _userManager;
        public AdminController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _service = new DbService(context, userManager);
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SendNewsletter()
        {
            return View("Newsletter");
        }
        [HttpPost]
        public IActionResult SendNewsletter(NewsletterModel newModel)
        {
            List<Data.User> users = _service.GetUsers();
            _mailService = new();
            _mailService.NewsletterEveryone(users, newModel.Subject, newModel.Message);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult AddJobField()
        {
            return View("AddJobFields");
        }
        [HttpPost]
        public IActionResult AddJobField(Data.JobField jobField)
        {
            int jobFieldId =  _service.GetHighestJobFieldId();
            jobField.Id = jobFieldId + 1;
            _service.AddJobField(jobField);
            return RedirectToAction("Index", "Home");
        }
    }
}
