using System.ComponentModel.DataAnnotations;

namespace introDotNetCoreWithMVC.Models
{
    public class User
    {
        [Required(ErrorMessage = "Ad alani bos olamaz")]
        [MinLength(2, ErrorMessage = "En az iki karakter olmali")]
        [MaxLength(50, ErrorMessage = "En fazla elli karakter olmali")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Soyad alani bos olamaz")]
        [MinLength(2, ErrorMessage = "En az iki karakter olmali")]
        [MaxLength(50, ErrorMessage = "En fazla elli karakter olmali")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Eposta alani bos olamaz")]
        [EmailAddress(ErrorMessage = "Eposta formati yanlis")]
        public string Email { get; set; }
    }
}
