using BanGiay_ASP_c4.iServices;
using BanGiay_ASP_c4.Models;
using BanGiay_ASP_c4.Services;
//using AspNetCore;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.CodeAnalysis.Host.Mef;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace BanGiay_ASP_c4.Controllers
{
    public class ColorController:Controller
    {
        private readonly ILogger<ColorController> _logger;
        private readonly iColor colorSer;

        public ColorController(ILogger<ColorController> logger)
        {
            _logger = logger;
            colorSer = new ColorSer();
        }

        public IActionResult show()
        {
            List<Color> colors = colorSer.getAllColor();
            return View(colors);
        }

        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Color c)
        {
            if (colorSer.createColor(c))
            {
                return RedirectToAction("show");
            }
            else return BadRequest();
        }
        public IActionResult details(Guid id)
        {
            var color = colorSer.getById(id);
            return View(color);
        }
        public IActionResult delete(Guid id)
        {
            if (colorSer.deleteColor(id))
            {
                return RedirectToAction("show");
            }
            else return BadRequest();
        }
        [HttpGet]
        public IActionResult edit(Guid id)
        {
            var color = colorSer.getById(id);
            return View(color);
        }

        public IActionResult edit(Color color)
        {
            if (colorSer.updateColor(color))
            {
                return RedirectToAction("show");
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
