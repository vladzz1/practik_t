using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PD411_Shop.Data;
using PD411_Shop.Models;
using PD411_Shop.ViewModels;

namespace PD411_Shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context) { _context = context; }
        public IActionResult Index()
        {
            var categories = _context.Categories.AsNoTracking().AsEnumerable();
            return View(categories);
        }
        // GET
        public async Task<IActionResult> Create()
        {
            return View();
        }
        // POST
        // [FromForm] - очікує дані у форматі multipart/form-data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] CreateCategoryVM vm)
        {
            if (!ModelState.IsValid) { return View(vm); }

            CategoryModel model = new CategoryModel
            {
                Name = vm.Name ?? string.Empty
            };

            await _context.Categories.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        // DELETE
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
        //GET
        public async Task<IActionResult> Update(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
            if (category != null)
            {
                var viewModel = new UpdateCategoryVM
                {
                    Id = category.Id,
                    Name = category.Name
                };
                return View(viewModel);
            }
            else { return RedirectToAction("Index"); }
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] UpdateCategoryVM vm)
        {
            if (!ModelState.IsValid) { return View(vm); }
            CategoryModel model = await _context.Categories.FirstAsync(m => m.Id == vm.Id);
            model.Name = vm.Name ?? string.Empty;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
