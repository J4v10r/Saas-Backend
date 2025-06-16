using Saas.Dto.TenantDto;

namespace Saas.Services.TenantServices
{
    public interface ITenantAuthService
    {
        Task<string?> Authenticate(TenantLoginDto tenantLoginDto);
    }
}
