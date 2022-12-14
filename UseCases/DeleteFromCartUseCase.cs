using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class DeleteFromCartUseCase : IDeleteFromCartUseCase
    {
        public IProductRepository _productRepository;
        public DeleteFromCartUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Execute(int productId)
        {
            _productRepository.DeleteProductFromCart(productId);
        }
    }
}
