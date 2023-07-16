using PlatformService.Models;

namespace PlatformService.data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var ServiceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(ServiceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                System.Console.WriteLine("Seeding Platforms");
                context.Platforms.AddRange(
                    new Platform() { Name = "Dotnet", Publisher = "Microsoft", cost = "free" },
                    new Platform() { Name = "Sql server", Publisher = "Microsoft", cost = "free" },
                    new Platform() { Name = "kubernetes", Publisher = "Cloud Native Foundation", cost = "free" }
                );
                
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("---> There are already platforms in the database");
            }
        }
    }
}