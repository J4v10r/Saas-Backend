using Saas.Dto.AdminDto;
using Saas.Models;

namespace Saas.Services.AdminService
{
    public interface IAdminService
    {
        Task<bool> CreateAdminAsync(AdminCreatDto adminCreatDto);
        Task<bool> DeleteAdminAsync(int id);



    }
}
