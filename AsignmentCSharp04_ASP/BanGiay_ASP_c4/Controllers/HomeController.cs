using BanGiay_ASP_c4.iServices;
using BanGiay_ASP_c4.Models;
using BanGiay_ASP_c4.Services;
//using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host.Mef;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace BanGiay_ASP_c4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly iRole roleSer;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            roleSer = new RoleSer();

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*---------------------------------------------------------show------------------------------------------------------*/
        public IActionResult ShowRole()
        {
            List<Role> roles = roleSer.getALlRole();
            return View(roles);
        }

        
        /*-----------------------------------------------------------------------create------------------------------------------------------*/
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]

       
        /*---------------------------------create action---------------------------------------------------------------*/
        public IActionResult CreateColor(Role role)
        {
            if (roleSer.createRole(role))
            {
                return RedirectToAction("ShowRole");
            }
            else return BadRequest();
        }
        
       
        /*--------------------------------------------------------------------------detail--------------------------------------------*/
        public IActionResult DetailsRole(Guid id)
        {
            var role = roleSer.getById(id);
            return View(role);
        }

        
        /*-------------------------------------------------delete-----------------------------------------------------------------------------*/
        public IActionResult DeleteRole(Guid id)
        {
            if (roleSer.deleteRole(id))
            {
                return RedirectToAction("ShowRole");
            }
            else return BadRequest();
        }
        [HttpGet]

        
        /*------------------------------------------edit---------------------------------------------------------*/
        public IActionResult EditRole(Guid id)
        {
            var role = roleSer.getById(id);
            return View(role);
        }

        public IActionResult EditRole(Role role)
        {
            if (roleSer.updateRole(role))
            {
                return RedirectToAction("ShowRole");
            }
            else return BadRequest();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}