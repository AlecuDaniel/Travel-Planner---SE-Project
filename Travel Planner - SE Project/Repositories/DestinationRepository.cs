using Microsoft.EntityFrameworkCore;
using System;
using Travel_Planner___SE_Project.Models;

namespace Travel_Planner___SE_Project.Data.Repositories
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly TravelDbContext _context;

        public DestinationRepository(TravelDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Destination>> GetAllAsync()
        {
            return await _context.Destinations.ToListAsync();
        }

        public async Task<Destination?> GetByIdAsync(int id)
        {
            return await _context.Destinations.FindAsync(id);
        }

        public async Task AddAsync(Destination destination)
        {
            await _context.Destinations.AddAsync(destination);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Destination destination)
        {
            _context.Destinations.Update(destination);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var destination = await GetByIdAsync(id);
            if (destination != null)
            {
                _context.Destinations.Remove(destination);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Destinations.AnyAsync(d => d.DestinationId == id);
        }

        public async Task<IEnumerable<Destination>> SearchAsync(string query)
        {
            return await _context.Destinations
                .Where(d => EF.Functions.Like(d.Name.ToLower(), $"%{query.ToLower()}%") ||
                            EF.Functions.Like(d.Country.ToLower(), $"%{query.ToLower()}%"))
                .ToListAsync();
        }
    }
}
