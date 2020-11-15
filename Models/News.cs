using System;
using System.ComponentModel.DataAnnotations;

namespace NewsAPI.Models
{
    public class News
    {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(255, ErrorMessage = "Este campo deve conter entre 5 a 255 caracteres")]
        [MinLength(5, ErrorMessage = "Este campo deve conter entre 5 a 255 caracteres")]
        public string title { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(255, ErrorMessage = "Este campo deve conter entre 5 a 255 caracteres")]
        [MinLength(5, ErrorMessage = "Este campo deve conter entre 5 a 255 caracteres")]
        public string title_description { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(255, ErrorMessage = "Este campo deve conter entre 5 a 255 caracteres")]
        [MinLength(5, ErrorMessage = "Este campo deve conter entre 5 a 255 caracteres")]
        public string news { get; set; }

        public DateTime date{ get; set; }
    }
}