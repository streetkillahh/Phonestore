using System.ComponentModel.DataAnnotations;

namespace Phonestore.Domain.Enum
{
    public enum Role
    {
        [Display(Name = "Пользователь")]
        User = 0,
        [Display(Name = "Модератор")]
        Moderator = 1,
        [Display(Name = "Администратор")]
        Administrator = 2
    }
}