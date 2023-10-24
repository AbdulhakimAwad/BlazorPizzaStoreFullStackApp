using Microsoft.EntityFrameworkCore;

namespace LearnBlazor.Server.Data
{
    public class AppDbCtx : DbContext
    {
        public AppDbCtx(DbContextOptions<AppDbCtx> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza
                {
                    Id = 1,
                    PizzaName = "Mushroom",
                    Price = 20m,
                    ImgUrl = "Images/mushroomjpg.jpeg"
                },
                new Pizza
                {
                    Id = 2,
                    PizzaName = "Carbonara",
                    Price = 22.72m,
                    ImgUrl = "Images/carbonara.jpg"
                },
                new Pizza
                {
                    Id = 3,
                    PizzaName = "Seafood",
                    Price = 37.40m,
                    ImgUrl = "Images/seafood.jpg"
                }
            );
        }
        public DbSet<Pizza> Pizza { get; set; }
    }
}
