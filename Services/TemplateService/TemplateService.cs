using AutoMapper;
using Saas.Dto.TemplateDto;
using Saas.Models;
using Saas.Repository.TemplateRep;

namespace Saas.Services.TemplateService
{
    public class TemplateService : ITemplateService{
        private readonly ITemplateRepository _templateRepository;
        private readonly ILogger<TemplateService> _logger;
        private readonly IMapper _mapper;
        public TemplateService(ITemplateRepository templateRepository, ILogger<TemplateService> logger, IMapper mapper)
        {
            _templateRepository = templateRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddTemplateAsync(TemplateCreateDto templateCreateDto)
        {
            try
            {
                var template = _mapper.Map<Template>(templateCreateDto);
                await _templateRepository.AddTemplateAsync(template);
                _logger.LogInformation("Template adicionado com sucesso.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adicionar template.");
                throw;
            }
        }

        public async Task<bool> DeleteTemplateByIdAsync(int templateId)
        {
            try
            {
                return await _templateRepository.DeleteTemplateByIdAsync(templateId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar template com ID {templateId}.");
                throw;
            }
        }

        public async Task<IEnumerable<TemplateResponseDto>> GetActiveTemplatesAsync()
        {
            try
            {
                var templates = await _templateRepository.GetActiveTemplatesAsync();
                return _mapper.Map<IEnumerable<TemplateResponseDto>>(templates);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter templates ativos.");
                throw;
            }
        }

        public async Task<IEnumerable<TemplateResponseDto>> GetAllTemplatesAsync()
        {
            try
            {
                var templates = await _templateRepository.GetAllTemplatesAsync();
                return _mapper.Map<IEnumerable<TemplateResponseDto>>(templates);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todos os templates.");
                throw;
            }
        }

        public async Task<Template?> GetTemplateByIdAsync(int templateId)
        {
            try
            {
                return await _templateRepository.GetTemplateByIdAsync(templateId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar template por ID {templateId}.");
                throw;
            }
        }

        public async Task<Template?> GetTemplateByNameAsync(string templateName)
        {
            try
            {
                return await _templateRepository.GetTemplateByNameAsync(templateName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar template por nome {templateName}.");
                throw;
            }
        }

        public async Task UpdateTemplateAsync(TemplateCreateDto templateCreateDto)
        {
            try
            {
                var template = _mapper.Map<Template>(templateCreateDto);
                await _templateRepository.UpdateTemplateAsync(template);
                _logger.LogInformation("Template atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar template.");
                throw;
            }
        }
    }
}
