using Saas.Dto.UserDto;

namespace Saas.Services.UserServices
{
    public interface IUserAuthService
    {
        Task<string?> Authenticate(UserLoginDto userLoginDto);
    }
}
