using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();

        public IEnumerable<Product> CreateCart();

        void AddProduct(Product product);
    }
}