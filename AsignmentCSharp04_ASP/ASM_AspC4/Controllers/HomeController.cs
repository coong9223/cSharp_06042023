using ASM_AspC4.iServices;
using ASM_AspC4.Models;
using ASM_AspC4.Services;
using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host.Mef;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ASM_AspC4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly iRole roleSer;
        private readonly iColor colorSer;
        private readonly iMetarial metarialSer;
        private readonly iProduct productSer;
        private readonly iBill billSer;
        private readonly iCart cartSer;
        private readonly iUser userSer;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            roleSer = new RoleSer();
            colorSer = new ColorSer();
            metarialSer = new MetarialSer();
            userSer=new UserSer();
        }

        public IActionResult Index()
        {
            return View();
        }

/*---------------------------------------------------------show------------------------------------------------------*/
        public IActionResult ShowAll()
        {
            List<Role> roles = roleSer.getALlRole();
            return View(roles);
        }

        public IActionResult ShowColor()
        {
            List<Color> colors = colorSer.getAllColor();
            return View(colors);
        }

        public IActionResult ShowMetarial()
        {
            List<Metarial> metarials = metarialSer.getAllMetarial();
            return View(metarials);
        }

        public IActionResult ShowUser()
        {
            List<User> users = userSer.getAllUser();
            return View(users);
        }

/*-----------------------------------------------------------------------create------------------------------------------------------*/
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateColoṛ̣̣̣̣̣̣̣̣()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateMetarial()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        /*---------------------------------create action---------------------------------------------------------------*/
        public IActionResult Create(Role role)
        {
            if(roleSer.createRole(role))
            {
                return RedirectToAction("ShowAll");
            }
            else return BadRequest();   
        }

        public IActionResult CreateColor(Color c)
        {
            if (colorSer.createColor(c))
            {
                return RedirectToAction("ShowColor");
            }
            else return BadRequest();
        }

        public IActionResult CreateMetarial(Metarial m)
        {
            if (metarialSer.createMetarial(m))
            {
                return RedirectToAction("ShowMetarial");
            }
            else return BadRequest();   
        }
/*--------------------------------------------------------------------------detail--------------------------------------------*/
        public IActionResult Details(Guid id)
        {
            var role =roleSer.getById(id);
            return View(role);  
        }

        public IActionResult DetailsColor(Guid id)
        {
            var color =colorSer.getById(id);
            return View(color);
        }


        public IActionResult Delete(Guid id)
        {
            if(roleSer.deleteRole(id))
            {
                return RedirectToAction("ShowAll");
            }
            else return BadRequest();   
        }
        [HttpGet]

        public IActionResult Edit(Guid id)
        {
            var role=roleSer.getById(id);
            return View(role);
        }

        public IActionResult Edit(Role role)
        {
            if (roleSer.updateRole(role))
            {
                return RedirectToAction("ShowAll");
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