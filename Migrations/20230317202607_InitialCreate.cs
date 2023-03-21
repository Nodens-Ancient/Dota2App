using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dota2App.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MainAttribute = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MoveSpeed = table.Column<int>(type: "int", nullable: false),
                    BaseHealth = table.Column<int>(type: "int", nullable: false),
                    BaseHealthRegen = table.Column<float>(type: "float", nullable: false),
                    BaseMana = table.Column<int>(type: "int", nullable: false),
                    BaseManaRegen = table.Column<float>(type: "float", nullable: false),
                    BaseArmor = table.Column<float>(type: "float", nullable: false),
                    BaseMagicResist = table.Column<int>(type: "int", nullable: false),
                    BaseAttackDamageMin = table.Column<int>(type: "int", nullable: false),
                    BaseAttackDamageMax = table.Column<int>(type: "int", nullable: false),
                    BaseStrength = table.Column<int>(type: "int", nullable: false),
                    BaseAgility = table.Column<int>(type: "int", nullable: false),
                    BaseIntellect = table.Column<int>(type: "int", nullable: false),
                    StrengthGain = table.Column<float>(type: "float", nullable: false),
                    AgilityGain = table.Column<float>(type: "float", nullable: false),
                    IntellectGain = table.Column<float>(type: "float", nullable: false),
                    AttackRange = table.Column<int>(type: "int", nullable: false),
                    ProjectileSpeed = table.Column<int>(type: "int", nullable: false),
                    AttackSpeed = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cost = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
