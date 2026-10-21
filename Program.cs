using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinForms_Custom_Potion_Brewing_System.DataAccess;
using WinForms_Custom_Potion_Brewing_System.Forms;
using WinForms_Custom_Potion_Brewing_System.Repositories;
using WinForms_Custom_Potion_Brewing_System.Services;

namespace WinForms_Custom_Potion_Brewing_System
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<BrewingSystemDbContext>(options =>
                        options.UseSqlite("Data Source=PotionBrewingSystem.db"));

                    // Repositories

                    services.AddScoped<IngredientRepository>();
                    services.AddScoped<RecipeRepository>();
                    services.AddScoped<BrewedPotionRepository>();
                    services.AddScoped<RecipeIngredientRepository>();

                    // Services

                    services.AddScoped<IngredientService>();
                    services.AddScoped<RecipeService>();
                    services.AddScoped<BrewedPotionService>();
                    services.AddScoped<RecipeIngredientService>();


                    // Forms

                    services.AddTransient<DashboardForm>();
                    services.AddTransient<IngredientForm>();
                    services.AddTransient<RecipeForm>();
                    services.AddTransient<BrewingForm>();
                    services.AddTransient<PotionEffectForm>();
                })
                .Build();

            ApplicationConfiguration.Initialize();

            Application.Run(
                host.Services.GetRequiredService<DashboardForm>());
        }
    }
}