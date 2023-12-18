using Microsoft.AspNetCore.Mvc;
using OnlineClothingShop.Models;

namespace OnlineClothingShop.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        OnlineClothingShopContext db;
        List<TbCategory> categories;

        public CategoryViewComponent(OnlineClothingShopContext db)
        {
            this.db = db;
			categories = db.TbCategories.ToList();

		}

        public async Task<IViewComponentResult> InvokeAsync()
        { 
			return View("RenderCategory", categories);
		}
    }
}
