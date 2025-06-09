using Saas.Dto.TenantDto;

namespace Saas.Services.AuthService
{
    public interface IAuthService
    {
        Task<string?> AuthTenant(string email, string password);
    }
}
