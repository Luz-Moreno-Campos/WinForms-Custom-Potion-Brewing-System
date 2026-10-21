
using WinForms_Custom_Potion_Brewing_System.DataAccess;
using WinForms_Custom_Potion_Brewing_System.Models;

namespace WinForms_Custom_Potion_Brewing_System.Repositories
{
    public class RecipeIngredientRepository
    {
        private readonly BrewingSystemDbContext _context;

        public RecipeIngredientRepository(BrewingSystemDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(RecipeIngredient recipeIngredient)
        {
            await _context.RecipeIngredients.AddAsync(recipeIngredient);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(RecipeIngredient recipeIngredient)
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(RecipeIngredient recipeIngredient)
        {
            _context.RecipeIngredients.Remove(recipeIngredient);

            await _context.SaveChangesAsync();
        }
    }
}
