
using Microsoft.EntityFrameworkCore;
using WinForms_Custom_Potion_Brewing_System.DataAccess;
using WinForms_Custom_Potion_Brewing_System.Models;

namespace WinForms_Custom_Potion_Brewing_System.Repositories
{
    public class IngredientRepository
    {
        private readonly BrewingSystemDbContext _context;

        public IngredientRepository(BrewingSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ingredient>> GetAllAsync()
        {
            return await _context.Ingredients
                .OrderBy(i => i.Name)
                .ToListAsync();
        }

        public async Task<Ingredient?> GetByIdAsync(int id)
        {
            return await _context.Ingredients
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task AddAsync(Ingredient ingredient)
        {
            await _context.Ingredients.AddAsync(ingredient);

            await _context.SaveChangesAsync();
        }

        public async Task AdjustStockAsync(int ingredientId, int quantityChange)
        {
            Ingredient? ingredient = await GetByIdAsync(ingredientId);

            if (ingredient is null)
            {
                return;
            }

            ingredient.StockLevel += quantityChange;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Ingredient ingredient)
        {
            _context.Ingredients.Remove(ingredient);

            await _context.SaveChangesAsync();

            /*
             Clears EF Core's tracking memory to prevent  
             foreign key errors after deleting records.
            */
            _context.ChangeTracker.Clear();
        }
    }
}
