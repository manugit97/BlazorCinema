using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestMudBlazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Author", "Description", "Genre", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Cristopher Nolan", "A film about the creation of the nuclear bomb", "History", "Oppenheimer", 5 },
                    { 2, "Greta Gerwig", "A film about Barbie, the famous doll", "Comedy", "Barbie", 2 },
                    { 3, "James Wan", "A film about paranormal activities", "Horror", "The Conjuring", 3 },
                    { 4, "Roger Allers", "A film about Simba's life, a small lion cub", "Animation", "The Lion King", 4 },
                    { 5, "James Cameron", "A film about a cyborg assassin", "Action", "Terminator", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
