using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seminar_Oblak.Data.Migrations
{
    public partial class ProductListAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryId1",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductCategoryId1",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId1",
                table: "Product");

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Created", "Description", "ProductId", "Title" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruit is the fleshy or dry ripened ovary of a flowering plant, enclosing the seed or seeds", 0, "Fruit" });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Created", "Description", "ProductId", "Title" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A vegetable is the edible portion of a plant. Vegetables are usually grouped according to the portion of the plant that is eaten.", 0, "Vegetable " });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Created", "Description", "ProductId", "Title" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Most extremly rare. These kind's of eatable fruit and plants come from far far away... We can't know for sure if you are gonna survive after eating", 0, "Alien Fruit & Vegetables" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Created", "Description", "Price", "ProductCategoryId", "ProductImgUrl", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apples are the ideal fruit to eat at any time, having a positive role in the achievement of nourish balance.", 5m, 1, "https://i.pinimg.com/originals/ea/a0/cb/eaa0cbbe14fe8e03cbf6028cea3b3854.jpg", 19m, "Apple" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A peach is a soft, round, slightly furry fruit with sweet yellow flesh and pinky-orange skin.", 10m, 1, "https://producemadesimple.ca/wp-content/uploads/2015/08/peaches-chef-d-1-200x300.jpg", 10m, "Peach" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ripe cherries are deep red and exquisitely sweet, with small inedible pits.", 2m, 1, "https://b.rgbimg.com/users/w/wo/woodsy/300/mgQLSmw.jpg", 100m, "Cherry" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watermelon boasts a triad of flavors—bitter, sweet, and sour.", 4m, 1, "https://www.foodiesfeed.com/wp-content/uploads/2019/02/fresh-watermelon-close-up-200x300.jpg", 50m, "Watermelon" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The strawberry is a succulent and fragrant fruit of bright red colour, obtained from the plant with the same name.", 20m, 1, "https://i.pinimg.com/236x/b5/d0/cc/b5d0cce882fa0c4be7678e903c3b71e9--everbearing-strawberries-strawberry-plants.jpg", 200m, "Strawberries" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Among common varieties root shapes range from globular to long, with lower ends blunt to pointed.", 2m, 2, "https://uk.hazera.com/wp-content/uploads/sites/16/2022/04/SUBITO-VN150230c-HD-200x300.jpg", 80m, "Carrot" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spinach is a herbaceous plant whose leaves, green and arranged in rosette, are eaten raw or cooked.", 8m, 2, "https://www.canna-uk.com/sites/default/files/images/articles/default/articles-spinach-growityourself_text_3.jpg", 80m, "Spinach" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An onion is a round vegetable with a brown skin that grows underground.", 14m, 2, "https://i.pinimg.com/236x/3d/79/95/3d7995c6d987320d255fd4984cd54274--growing-onions-growing-vegetables.jpg", 50m, "Onion" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A vegetable with large light green or purple leaves formed into a tight head and a short thick stem.", 3m, 2, "https://feelgoodfoodie.net/wp-content/uploads/2020/04/how-to-cut-cabbage-12-200x300.jpg", 40m, "Cabbage" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "They can be cooked in many different ways, including boiling, frying, and baking.", 2m, 2, "https://i.pinimg.com/236x/65/f0/f1/65f0f1b477111727a1b320358d82638c--bean-varieties-poultry.jpg", 500m, "Beans" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extremely dangeour, fruit have red blood color and can squirt you to death.", 100m, 3, "https://i.pinimg.com/originals/6c/e8/50/6ce85072cd4b7e62d3904eec258b3aae.jpg", 20m, "Mibola" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berrys as black as the void. Can literally suck out your eye color if u look at it, but its tasty", 150m, 3, "https://thumbs.dreamstime.com/b/fruit-another-planet-unusual-red-sweet-fruit-fruit-another-planet-unusual-red-sweet-fruit-pink-inside-119018378.jpg", 50m, "Abyss Berry" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grown by the Klinorian people.As soon as the plant grow to 20cm it starts shooting chemicals at whomever comes close.", 200m, 3, "https://i.pinimg.com/736x/b4/29/e7/b429e708c40a1fa66109bc092419cf10--art-in-nature-passion-flower.jpg", 55m, "Uriac" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grown near black holes. The extreme gravity gives this fruit te tasty juice being buy it for.", 400m, 3, "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/345237f3-7d6b-418e-81b6-09202746aea0/d864ut1-39a83796-c716-4cfd-9098-4fc68682b664.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzM0NTIzN2YzLTdkNmItNDE4ZS04MWI2LTA5MjAyNzQ2YWVhMFwvZDg2NHV0MS0zOWE4Mzc5Ni1jNzE2LTRjZmQtOTA5OC00ZmM2ODY4MmI2NjQuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.uSzOcMsG71KI3fq7FwLfX84CRZ_vtqUJrO0Hp2EE7Tg", 120m, "Dessert Mangosteen" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The most rare vegetable in the galaxy. Is grown on magnetars and the legend is that this fruit will give you wings", 800m, 3, "https://c8.alamy.com/comp/J1KGNH/3d-rendering-of-a-science-fiction-alien-plant-isolated-on-white-background-J1KGNH.jpg", 10m, "Ummeape" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId1",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId1",
                table: "Product",
                column: "ProductCategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryId1",
                table: "Product",
                column: "ProductCategoryId1",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
