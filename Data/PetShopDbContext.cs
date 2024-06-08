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
                new DogSpecies {DogSpeciesId = 1 ,DogSpeciesName = " Golden Retriever" },
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
                new DogSpecies { DogSpeciesId = 18, DogSpeciesName = "Đồ cho chó" }
              

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
                },

                new DogItem
                {
                    DogItemId = 3,
                    DogName = "Bull ",
                    Price = 600,
                    Color = "Gray",
                    Sex = "Female",
                    Age = 1,
                    Type = "Chó chăn gia súc nhỏ",
                    Origin = "xứ Wales thuộc Vương quốc Anh",
                    HealthStatus = "Đã tiêm vacxin",
                    Description = "Thông minh và lanh lợi",
                    Images = "bull.jpg",
                    IsInStock = true,
                    IsDeleted= false,
                    DogSpeciesId= 4
                },
                new DogItem 
                {
                 DogItemId=4,
                    DogName = "Bill ",
                    Price = 650,
                    Color = "Black",
                    Sex = "Female",
                    Age = 2,
                    Type = "Chó săn vịt",
                    Origin = "Tây Âu",
                    HealthStatus = "Đã tiêm vacxin",
                    Description = "Thông minh ,lanh lợi,hoạt bát",
                    Images = "Bill.jpg",
                    IsInStock = true,
                    IsDeleted = false,
                    DogSpeciesId =8
                },
                new DogItem
                {
                    DogItemId=5,
                    DogName = "Bule ",
                    Price = 500,
                    Color = "Gray and white",
                    Sex = "Male",
                    Age = 3,
                    Type = "Chó kéo xe",
                    Origin = "Nga",
                    HealthStatus = "Đã tiêm vacxin",
                    Description = "Thông minh,cảnh giác,hiếu động",
                    Images = "Bule.jpg",
                    IsInStock = true,
                    IsDeleted = false,
                    DogSpeciesId = 3
                },
                new DogItem
                {
                    DogItemId=6,
                    DogName = "Kilu",
                    Price = 600,
                    Color = "Black and dark",
                    Sex = "Female",
                    Age = 1,
                    Type = "Chó cảnh",
                    Origin = "Nhật bản",
                    HealthStatus = "Đã tiêm vacxin,khỏe mạnh",
                    Description = "Bạo dạn,cảnh giác",
                    Images = "Kilu.jpg",
                    IsInStock = true,
                    IsDeleted = false,
                    DogSpeciesId = 10

                }

                );

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
                },
                new DogProductItem
                {
                    DogProductItemId = 3,
                    ItemName="Bát uống nước",
                    Price=100,
                    Category= "Furniture",
                    Description="một cái bát giúp cho chó được vệ sinh hơn",
                    Images= "Dog Bowls.jpg",
                    Quantity=40,
                    IsInStock = true,
                    IsDeleted = false

                },
                  new DogProductItem
                  {
                      DogProductItemId=4,
                      ItemName = "Nón cute",
                      Price = 120,
                      Category = "Accessories",//phụ kiện
                      Description = "Một phụ kiện cho chó",
                      Images = "DOG COLLAR.jpg",
                      Quantity = 41,
                      IsInStock = true,
                      IsDeleted = false
                  },
                  new DogProductItem
                  {
                       DogProductItemId=5,
                      ItemName = "Quần áo cho chó",
                      Price = 100,
                      Category = "Accessories",//phụ kiện
                      Description = "giúp chú chó xin xắn hơn",
                      Images = "Pet clothing.jpg",
                      Quantity = 30,
                      IsInStock = true,
                      IsDeleted = false
                  },
                  new DogProductItem
                  {
                       DogProductItemId=6,
                      ItemName = "Lồng chó",
                      Price = 150,
                      Category = "Furniture",
                      Description = "một cái lồng để nuôi chó",
                      Images = "dog cage.jpg",
                      Quantity = 10,
                      IsInStock = true,
                      IsDeleted = false
                  }



                );









        }
    }
}
