using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineClothingShop.Models;

namespace OnlineClothingShop.Controllers
{
    public class ProductController : Controller
    {

        private OnlineClothingShopContext db;


        public ProductController(OnlineClothingShopContext context)
        {
            db = context;
        }

        public IActionResult Shop()
        {
            var product = db.TbProducts.ToList();
            return View(product);
        }
        public IActionResult Detail(int? id)
        {
            var product = db.TbProducts.Where(p => p.ProductId == id).FirstOrDefault();
            return View(product);
        }

        public IActionResult CategoryFilter(int? catid)
        {
            if (catid == null)
            {
                var products = db.TbProducts.ToList();
                return PartialView("Filter", products);
            }
            else
            {
                var products = db.TbProducts.Where(l => l.CatId == catid).Include(m => m.Cat).ToList();
                return PartialView("Filter", products);
            }
        }
    }
}
