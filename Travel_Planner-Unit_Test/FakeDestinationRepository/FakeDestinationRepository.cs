using Travel_Planner___SE_Project.Data.Repositories;
using Travel_Planner___SE_Project.Models;

namespace Travel_Planner_Unit_Test
{
    // A simple fake repository implementation
    public class FakeDestinationRepository : IDestinationRepository
    {
        private readonly List<Destination> _destinations = new()
        {
            new Destination { DestinationId = 1, Name = "Paris", Country = "France" },
            new Destination { DestinationId = 2, Name = "Tokyo", Country = "Japan" },
            new Destination { DestinationId = 3, Name = "Parioli", Country = "Italy" }
        };

        public Task<IEnumerable<Destination>> GetAllAsync() => Task.FromResult<IEnumerable<Destination>>(_destinations);

        public Task<Destination?> GetByIdAsync(int id) =>
            Task.FromResult(_destinations.FirstOrDefault(d => d.DestinationId == id));

        public Task AddAsync(Destination destination)
        {
            _destinations.Add(destination);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Destination destination)
        {
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            return Task.CompletedTask;
        }

        public Task<bool> ExistsAsync(int id) =>
            Task.FromResult(_destinations.Any(d => d.DestinationId == id));

        public Task<IEnumerable<Destination>> SearchAsync(string query)
        {
            var result = _destinations
                .Where(d => d.Name.ToLower().Contains(query.ToLower()) ||
                            d.Country.ToLower().Contains(query.ToLower()));
            return Task.FromResult<IEnumerable<Destination>>(result);
        }
    }
}