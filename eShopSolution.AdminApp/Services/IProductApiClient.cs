using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;

namespace eShopSolution.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
        Task<bool> CreateProduct(ProductCreateRequest request);
    }
}
