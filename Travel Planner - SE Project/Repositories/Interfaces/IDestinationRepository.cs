using Travel_Planner___SE_Project.Models;

namespace Travel_Planner___SE_Project.Data.Repositories
{
    public interface IDestinationRepository
    {
        Task<IEnumerable<Destination>> GetAllAsync();
        Task<Destination?> GetByIdAsync(int id);
        Task AddAsync(Destination destination);
        Task UpdateAsync(Destination destination);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<IEnumerable<Destination>> SearchAsync(string query);
    }
}
