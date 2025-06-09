using Saas.Dto.UserDto;
using Saas.Models;

namespace Saas.Services.UserServices
{
    public interface IUserService
    {
        Task AddUserAsync(UserCreateDto user);
        Task<bool> UpdateUserAsync(int id, UserCreateDto user);
        Task<bool> DeleteUserAsync(int id);
        Task<UserResponseDto?> GetUserByCpfAsync(string cpf);
        Task<UserResponseDto?> GetUserByEmailAsync(string email);
        Task<IEnumerable<UserResponseDto>> GetUsersByCatalogAsync(int catalogId);
        Task<int> GetUsersCountByCatalogAsync(int catalogId);
        Task<IEnumerable<UserResponseDto>> GetAllUsersInCatalogAsync(int catalogId);
    }
}
