using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seminar_Oblak.Data.Migrations
{
    public partial class ImgUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductImgUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImgUrl",
                table: "Product");
        }
    }
}
