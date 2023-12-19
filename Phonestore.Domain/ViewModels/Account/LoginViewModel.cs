using System.ComponentModel.DataAnnotations;

namespace Phonestore.Domain.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введите имя")]
        [MinLength(3, ErrorMessage = "Имя должно содержать более 3 символов")]
        [MaxLength(20, ErrorMessage = "Имя должно содержать менее 20 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль должен содержать минимум 6 символов")]
        public string Password { get; set; }
    }
}
