using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04Sklep.API.Migrations
{
    /// <inheritdoc />
    public partial class seedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "Title" },
                values: new object[,]
                {
                    { 11, "black", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Wooden Tuna" },
                    { 12, "ivory", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Rubber Ball" },
                    { 13, "teal", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Soft Chair" },
                    { 14, "lavender", "The Football Is Good For Training And Recreational Purposes", "Gorgeous Fresh Chair" },
                    { 15, "gold", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Frozen Towels" },
                    { 16, "sky blue", "The Football Is Good For Training And Recreational Purposes", "Tasty Cotton Bike" },
                    { 17, "lavender", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Frozen Tuna" },
                    { 18, "lavender", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Fresh Chair" },
                    { 19, "orchid", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Soft Soap" },
                    { 20, "pink", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Frozen Mouse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "yellow", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Soft Shirt" },
                    { 2, "yellow", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Steel Pizza" },
                    { 3, "red", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Soft Gloves" },
                    { 4, "green", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Steel Shoes" },
                    { 5, "green", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Plastic Mouse" },
                    { 6, "purple", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Frozen Pants" },
                    { 7, "white", "The Football Is Good For Training And Recreational Purposes", "Rustic Steel Cheese" },
                    { 8, "olive", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Licensed Fresh Hat" },
                    { 9, "sky blue", "The Football Is Good For Training And Recreational Purposes", "Awesome Soft Gloves" },
                    { 10, "fuchsia", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Cotton Chips" }
                });
        }
    }
}
