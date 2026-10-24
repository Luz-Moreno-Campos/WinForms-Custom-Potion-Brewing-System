
namespace WinForms_Custom_Potion_Brewing_System.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int StockLevel { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
            = new List<RecipeIngredient>();
    }
}
