using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetShopDbContext: IdentityDbContext<ApplicationUser>
    {
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartDetail> CartDetail { get; set; }
        public DbSet<DogItem> DogItem { get; set; }
        public DbSet<DogProductItem> DogProductItem { get; set; }
        public DbSet<DogSpecies> DogSpecies { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<ShipInfo> ShipInfo { get; set; }
        public DbSet<Checkout> Checkout {  get; set; }
        public DbSet<Voucher> Voucher { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>(o =>
            {
                o.HasIndex(u => u.PhoneNumber).IsUnique();
            }
            );

            builder.Entity<Voucher>(o =>
            {
                o.HasIndex(u => u.Code).IsUnique();
            });

            builder.Entity<DogSpecies>().HasData(
                new DogSpecies {DogSpeciesId = 1 ,DogSpeciesName = "Golden Retriever"},
                new DogSpecies {DogSpeciesId = 2 ,DogSpeciesName = "Alaska"},
                new DogSpecies {DogSpeciesId = 3 ,DogSpeciesName = "Husky"},
                new DogSpecies {DogSpeciesId = 4 ,DogSpeciesName = "Corgi"},
                new DogSpecies {DogSpeciesId = 5 ,DogSpeciesName = "Doberman" },
                new DogSpecies {DogSpeciesId = 6 ,DogSpeciesName = "Pitbull"},
                new DogSpecies {DogSpeciesId = 7 ,DogSpeciesName = "Lạp Xưởng"},
                new DogSpecies {DogSpeciesId = 8 ,DogSpeciesName = "Poodle"},
                new DogSpecies {DogSpeciesId = 9 ,DogSpeciesName = "Chihuahua"},
                new DogSpecies {DogSpeciesId = 10,DogSpeciesName = "Shiba" },
                new DogSpecies { DogSpeciesId = 11, DogSpeciesName = "Siamese" },
                new DogSpecies { DogSpeciesId = 12, DogSpeciesName = "Maine Coon" },
                new DogSpecies { DogSpeciesId = 13, DogSpeciesName = "Persian" },
                new DogSpecies { DogSpeciesId = 14, DogSpeciesName = "Bengal" },
                new DogSpecies { DogSpeciesId = 15, DogSpeciesName = "Sphynx" },
                new DogSpecies { DogSpeciesId = 16, DogSpeciesName = "Munchkin" },
                new DogSpecies { DogSpeciesId = 17, DogSpeciesName = "Scottish Fold" },
                new DogSpecies { DogSpeciesId = 18, DogSpeciesName = "Đồ cho chó" },
                new DogSpecies { DogSpeciesId = 19, DogSpeciesName = "Đồ cho mèo" }

            );
            builder.Entity<DogItem>().HasData(
                new DogItem
                {
                    DogItemId = 1,
                    DogName = "Buddy",
                    Price = 500,
                    Color = "Golden",
                    Sex = "Male",
                    Age = 2,
                    Type = "Labrador",
                    Origin = "United States",
                    HealthStatus = "Healthy",
                    Description = "Friendly and playful dog.",
                    Images = "buddy.jpg",
                    IsInStock = true,
                    IsDeleted = false,
                    DogSpeciesId = 1
                },
                new DogItem
                {
                    DogItemId = 2,
                    DogName = "Max",
                    Price = 550,
                    Color = "Black",
                    Sex = "Male",
                    Age = 3,
                    Type = "German Shepherd",
                    Origin = "Germany",
                    HealthStatus = "Vaccinated",
                    Description = "Intelligent and loyal companion.",
                    Images = "max.jpg",
                    IsInStock = true,
                    IsDeleted = false,
                    DogSpeciesId = 1
                });
            builder.Entity<DogProductItem>().HasData(
                new DogProductItem
                {
                    DogProductItemId = 1,
                    ItemName = "Dog Leash",
                    Price = 20,
                    Category = "Accessories",
                    Description = "A strong and durable leash for walking your dog.",
                    Images = "leash.jpg",
                    Quantity = 50,
                    IsInStock = true,
                    IsDeleted = false
                },
                new DogProductItem
                {
                    DogProductItemId = 2,
                    ItemName = "Dog Bed",
                    Price = 50,
                    Category = "Furniture",
                    Description = "A comfortable bed for your dog to sleep on.",
                    Images = "bed.jpg",
                    Quantity = 30,
                    IsInStock = true,
                    IsDeleted = false
                }


                );









        }
    }
}
