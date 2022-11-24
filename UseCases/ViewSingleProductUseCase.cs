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
    public class ViewSingleProductUseCase : IViewSingleProductUseCase
    {
        private IProductRepository _productRepository;
        public ViewSingleProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Execute(Product product)
        {
            _productRepository.ViewProduct(product);
        }
    }
}
