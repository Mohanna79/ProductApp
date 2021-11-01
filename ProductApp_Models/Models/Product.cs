using System.ComponentModel.DataAnnotations;

namespace ProductApp_Models.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }

        [Required]
        public double? Price { get; set; }
        [Required]
        public int? Number { get; set; }
    }
}
