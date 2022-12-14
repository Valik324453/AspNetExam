using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Img { get; set; }

        public int Qnt { get; set; }


      
    }
}