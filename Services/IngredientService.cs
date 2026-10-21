
using WinForms_Custom_Potion_Brewing_System.Models;
using WinForms_Custom_Potion_Brewing_System.Repositories;

namespace WinForms_Custom_Potion_Brewing_System.Services
{
    public class IngredientService
    {
        private readonly IngredientRepository _ingredientRepository;

        public IngredientService(IngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public async Task<List<Ingredient>> GetAllIngredientsAsync()
        {
            return await _ingredientRepository.GetAllAsync();
        }

        public async Task<Ingredient> GetIngredientByIdAsync(int id)
        {
            Ingredient? ingredient =await _ingredientRepository.GetByIdAsync(id);

            if (ingredient == null)
            {
                throw new Exception("Ingredient not found.");
            }

            return ingredient;
        }

        public async Task AddIngredientAsync(Ingredient ingredient)
        {
            await _ingredientRepository.AddAsync(ingredient);
        }

        public async Task AdjustStockAsync(int ingredientId,int quantityChange)
        {
            Ingredient ingredient = await GetIngredientByIdAsync(ingredientId);

            if (ingredient.StockLevel + quantityChange < 0)
            {
                throw new Exception(
                    "Stock cannot be negative.");
            }

            await _ingredientRepository.AdjustStockAsync(ingredientId, quantityChange);
        }

        public async Task DeleteIngredientAsync(int ingredientId)
        {
            Ingredient? ingredient = await GetIngredientByIdAsync(ingredientId);

            await _ingredientRepository.DeleteAsync(ingredient);
        }
    }
}

