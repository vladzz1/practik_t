using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PD411_Shop.Data;
using PD411_Shop.Models;
using PD411_Shop.ViewModels;
using System.Diagnostics;

namespace PD411_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int? category, [FromQuery] PaginationVM pagination)
        {
            IQueryable<CategoryModel> categories = _context.Categories;
            IQueryable<ProductModel> products = _context.Products;

            if (category != null && categories.Any(c => c.Id == category))
            {
                products = products.Where(p => p.CategoryId == category);
            }

            // Pagination
            pagination.PageSize = pagination.PageSize < 1 ? 20 : pagination.PageSize;
            pagination.PageCount = (int)Math.Ceiling((double)products.Count() / pagination.PageSize);
            pagination.Page = pagination.Page < 1 || pagination.Page > pagination.PageCount ? 1 : pagination.Page;

            products = products.OrderBy(p => p.Id).Skip(pagination.PageSize * (pagination.Page - 1)).Take(pagination.PageSize);

            var homeVm = new HomeVM
            {
                Products = products,
                Categories = categories,
                Pagination = pagination,
                CategoryId = category
            };
            return View(homeVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public async Task<IActionResult> ProductDescription(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product != null)
            {
                var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == product.CategoryId);
                product.Category = category;
                return View(product);
            }
            else { return RedirectToAction("Index"); }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
