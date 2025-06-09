﻿using Saas.Dto.TenantDto;
using Saas.Models;

namespace Saas.Services.TenantServices
{
    public interface ITenantService{
        Task<bool> CreateAsync(TenantCreatDto dto);
        Task<IEnumerable<TenantResponseDto>> GetAllTenantsAsync();
        Task<bool> RemoveTenantAsync(int id);
        Task<TenantResponseDto> GetTenant(int id);
        Task<Tenant?> GetTenantByEmailAsync(string email);
    }
}
