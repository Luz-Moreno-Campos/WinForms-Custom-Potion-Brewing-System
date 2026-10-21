
using WinForms_Custom_Potion_Brewing_System.Models;
using WinForms_Custom_Potion_Brewing_System.Repositories;

namespace WinForms_Custom_Potion_Brewing_System.Services
{
    public class RecipeIngredientService
    {
        private readonly RecipeIngredientRepository _recipeIngredientRepository;

        public RecipeIngredientService(RecipeIngredientRepository recipeIngredientRepository)
        {
            _recipeIngredientRepository = recipeIngredientRepository;
        }

        public async Task AddRecipeIngredientAsync(RecipeIngredient recipeIngredient)
        {
            await _recipeIngredientRepository.AddAsync(recipeIngredient);
        }

        public async Task UpdateRecipeIngredientAsync(RecipeIngredient recipeIngredient)
        {
            await _recipeIngredientRepository.UpdateAsync(recipeIngredient);
        }

        public async Task DeleteRecipeIngredientAsync(RecipeIngredient recipeIngredient)
        {
            await _recipeIngredientRepository.DeleteAsync(recipeIngredient);
        }
    }
}
