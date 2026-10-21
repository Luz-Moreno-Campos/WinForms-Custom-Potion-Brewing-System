using Microsoft.EntityFrameworkCore;
using WinForms_Custom_Potion_Brewing_System.Models;

namespace WinForms_Custom_Potion_Brewing_System.DataAccess
{
    public class BrewingSystemDbContext : DbContext
    {
        public BrewingSystemDbContext(DbContextOptions<BrewingSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public DbSet<BrewedPotion> BrewedPotions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Primary Keys

            modelBuilder.Entity<Ingredient>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<Recipe>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(ri => ri.Id);

            modelBuilder.Entity<BrewedPotion>()
                .HasKey(bp => bp.Id);

            // Properties and constraints

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.StockLevel)
                .IsRequired();

            modelBuilder.Entity<Recipe>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Recipe>()
                .Property(r => r.SpecialEffect)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Entity<Recipe>()
                .Property(r => r.BrewingDurationSeconds)
                .IsRequired();

            modelBuilder.Entity<RecipeIngredient>()
                .Property(ri => ri.QuantityRequired)
                .IsRequired();

            // This prevents duplicate ingredients inside the same recipe

            modelBuilder.Entity<RecipeIngredient>()
                .HasIndex(ri => new {
                    ri.RecipeId,
                    ri.IngredientId
                })
                .IsUnique();

            modelBuilder.Entity<BrewedPotion>()
                .Property(bp => bp.CreatedAt)
                .IsRequired();

            // Relationships

            // Recipe (1:N) RecipeIngredient

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Ingredient (1:N) RecipeIngredient

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId)
                .OnDelete(DeleteBehavior.Restrict);

            // Recipe (1:N) BrewedPotion

            modelBuilder.Entity<BrewedPotion>()
                .HasOne(bp => bp.Recipe)
                .WithMany(r => r.BrewedPotions)
                .HasForeignKey(bp => bp.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
