using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public static class SeedDataExtensions
    {
        public static void SeedCars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car[]
            {
                new Car()
                {
                    Id = 1,
                    Model = "F8 Spider",
                    ColorId = (int)Colors.Yellow,
                    StoKMh = 2.9,
                    Price = 274280,
                    Description = "The F8 Spider’s greatest achievement is the fact that it unleashes its power instantaneously with zero turbo lag, whilst retaining this V8’s unique and very special soundtrack.",
                    ImagePath = @"https://i.wpimg.pl/1920x0/m.autokult.pl/ferrari-f8-spider-4-be8031ebb9c0.jpg"
                },
                new Car()
                {
                    Id = 2,
                    Model = "Ferrari Portofino M",
                    ColorId = (int)Colors.Silver,
                    StoKMh = 3.45,
                    Price = 230950,
                    Description = "The Ferrari Portofino M’s engine belongs to the V8 turbo family voted “International Engine of the Year” on four consecutive occasions. The power unit can punch out 620 cv, 20 more than the Ferrari Portofino, thanks to new cam profiles and the introduction of a new speed sensor on the turbocharger assembly to measure the turbine revolutions. A new Gasoline Particulate Filter allows the car to comply with the strictest European anti-pollution standards (Euro-6D) without compromising driving pleasure.",
                    ImagePath = @"https://ocdn.eu/images/pulscms/MTE7MDA_/a4ee38a1d3741562afa4faa20746f704.jpg"
                },
                new Car()
                {
                    Id = 3,
                    Model = "FERRARI 812 COMPETIZIONE",
                    ColorId = (int)Colors.SpaceGray,
                    StoKMh = 2.9,
                    Price = 601570,
                    Description = "To maintain the traditional, incredibly high standard of engine sound whilst simultaneously introducing a GPF (Gasoline Particulate Filter), a new exhaust tailpipe was added. This design solution reinstates medium-high frequency sound. In order to deliver excellent acoustics, performance and aesthetics, the exhaust tailpipes are visible to underscore their function and the car’s track-inspired character. The addition of a second pair of resonators enhances the engine’s more noble combustion order harmonics, creating the perfect melding of the sound from the exhaust and from the intake system.",
                    ImagePath = @"https://profiauto.pl/blog/wp-content/uploads/2021/05/Ferrari-812-Competizione.jpg"
                },
            });
        }
        public static void SeedColors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().HasData(new Color[]
            {
                new Color() { Id = (int)Colors.Silver, Name = "Silver" },
                new Color() { Id = (int)Colors.Black, Name = "Black" },
                new Color() { Id = (int)Colors.Yellow, Name = "Yellow" },
                new Color() { Id = (int)Colors.SpaceGray, Name = "Space Gray" },
                new Color() { Id = (int)Colors.Red, Name = "Red" },
                new Color() { Id = (int)Colors.White, Name = "White" },
                new Color() { Id = (int)Colors.Lime, Name = "Lime" },
                new Color() { Id = (int)Colors.Gold, Name = "Gold" },
                new Color() { Id = (int)Colors.Aqua, Name = "Aqua" },
                new Color() { Id = (int)Colors.Gray, Name = "Gray" },
            });
        }
    }
}
