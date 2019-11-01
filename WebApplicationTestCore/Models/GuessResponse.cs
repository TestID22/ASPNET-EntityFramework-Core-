using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationTestCore.Models
{
    public class GuessResponse
    {
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Введите email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Введите емейл правильно")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Подтведите или отклоните предложение")]

        public bool? WillAttend { get; set; }
    }
}
