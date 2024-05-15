using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineClothingShop.Models;
using X.PagedList;
using IHostEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace OnlineClothingShop.Controllers
{
    [Authorize(Roles = "admin,sales")]
    public class ProductsController : Controller
    {
        private IHostEnvironment env;
        private readonly OnlineClothingShopContext _context;

        public ProductsController(OnlineClothingShopContext context, IHostEnvironment _env)
        {
            env = _env;
            _context = context;
        }

        // GET: Products
        [Authorize]
        public async Task<IActionResult> Index(int? page, int? pagesize)
        {
            if (page == null)
            {
                page = 1;
            }

            if (pagesize == null)
            {

                pagesize = 10;

            }
            var products = _context.TbProducts.Include(t => t.Cat);
            ViewBag.pageSize = pagesize;
            return View(await products.ToPagedListAsync((int)page, (int)pagesize));
        }   

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TbProducts == null)
            {
                return NotFound();
            }

            var tbProduct = await _context.TbProducts
                .Include(t => t.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (tbProduct == null)
            {
                return NotFound();
            }

            return View(tbProduct);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CatId"] = new SelectList(_context.TbCategories, "CatId", "CatId");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductName,ShortDesc,Description,CatId,Price,Discount,DateCreated,DateModified,BestSellers,HomeFlag,Active,UnitsInStock,descImage,singleImage,thumImage")] TbProduct tbProduct)
        {

            var fileName = Path.Combine("wwwroot/images/Product", tbProduct.thumImage.FileName);
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                await tbProduct.thumImage.CopyToAsync(fileStream);
            }
            tbProduct.ThumbImg = tbProduct.thumImage.FileName;


            var fileName2 = Path.Combine("wwwroot/images/ProductDetail", tbProduct.singleImage.FileName);
            using (FileStream fileStream = new FileStream(fileName2, FileMode.Create))
            {
                await tbProduct.singleImage.CopyToAsync(fileStream);
            }
            tbProduct.SingleImg = tbProduct.singleImage.FileName;

            var fileName3 = Path.Combine("wwwroot/images/ProductDetail", tbProduct.descImage.FileName);
            using (FileStream fileStream = new FileStream(fileName3, FileMode.Create))
            {
                await tbProduct.descImage.CopyToAsync(fileStream);
            }
            tbProduct.DescImg = tbProduct.descImage.FileName;

            ViewData["CatId"] = new SelectList(_context.TbCategories, "CatId", "CatId", tbProduct.CatId);
            _context.Add(tbProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            return View(tbProduct);
        }

        // public async Task<IActionResult> Create([Bind("Name,Price,Quantity,Promationprice,Description,Newproduct,Idcategory,image")] Product product)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var fileName = Path.Combine("wwwroot/image/Uploads", product.image.FileName);
        //        using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
        //        {
        //            await product.image.CopyToAsync(fileStream);
        //        }
        //        product.Image = Path.Combine("/image/Uploads",product.image.FileName);

        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["Idcategory"] = new SelectList(_context.Categories, "Id", "Id", product.Idcategory);
        //    return View(product);
        //}
        // */
        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TbProducts == null)
            {
                return NotFound();
            }

            var tbProduct = await _context.TbProducts.FindAsync(id);
            if (tbProduct == null)
            {
                return NotFound();
            }
            ViewData["CatId"] = new SelectList(_context.TbCategories, "CatId", "CatId", tbProduct.CatId);
            return View(tbProduct);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TbProduct tbProduct)
        {
            if (id != tbProduct.ProductId)
            {
                return NotFound();
            }

            try
            {
                _context.Update(tbProduct);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbProductExists(tbProduct.ProductId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
            ViewData["CatId"] = new SelectList(_context.TbCategories, "CatId", "CatId", tbProduct.CatId);
            await _context.SaveChangesAsync();
            return View(tbProduct);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TbProducts == null)
            {
                return NotFound();
            }

            var tbProduct = await _context.TbProducts
                .Include(t => t.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (tbProduct == null)
            {
                return NotFound();
            }

            return View(tbProduct);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TbProducts == null)
            {
                return Problem("Entity set 'OnlineClothingShopContext.TbProducts'  is null.");
            }
            var tbProduct = await _context.TbProducts.FindAsync(id);
            if (tbProduct != null)
            {
                _context.TbProducts.Remove(tbProduct);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbProductExists(int id)
        {
            return (_context.TbProducts?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
