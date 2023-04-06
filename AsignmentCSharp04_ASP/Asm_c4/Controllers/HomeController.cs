using Asm_c4.Models;
using Microsoft.AspNetCore.Mvc;
using Asm_c4.Services;
using Asm_c4.iServices;

namespace Asm_c4.Controllers
{
    public class HomeController : Controller
    {
        private readonly iProduct productSer;

        public HomeController()
        {
            productSer = new ProductSer();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult show()
        {
            List<Product> pro = productSer.getAllProduct();
            return View(pro);
        }

        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Product pro)
        {
            if (productSer.createProduct(pro))
            {
                return RedirectToAction("show");
            }
            else return BadRequest();
        }
        public IActionResult details(Guid id)
        {
            var pro = productSer.getById(id);
            return View(pro);
        }
        public IActionResult delete(Guid id)
        {
            if (productSer.deleteProduct(id))
            {
                return RedirectToAction("show");
            }
            else return BadRequest();
        }
        [HttpGet]
        public IActionResult edit(Guid id)
        {
            var pro = productSer.getById(id);
            return View(pro);
        }

        public IActionResult edit(Product pro)
        {
            var p = productSer.getById(pro.idProduct);
            if (p.priceProduct < 1)
            {
                ModelState.AddModelError("", "Giá phải lớn hơn 1");
                return View();
            }
            if (p.availableQuantity < 1)
            {
                ModelState.AddModelError("", "Số Lượng phải lớn hơn 1");
                return View();
            }
            if (p.statusProduct < 1)
            {
                ModelState.AddModelError("", "Số Lượng phải lớn hơn 1");
                return View();
            }
            if (productSer.updateProduct(pro))
            {
                return RedirectToAction("show");
            }
            else return BadRequest();
        }
        
    }
}