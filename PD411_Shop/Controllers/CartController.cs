using Microsoft.AspNetCore.Mvc;
using PD411_Shop.Data;
using PD411_Shop.Services;

namespace PD411_Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Add(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                CartService.AddToCart(HttpContext.Session, id);
            }

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                CartService.RemoveFromCart(HttpContext.Session, id);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
