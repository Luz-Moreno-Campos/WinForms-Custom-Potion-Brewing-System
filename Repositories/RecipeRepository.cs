
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
            var local = _context.Recipes
                .Include(r => r.RecipeIngredients)
                .FirstOrDefault(r => r.Id == recipe.Id);

            if (local != null)
            {
                local.Name = recipe.Name;
                local.SpecialEffect = recipe.SpecialEffect;
                local.BrewingDurationSeconds = recipe.BrewingDurationSeconds;

                foreach (var existingIngredient in local.RecipeIngredients.ToList())
                {
                    if (!recipe.RecipeIngredients.Any(ri => ri.IngredientId == existingIngredient.IngredientId))
                    {
                        _context.RecipeIngredients.Remove(existingIngredient);
                    }
                }

                foreach (var ingredientDto in recipe.RecipeIngredients)
                {
                    var existing = local.RecipeIngredients
                        .FirstOrDefault(ri => ri.IngredientId == ingredientDto.IngredientId);

                    if (existing != null)
                    {
                        existing.QuantityRequired = ingredientDto.QuantityRequired;
                    }
                    else
                    {
                        local.RecipeIngredients.Add(new RecipeIngredient
                        {
                            RecipeId = recipe.Id,
                            IngredientId = ingredientDto.IngredientId,
                            QuantityRequired = ingredientDto.QuantityRequired
                        });
                    }
                }
            }

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Recipe recipe)
        {
            _context.Recipes.Remove(recipe);

            await _context.SaveChangesAsync();
        }
    }
}
