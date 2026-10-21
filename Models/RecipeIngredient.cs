using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Custom_Potion_Brewing_System.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; } = null!;

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; } = null!;

        public int QuantityRequired { get; set; }
    }
}
