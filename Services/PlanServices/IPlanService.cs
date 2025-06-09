using Mysqlx.Crud;
using Saas.Dto.PlanDto;
using Saas.Models;

namespace Saas.Services.PlanServices
{
    public interface IPlanService
    {
        Task<bool> CreatPlanAsync(PlanCreateDto planCreateDto);
        Task<bool> DeletePlanAsync(int id);
        Task<bool> UpdatePlanAsync(int id, PlanUpdateDto updatedPlan);
        Task<IEnumerable<PlanResponseDto>> GetAllPlansAsync();
        Task<PlanResponseDto> GetPlanByIdAsync(int id);
    }
}


