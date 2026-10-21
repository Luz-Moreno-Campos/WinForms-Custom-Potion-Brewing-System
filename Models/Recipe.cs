using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Custom_Potion_Brewing_System.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string SpecialEffect { get; set; } = string.Empty;

        public int BrewingDurationSeconds { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
            = new List<RecipeIngredient>();

        public ICollection<BrewedPotion> BrewedPotions { get; set; }
            = new List<BrewedPotion>();
    }
}
