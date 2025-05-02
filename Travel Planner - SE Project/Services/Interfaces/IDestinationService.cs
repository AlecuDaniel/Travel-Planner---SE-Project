using Travel_Planner___SE_Project.Models;

namespace Travel_Planner___SE_Project.Services
{
    public interface IDestinationService
    {
        Task<IEnumerable<Destination>> GetAllAsync();
        Task<Destination?> GetByIdAsync(int id);
        Task AddAsync(Destination destination);
        Task UpdateAsync(Destination destination);
        Task DeleteAsync(int id);
    }
}
