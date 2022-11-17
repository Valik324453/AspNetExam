using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Product
    {
        public string Id { get; set; }
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


        /*id: "bike-1",
      title: "Cobalt 3",
      description:
        "The Pinnacle Cobalt is the bicycle equivalent of a 4x4. With its upright and comfortable riding position, versatile and grippy 40mm wide tyres, adjustable suspension forks and pannier rack mounts on all models, the Pinnacle Cobalt is a master of covering ground in comfort and control. Whether you’re riding on roads, towpaths or woodland short-cuts, the Pinnacle Cobalt handles it all with ease. If a mountain bike seems too over-built or heavy and a road bike too limiting, the do-it-all Cobalt could be what you're looking for. Due to stock availability, some components may change without notice.",
      price: 459, //sort
      stock: 5,
      manufacturer: "Giant", //filter
      img: "",*/
    }
}