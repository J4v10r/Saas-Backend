using System.Collections;
using System.Runtime.CompilerServices;
using Saas.Dto.ProductDto;
using Saas.Models;

namespace Saas.Services.ProductServices
{
    public interface IProductService{
        Task AddProductAsync(ProductCreateDto productCreateDto);
        Task<bool> DeleProductByIdAsync(int id);
        Task<IEnumerable<ProductResponseDto>> GetAllProductsAsync();
        Task<IEnumerable<ProductResponseDto>> GetAllProductsByPriceAsync(decimal price);
        Task<ProductResponseDto> GetProductByIdAsync(int id);
        Task<bool> UpdateProductByIdAsync(int id, ProductCreateDto updatedProduct);
    }
}
