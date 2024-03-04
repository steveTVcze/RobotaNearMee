using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RobotaNearMe.Data;
using RobotaNearMe.Lib.Modelos;
using RobotaNearMe.Services;

namespace RobotaNearMe.Controllers
{
    [Authorize(Roles = "SuperMegaAdmin")]
    public class AdminController : Controller
    {
        private DbService _service;
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
