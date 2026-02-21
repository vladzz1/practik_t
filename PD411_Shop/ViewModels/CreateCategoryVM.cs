using System.ComponentModel.DataAnnotations;

namespace PD411_Shop.ViewModels
{
    public class CreateCategoryVM
    {
        [Required(ErrorMessage = "Обов'язкове поле")]
        [MaxLength(200, ErrorMessage = "Максимальна довжина 200 символів")]
        public string? Name { get; set; }
    }
}
