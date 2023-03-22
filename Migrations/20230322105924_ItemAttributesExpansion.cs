using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dota2App.Migrations
{
    /// <inheritdoc />
    public partial class ItemAttributesExpansion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "DayVision",
                table: "Heroes",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "NightVision",
                table: "Heroes",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "ItemAttribute",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Key = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Header = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAttribute_Items_ItemModelId",
                        column: x => x.ItemModelId,
                        principalTable: "Items",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemAttributeValue",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemAttributeId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAttributeValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAttributeValue_ItemAttribute_ItemAttributeId",
                        column: x => x.ItemAttributeId,
                        principalTable: "ItemAttribute",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttribute_ItemModelId",
                table: "ItemAttribute",
                column: "ItemModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributeValue_ItemAttributeId",
                table: "ItemAttributeValue",
                column: "ItemAttributeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemAttributeValue");

            migrationBuilder.DropTable(
                name: "ItemAttribute");

            migrationBuilder.DropColumn(
                name: "DayVision",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "NightVision",
                table: "Heroes");
        }
    }
}
