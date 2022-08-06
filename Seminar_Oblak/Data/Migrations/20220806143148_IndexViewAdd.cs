using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seminar_Oblak.Data.Migrations
{
    public partial class IndexViewAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategoryUpdateBinding");

            migrationBuilder.DropTable(
                name: "ProductViewModel");

            migrationBuilder.DropTable(
                name: "ProductCategoryViewModel");

            migrationBuilder.CreateTable(
                name: "FileStorage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhysicalPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileStorage", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileStorage");

            migrationBuilder.CreateTable(
                name: "ProductCategoryUpdateBinding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryUpdateBinding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductViewModel_ProductCategoryViewModel_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategoryViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductViewModel_ProductCategoryId",
                table: "ProductViewModel",
                column: "ProductCategoryId");
        }
    }
}
