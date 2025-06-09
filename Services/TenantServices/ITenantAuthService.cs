using Saas.Dto.TenantDto;

namespace Saas.Services.TenantServices
{
    public interface ITenantAuthService
    {
        Task<TenantAuthResponseDto> Authenticate(TenantLoginDto model);
    }
}
