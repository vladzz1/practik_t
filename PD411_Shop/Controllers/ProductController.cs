using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PD411_Shop.Models;
using PD411_Shop.Repositories;
using PD411_Shop.Services;
using PD411_Shop.Settings;
using PD411_Shop.ViewModels;

namespace PD411_Shop.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProductController : Controller
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductRepository _productRepository;
        private readonly ImageService _imageService;
        public ProductController(CategoryRepository categoryRepository, ProductRepository productRepository, ImageService imageService)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _imageService = imageService;
        }
        private async Task<IEnumerable<SelectListItem>> GetSelectCategoriesAsync()
        {
            List<CategoryModel> categories = await _categoryRepository.GetAllAsync();

            IEnumerable<SelectListItem> selectItems = categories.Select(c => new SelectListItem(c.Name, c.Id.ToString()));

            // Приклад того самого коду без використання Select
            //List<SelectListItem> result = new List<SelectListItem>();
            //foreach (var c in categories)
            //{
            //    var item = new SelectListItem(c.Name, c.Id.ToString();
            //    result.Add(item);
            //}

            return selectItems;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync(new PaginationVM { PageSize = 200 });
            return View(products);
        }
        // GET
        public async Task<IActionResult> Create()
        {
            var viewModel = new CreateProductVM
            {
                SelectCategories = await GetSelectCategoriesAsync()
            };

            return View(viewModel);
        }
        // POST
        // [FromForm] - очікує дані у форматі multipart/form-data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] CreateProductVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm.SelectCategories = await GetSelectCategoriesAsync();
                return View(vm);
            }

            ProductModel model = new ProductModel
            {
                Name = vm.Name ?? string.Empty,
                Amount = vm.Amount,
                Color = vm.Color,
                Description = vm.Description,
                Price = vm.Price,
                CategoryId = vm.CategoryId
            };

            // Save Image
            if (vm.Image != null)
            {
                model.Image = await _imageService.SaveImageAsync(vm.Image, PathSettings.Products);
            }

            await _productRepository.CreateAsync(model);

            return RedirectToAction("Index");
        }

        // DELETE
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product != null)
            {
                if (product.Image != null)
                {
                    _imageService.DeleteImage(PathSettings.Products, product.Image);
                }

                await _productRepository.DeleteAsync(product.Id);
            }
            return RedirectToAction("Index");
        }
        //GET
        public async Task<IActionResult> Update(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product != null)
            {
                var viewModel = new UpdateProductVM
                {
                    Id = product.Id,
                    SelectCategories = await GetSelectCategoriesAsync(),
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Amount = product.Amount,
                    Color = product.Color,
                    CategoryId = product.CategoryId
                };
                return View(viewModel);
            }
            else { return RedirectToAction("Index"); }
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] UpdateProductVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm.SelectCategories = await GetSelectCategoriesAsync();
                return View(vm);
            }
            var model = await _productRepository.GetByIdAsync(vm.Id);
            if (model != null)
            {
                model.Name = vm.Name ?? string.Empty;
                model.Amount = vm.Amount;
                model.Color = vm.Color;
                model.Description = vm.Description;
                model.Price = vm.Price;
                model.CategoryId = vm.CategoryId;
                // Save Image
                if (vm.Image != null)
                {
                    string? imageName = await _imageService.SaveImageAsync(vm.Image, PathSettings.Products);

                    if (imageName != null)
                    {
                        if (!string.IsNullOrEmpty(model.Image))
                        {
                            _imageService.DeleteImage(PathSettings.Products, model.Image);
                        }
                    }
                    model.Image = imageName;
                }
                await _productRepository.UpdateAsync(model);
            }
            return RedirectToAction("Index");
        }
    }
}