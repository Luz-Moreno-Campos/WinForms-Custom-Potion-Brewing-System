using Microsoft.EntityFrameworkCore;
using WinForms_Custom_Potion_Brewing_System.DataAccess;
using WinForms_Custom_Potion_Brewing_System.Models;

namespace WinForms_Custom_Potion_Brewing_System.Seed
{
    public static class SeedData
    {
        public static async Task InitializeAsync(BrewingSystemDbContext context)
        {
            if (await context.Ingredients.AnyAsync())
            {
                return;
            }

            // Ingredients

            Ingredient dragonScale = new Ingredient
            {
                Name = "Dragon Scale",
                StockLevel = 20
            };

            Ingredient phoenixFeather = new Ingredient
            {
                Name = "Phoenix Feather",
                StockLevel = 15
            };

            Ingredient crystalWater = new Ingredient
            {
                Name = "Crystal Water",
                StockLevel = 30
            };

            Ingredient moonHerb = new Ingredient
            {
                Name = "Moon Herb",
                StockLevel = 25
            };

            Ingredient unicornHair = new Ingredient
            {
                Name = "Unicorn Hair",
                StockLevel = 10
            };

            Ingredient goblinDust = new Ingredient
            {
                Name = "Goblin Dust",
                StockLevel = 18
            };

            Ingredient mermaidTear = new Ingredient
            {
                Name = "Mermaid Tear",
                StockLevel = 12
            };

            Ingredient shadowMushroom = new Ingredient
            {
                Name = "Shadow Mushroom",
                StockLevel = 22
            };

            await context.Ingredients.AddRangeAsync(
                dragonScale,
                phoenixFeather,
                crystalWater,
                moonHerb,
                unicornHair,
                goblinDust,
                mermaidTear,
                shadowMushroom);

            // Recipes

            Recipe healingPotion = new Recipe
            {
                Name = "Healing Potion",
                SpecialEffect = "Restores 50 HP",
                BrewingDurationSeconds = 10
            };

            Recipe fireResistancePotion = new Recipe
            {
                Name = "Fire Resistance Potion",
                SpecialEffect = "Provides Fire Resistance",
                BrewingDurationSeconds = 15
            };

            Recipe invisibilityPotion = new Recipe
            {
                Name = "Invisibility Potion",
                SpecialEffect = "Grants Temporary Invisibility",
                BrewingDurationSeconds = 20
            };

            Recipe manaPotion = new Recipe
            {
                Name = "Mana Potion",
                SpecialEffect = "Restores Magical Energy",
                BrewingDurationSeconds = 12
            };

            await context.Recipes.AddRangeAsync(
                healingPotion,
                fireResistancePotion,
                invisibilityPotion,
                manaPotion);

            await context.SaveChangesAsync();

            // RecipeIngredients

            await context.RecipeIngredients.AddRangeAsync(

                // Healing Potion

                new RecipeIngredient
                {
                    RecipeId = healingPotion.Id,
                    IngredientId = crystalWater.Id,
                    QuantityRequired = 2
                },

                new RecipeIngredient
                {
                    RecipeId = healingPotion.Id,
                    IngredientId = moonHerb.Id,
                    QuantityRequired = 3
                },

                // Fire Resistance Potion

                new RecipeIngredient
                {
                    RecipeId = fireResistancePotion.Id,
                    IngredientId = dragonScale.Id,
                    QuantityRequired = 1
                },

                new RecipeIngredient
                {
                    RecipeId = fireResistancePotion.Id,
                    IngredientId = phoenixFeather.Id,
                    QuantityRequired = 2
                },

                // Invisibility Potion

                new RecipeIngredient
                {
                    RecipeId = invisibilityPotion.Id,
                    IngredientId = shadowMushroom.Id,
                    QuantityRequired = 2
                },

                new RecipeIngredient
                {
                    RecipeId = invisibilityPotion.Id,
                    IngredientId = goblinDust.Id,
                    QuantityRequired = 2
                },

                new RecipeIngredient
                {
                    RecipeId = invisibilityPotion.Id,
                    IngredientId = unicornHair.Id,
                    QuantityRequired = 1
                },

                // Mana Potion

                new RecipeIngredient
                {
                    RecipeId = manaPotion.Id,
                    IngredientId = mermaidTear.Id,
                    QuantityRequired = 2
                },

                new RecipeIngredient
                {
                    RecipeId = manaPotion.Id,
                    IngredientId = crystalWater.Id,
                    QuantityRequired = 1
                });

            await context.SaveChangesAsync();
        }
    }
}