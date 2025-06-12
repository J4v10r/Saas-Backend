using Saas.Dto.TemplateDto;
using Saas.Models;

namespace Saas.Services.TemplateService
{
    public interface ITemplateService
    {
        Task AddTemplateAsync(TemplateCreateDto templateCreateDto);
        Task<bool> DeleteTemplateByIdAsync(int templateId);
        Task UpdateTemplateAsync(TemplateCreateDto templateCreateDto);
        Task<Template?> GetTemplateByIdAsync(int templateId);
        Task<IEnumerable<TemplateResponseDto>> GetAllTemplatesAsync();
        Task<IEnumerable<TemplateResponseDto>> GetActiveTemplatesAsync();
        Task<Template?> GetTemplateByNameAsync(string templateName);
    }
}
