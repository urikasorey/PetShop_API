using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Migrations
{
    public partial class data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DogItem",
                columns: new[] { "DogItemId", "Age", "Color", "CreateAt", "Description", "DogName", "DogSpeciesId", "HealthStatus", "Images", "IsDeleted", "IsInStock", "Origin", "Price", "Sex", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, "Golden", null, "Friendly and playful dog.", "Buddy", 1, "Healthy", "buddy.jpg", false, true, "United States", 500, "Male", "Labrador", null },
                    { 2, 3, "Black", null, "Intelligent and loyal companion.", "Max", 1, "Vaccinated", "max.jpg", false, true, "Germany", 550, "Male", "German Shepherd", null },
                    { 3, 4, "Gray",null,"Thông minh và lanh lợi","Bull",4, "Đã tiêm vacxin","bull.jpg",false,true,"xứ Wales thuộc Vương quốc Anh",600,"Female","Chó chăn gia súc nhỏ",null },
                    { 4, 5,"Black",null,"Thông minh ,lanh lợi,hoạt bát","Bill",8,"Đã tiêm vacxin","Bill.jpg",false,true,"Tây Âu",650,"Female","Chó săn vịt",null },
                    { 5, 6,"Gray and white",null,"Thông minh,cảnh giác,hiếu động","Bule",3,"Đã tiêm vacxin","Bule.jpg",false,true,"Nga",500,"Male","Chó kéo xe",null },
                    { 6, 7,  "Black and dark",null,"Bạo dạn,cảnh giác","Kilu",10,"Đã tiêm vacxin,khỏe mạnh","Kilu.jpg",false,true,"Nhật bản",600,"Female","Chó cảnh",null}

                });

            migrationBuilder.InsertData(
                table: "DogProductItem",
                columns: new[] { "DogProductItemId", "Category", "CreateAt", "Description", "Images", "IsDeleted", "IsInStock", "ItemName", "Price", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Accessories", null, "A strong and durable leash for walking your dog.", "leash.jpg", false, true, "Dog Leash", 20, 50, null },
                    { 2, "Furniture", null, "A comfortable bed for your dog to sleep on.", "bed.jpg", false, true, "Dog Bed", 50, 30, null },
                    { 3, "Furniture",null,"một cái bát giúp cho chó được vệ sinh hơn","Dog Bowls.jpg",false,true,"Bát uống nước" ,100 , 40,null },
                    { 4,"Accessories",null,"Một phụ kiện cho chó","DOG COLLAR.jpg",false,true,"Nón cute",120,41,null},
                    { 5,"Accessories",null, "giúp chú chó xin xắn hơn","Pet clothing.jpg",false,true,"Quần áo cho chó",100,30,null },
                    { 6,"Furniture",null,"một cái lồng để nuôi chó","dog cage.jpg",false,true,"Lồng chó",150,10,null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 2);
        }
    }
}
