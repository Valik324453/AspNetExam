using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    internal interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}