using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonApi.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokedex",
                columns: table => new
                {
                    PokedexId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokedexNumber = table.Column<int>(type: "int", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Generation = table.Column<int>(type: "int", nullable: false),
                    EvolutionStage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evolved = table.Column<bool>(type: "bit", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false),
                    CrossGen = table.Column<bool>(type: "bit", nullable: false),
                    TypeOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeatherOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeatherTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatTotal = table.Column<int>(type: "int", nullable: false),
                    ATK = table.Column<int>(type: "int", nullable: false),
                    DEF = table.Column<int>(type: "int", nullable: false),
                    STA = table.Column<int>(type: "int", nullable: false),
                    Legendary = table.Column<bool>(type: "bit", nullable: false),
                    Aquireable = table.Column<int>(type: "int", nullable: false),
                    Spawns = table.Column<bool>(type: "bit", nullable: false),
                    Regional = table.Column<bool>(type: "bit", nullable: false),
                    Raidable = table.Column<int>(type: "int", nullable: false),
                    Hatchable = table.Column<int>(type: "int", nullable: false),
                    Shiny = table.Column<bool>(type: "bit", nullable: false),
                    Nest = table.Column<bool>(type: "bit", nullable: false),
                    New = table.Column<bool>(type: "bit", nullable: false),
                    NotGettable = table.Column<bool>(type: "bit", nullable: false),
                    FutureEvolve = table.Column<bool>(type: "bit", nullable: false),
                    CP40 = table.Column<int>(type: "int", nullable: false),
                    CP39 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedex", x => x.PokedexId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokedex");
        }
    }
}
