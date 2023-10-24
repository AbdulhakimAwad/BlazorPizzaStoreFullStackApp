using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnBlazor.Server.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "Id", "ImgUrl", "PizzaName", "Price" },
                values: new object[] { 1, "Images/mushroomjpg.jpeg", "Mushroom", 20m });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "Id", "ImgUrl", "PizzaName", "Price" },
                values: new object[] { 2, "Images/carbonara.jpg", "Carbonara", 22.72m });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "Id", "ImgUrl", "PizzaName", "Price" },
                values: new object[] { 3, "Images/seafood.jpg", "Seafood", 37.40m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
