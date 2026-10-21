
using WinForms_Custom_Potion_Brewing_System.Models;
using WinForms_Custom_Potion_Brewing_System.Repositories;

namespace WinForms_Custom_Potion_Brewing_System.Services
{
    internal class BrewedPotionService
    {
        /* 
         
         This service uses existing services for BrewPotionAsync()
         in order to reuse validation logic and avoid duplicating 
         business rules. This also enhances maintainability
         and future refactoring.

        */
        private readonly BrewedPotionRepository _brewedPotionRepository;
        private readonly RecipeService _recipeService;
        private readonly IngredientService _ingredientService;

        public BrewedPotionService(
            BrewedPotionRepository brewedPotionRepository,
            RecipeService recipeService,
            IngredientService ingredientService)
        {
            _brewedPotionRepository = brewedPotionRepository;
            _recipeService = recipeService;
            _ingredientService = ingredientService;
        }

        public async Task<List<BrewedPotion>> GetAllBrewedPotionsAsync()
        {
            return await _brewedPotionRepository.GetAllAsync();
        }

        public async Task<BrewedPotion> GetBrewedPotionByIdAsync(int id)
        {
            BrewedPotion? brewedPotion = await _brewedPotionRepository.GetByIdAsync(id);

            if (brewedPotion == null)
            {
                throw new Exception("Brewed potion not found.");
            }

            return brewedPotion;
        }

        public async Task BrewPotionAsync(int recipeId)
        {
            Recipe recipe = await _recipeService.GetRecipeByIdAsync(recipeId);

            foreach (RecipeIngredient recipeIngredient in recipe.RecipeIngredients)
            {
                Ingredient? ingredient = await _ingredientService.GetIngredientByIdAsync(
                        recipeIngredient.IngredientId);

                if (ingredient?.StockLevel < recipeIngredient.QuantityRequired)
                {
                    throw new Exception($"Insufficient stock for {ingredient.Name}.");
                }
            }


            foreach (RecipeIngredient recipeIngredient in recipe.RecipeIngredients)
            {
                await _ingredientService.AdjustStockAsync(
                    recipeIngredient.IngredientId,
                    -recipeIngredient.QuantityRequired);
            }

            BrewedPotion brewedPotion = new BrewedPotion
            {
                RecipeId = recipe.Id,
                CreatedAt = DateTime.Now
            };

            await _brewedPotionRepository.AddAsync(brewedPotion);
        }
           

        public async Task DeleteBrewedPotionAsync(int brewedPotionId)
        {
            BrewedPotion brewedPotion = await GetBrewedPotionByIdAsync(brewedPotionId);

            await _brewedPotionRepository.DeleteAsync(brewedPotion);
        }

        public async Task<string> ConsumePotionAsync(int brewedPotionId)
        {
            BrewedPotion brewedPotion = await GetBrewedPotionByIdAsync(brewedPotionId);

            string specialEffect = brewedPotion.Recipe.SpecialEffect;

            await _brewedPotionRepository.DeleteAsync(brewedPotion);

            return specialEffect;
        }
    }
}
