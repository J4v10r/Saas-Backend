﻿using Saas.Dto.CatalogDto;

namespace Saas.Services.CatalogService
{
    public interface ICatalogService
    {
        Task<CatalogResponseDto> AddCatalogAsync(CatalogCreateDto catalogCreateDto);
        Task<bool> DeleteCatalogAsync(int catalogId);
        Task<IEnumerable<CatalogResponseDto>> GetAllCatalogsAsync();
        Task<CatalogResponseDto?> GetCatalogByIdAsync(int catalogId);
        Task<IEnumerable<CatalogResponseDto>> GetCatalogsByTemplateIdAsync(int templateId);
        Task<IEnumerable<CatalogResponseDto>> GetCatalogsByTenantIdAsync(int tenantId);
        //Task UpdateCatalogAsync(int catalogId, CatalogUpdateDto catalogUpdateDto);
    }
}
