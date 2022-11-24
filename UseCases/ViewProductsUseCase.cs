using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class ViewProductsUseCase : IViewProductsUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductRepository _cartRepository;

        public ViewProductsUseCase(IProductRepository productRepository, IProductRepository cartRepository)
        {
            _productRepository = productRepository;
            _cartRepository = cartRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return _productRepository.GetProducts();
        }

        public IEnumerable<Product> CreateCart()
        {
            return _cartRepository.GetCart();
        }

        public void AddProduct(Product product)
        {
            _cartRepository.AddProduct(product);
        }
    }
}

