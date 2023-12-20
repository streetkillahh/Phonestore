using System.ComponentModel.DataAnnotations;

namespace Phonestore.Domain.ViewModels.Profile
{
    public class ProfileViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите возраст")]
        [Range(0,150, ErrorMessage = "Диапазон возраста должен быть от 0 до 150")]

        public byte Age { get; set; }
        [Required(ErrorMessage = "Укажите адрес")]
        [MinLength(10, ErrorMessage = "Минимальная длина должна составлять не менее 10 символов")]
        [MaxLength(250,ErrorMessage = "Максимальная длина должна составлять не более 250 символов")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Укажите имя")]
        public string UserName { get; set; }
    }
}
