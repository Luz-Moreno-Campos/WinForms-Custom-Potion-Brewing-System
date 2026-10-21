
using WinForms_Custom_Potion_Brewing_System.Models;
using WinForms_Custom_Potion_Brewing_System.Repositories;

namespace WinForms_Custom_Potion_Brewing_System.Services
{
    public class RecipeService
    {
        private readonly RecipeRepository _recipeRepository;

        public RecipeService(RecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public async Task<List<Recipe>> GetAllRecipesAsync()
        {
            return await _recipeRepository.GetAllAsync();
        }

        public async Task<Recipe> GetRecipeByIdAsync(int id)
        {
            Recipe? recipe = await _recipeRepository.GetByIdAsync(id);

            if (recipe == null)
            {
                throw new Exception("Recipe not found.");
            }

            return recipe;
        }

        public async Task AddRecipeAsync(Recipe recipe)
        {
            await _recipeRepository.AddAsync(recipe);
        }

        public async Task UpdateRecipeAsync(Recipe recipe)
        {
            Recipe? existingRecipe = await _recipeRepository.GetByIdAsync(recipe.Id);

            if (existingRecipe == null)
            {
                throw new Exception("Recipe not found.");
            }

            await _recipeRepository.UpdateAsync(recipe);
        }

        public async Task DeleteRecipeAsync(int recipeId)
        {
            Recipe? recipe = await _recipeRepository.GetByIdAsync(recipeId);

            if (recipe == null)
            {
                throw new Exception("Recipe not found.");
            }

            await _recipeRepository.DeleteAsync(recipe);
        }
    }
}
