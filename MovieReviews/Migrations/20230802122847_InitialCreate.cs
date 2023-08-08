using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReviews.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "Review", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", "/images/movies/Highlander.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit.", "Highlander" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", "/images/movies/Godfather.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit.", "Godfather" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", "/images/movies/LastOfTheMohicans.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit.", "Last of the Mohicans" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", "/images/movies/RearWindow.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit.", "Rear Window" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", "/images/movies/RoadHouse.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit.", "Road House" },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", "/images/movies/StarTreck4.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit.", "Star Trek IV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
