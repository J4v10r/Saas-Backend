using AutoMapper;
using Saas.Dto.CatalogDto;
using Saas.Models;
using Saas.Repository.CatalogRep;

namespace Saas.Services.CatalogService
{
    public class CatalogService: ICatalogService{
        private readonly ICatalogRepository _catalogRepository;
        private readonly ILogger<CatalogService> _logger;
        private readonly IMapper _mapper;

        public CatalogService(ICatalogRepository catalogRepository, ILogger<CatalogService> logger, IMapper mapper){
            _catalogRepository = catalogRepository;
            _logger = logger;   
            _mapper = mapper;
        }

        public async Task<CatalogResponseDto> AddCatalogAsync(CatalogCreateDto catalogCreateDto)
        {
            try
            {
                var catalog = _mapper.Map<Catalog>(catalogCreateDto);
                await _catalogRepository.AddCatalogAsync(catalog);
                return _mapper.Map<CatalogResponseDto>(catalog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adicionar catálogo.");
                throw;
            }
        }

        public async Task<bool> DeleteCatalogAsync(int catalogId)
        {
            try
            {
                return await _catalogRepository.DeleteCatalogByIdAsync(catalogId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar catálogo com ID: {catalogId}.");
                throw;
            }
        }

        public async Task<IEnumerable<CatalogResponseDto>> GetAllCatalogsAsync()
        {
            try
            {
                var catalogs = await _catalogRepository.GetAllCatalogsAsync();
                return _mapper.Map<IEnumerable<CatalogResponseDto>>(catalogs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todos os catálogos.");
                throw;
            }
        }

        public async Task<CatalogResponseDto?> GetCatalogByIdAsync(int catalogId)
        {
            try
            {
                var catalog = await _catalogRepository.GetCatalogByIdAsync(catalogId);
                return _mapper.Map<CatalogResponseDto?>(catalog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao obter catálogo com ID: {catalogId}.");
                throw;
            }
        }

        public async Task<IEnumerable<CatalogResponseDto>> GetCatalogsByTemplateIdAsync(int templateId)
        {
            try
            {
                var catalogs = await _catalogRepository.GetCatalogsByTemplateIdAsync(templateId);
                return _mapper.Map<IEnumerable<CatalogResponseDto>>(catalogs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao obter catálogos com Template ID: {templateId}.");
                throw;
            }
        }

        public async Task<IEnumerable<CatalogResponseDto>> GetCatalogsByTenantIdAsync(int tenantId)
        {
            try
            {
                var catalogs = await _catalogRepository.GetCatalogsByTenantIdAsync(tenantId);
                return _mapper.Map<IEnumerable<CatalogResponseDto>>(catalogs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao obter catálogos com Tenant ID: {tenantId}.");
                throw;
            }
        }
    }
}
