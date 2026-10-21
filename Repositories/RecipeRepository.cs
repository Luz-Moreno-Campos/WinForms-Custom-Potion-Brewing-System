
using Microsoft.EntityFrameworkCore;
using WinForms_Custom_Potion_Brewing_System.DataAccess;
using WinForms_Custom_Potion_Brewing_System.Models;

namespace WinForms_Custom_Potion_Brewing_System.Repositories
{
    public class RecipeRepository
    {
        private readonly BrewingSystemDbContext _context;

        public RecipeRepository(BrewingSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<Recipe>> GetAllAsync()
        {
            return await _context.Recipes
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                .OrderBy(r => r.Name)
                .ToListAsync();
        }

        public async Task<Recipe?> GetByIdAsync(int id)
        {
            return await _context.Recipes
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task AddAsync(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Recipe recipe)
        {
         
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Recipe recipe)
        {
            _context.Recipes.Remove(recipe);

            await _context.SaveChangesAsync();
        }
    }
}
