using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        public void AddProduct(Product product);
        IEnumerable<Product> GetCart();

        void ViewProduct(Product product);

        Product GetProductById(int productId);

        public Product GetProductByIdFromCart(int productId);

        void DeleteProductFromCart(int productId);
    }
}
