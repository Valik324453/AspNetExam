using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            // add some categories
            _products = new List<Product>();
            _products.Add(new Product()
            {
                Id = "bike-1",
                Title = "Cobalt 3",
                Description =
        "The Pinnacle Cobalt is the bicycle equivalent of a 4x4. With its upright and comfortable riding position, versatile and grippy 40mm wide tyres, adjustable suspension forks and pannier rack mounts on all models, the Pinnacle Cobalt is a master of covering ground in comfort and control. Whether you’re riding on roads, towpaths or woodland short-cuts, the Pinnacle Cobalt handles it all with ease. If a mountain bike seems too over-built or heavy and a road bike too limiting, the do-it-all Cobalt could be what you're looking for. Due to stock availability, some components may change without notice.",
                Price = 459, //sort
                Stock = 5,
                Manufacturer = "Giant", //filter
                Img = "https://www.evanscycles.com/images/products/93917718_l.jpg",
            });

            _products.Add(new Product()
            {
                Id = "bike-2",
                Title = "Laterite 1",
                Description =
        "The Pinnacle Laterite is the perfect introduction to drop bar bikes. Now with an updated unisex design that looks to build on the success of the first generation of bike with smoother lines, improved braking performance and even better value for money. The Pinnacle Laterite is an excellent first road bike or an upgrade from your old bike. A balanced riding position and comfortable geometry inspired by our award-winning Dolomite combined with thick bar tape and a carbon bladed fork make this an ideal bike for training miles, sportives or leisure riding.",
                Price = 349, //sort
                Stock = 2,
                Manufacturer = "Redline", //filter
                Img = "https://www.evanscycles.com/images/products/93435002_l.jpg",
            });


        }
        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}