
using Microsoft.EntityFrameworkCore;
using WinForms_Custom_Potion_Brewing_System.DataAccess;
using WinForms_Custom_Potion_Brewing_System.Models;

namespace WinForms_Custom_Potion_Brewing_System.Repositories
{
    public class BrewedPotionRepository
    {
        private readonly BrewingSystemDbContext _context;

        public BrewedPotionRepository(BrewingSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<BrewedPotion>> GetAllAsync()
        {
            return await _context.BrewedPotions
                .Include(bp => bp.Recipe)
                .OrderBy(bp => bp.CreatedAt)
                .ToListAsync();
        }

        public async Task<BrewedPotion?> GetByIdAsync(int id)
        {
            return await _context.BrewedPotions
                .Include(bp => bp.Recipe)
                .FirstOrDefaultAsync(bp => bp.Id == id);
        }

        public async Task AddAsync(BrewedPotion brewedPotion)
        {
            await _context.BrewedPotions.AddAsync(brewedPotion);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(BrewedPotion brewedPotion)
        {
            _context.BrewedPotions.Remove(brewedPotion);

            await _context.SaveChangesAsync();
        }
    }
}
