using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;
using Seminar_Oblak.Models.Binding;

namespace Seminar_Oblak.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<FileStorage> FileStorage { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region category
            builder.Entity<ProductCategory>().HasData(
               new ProductCategory
               {
                   Id = 1,
                   Title = "Fruit",
                   Description = "Fruit is the fleshy or dry ripened ovary of a flowering plant, enclosing the seed or seeds"
               },
               new ProductCategory
               {
                   Id = 2,
                   Title = "Vegetable ",
                   Description = "A vegetable is the edible portion of a plant. Vegetables are usually grouped according to the portion of the plant that is eaten."
               },
               new ProductCategory
               {
                   Id = 3,
                   Title = "Alien Fruit & Vegetables",
                   Description = "Most extremly rare. These kind's of eatable fruit and plants come from far far away... We can't know for sure if you are gonna survive after eating"
               });
            #endregion
            #region product
            builder.Entity<Product>().HasData
           (
               new Product
               {
                   Id = 1,
                   Title = "Apple",
                   Description = "Apples are the ideal fruit to eat at any time, having a positive role in the achievement of nourish balance.",
                   ProductCategoryId = 1,
                   Quantity = 19,
                   Price = 5,
                   ProductImgUrl = "https://i.pinimg.com/originals/ea/a0/cb/eaa0cbbe14fe8e03cbf6028cea3b3854.jpg"
               },
               new Product
               {
                   Id = 2,
                   Title = "Peach",
                   Description = "A peach is a soft, round, slightly furry fruit with sweet yellow flesh and pinky-orange skin.",
                   ProductCategoryId = 1,
                   Quantity = 10,
                   Price = 10,
                   ProductImgUrl = "https://producemadesimple.ca/wp-content/uploads/2015/08/peaches-chef-d-1-200x300.jpg"
               },
               new Product
               {
                   Id = 3,
                   Title = "Cherry",
                   Description = "Ripe cherries are deep red and exquisitely sweet, with small inedible pits.",
                   ProductCategoryId = 1,
                   Quantity = 100,
                   Price = 2,
                   ProductImgUrl = "https://b.rgbimg.com/users/w/wo/woodsy/300/mgQLSmw.jpg"
               },
               new Product
               {
                   Id = 4,
                   Title = "Watermelon",
                   Description = "Watermelon boasts a triad of flavors—bitter, sweet, and sour.",
                   ProductCategoryId = 1,
                   Quantity = 50,
                   Price = 4,
                   ProductImgUrl = "https://www.foodiesfeed.com/wp-content/uploads/2019/02/fresh-watermelon-close-up-200x300.jpg"
               },
               new Product
               {
                   Id = 5,
                   Title = "Strawberries",
                   Description = "The strawberry is a succulent and fragrant fruit of bright red colour, obtained from the plant with the same name.",
                   ProductCategoryId = 1,
                   Quantity = 200,
                   Price = 20,
                   ProductImgUrl = "https://i.pinimg.com/236x/b5/d0/cc/b5d0cce882fa0c4be7678e903c3b71e9--everbearing-strawberries-strawberry-plants.jpg"
               },
               new Product
               {
                   Id = 6,
                   Title = "Carrot",
                   Description = "Among common varieties root shapes range from globular to long, with lower ends blunt to pointed.",
                   ProductCategoryId = 2,
                   Quantity = 80,
                   Price = 2,
                   ProductImgUrl = "https://uk.hazera.com/wp-content/uploads/sites/16/2022/04/SUBITO-VN150230c-HD-200x300.jpg"
               },
               new Product
               {
                   Id = 7,
                   Title = "Spinach",
                   Description = "Spinach is a herbaceous plant whose leaves, green and arranged in rosette, are eaten raw or cooked.",
                   ProductCategoryId = 2,
                   Quantity = 80,
                   Price = 8,
                   ProductImgUrl = "https://www.canna-uk.com/sites/default/files/images/articles/default/articles-spinach-growityourself_text_3.jpg"
               },
               new Product
               {
                   Id = 8,
                   Title = "Onion",
                   Description = "An onion is a round vegetable with a brown skin that grows underground.",
                   ProductCategoryId = 2,
                   Quantity = 50,
                   Price = 14,
                   ProductImgUrl = "https://i.pinimg.com/236x/3d/79/95/3d7995c6d987320d255fd4984cd54274--growing-onions-growing-vegetables.jpg"
               },
               new Product
               {
                   Id = 9,
                   Title = "Cabbage",
                   Description = "A vegetable with large light green or purple leaves formed into a tight head and a short thick stem.",
                   ProductCategoryId = 2,
                   Quantity = 40,
                   Price = 3,
                   ProductImgUrl = "https://feelgoodfoodie.net/wp-content/uploads/2020/04/how-to-cut-cabbage-12-200x300.jpg"
               },
               new Product
               {
                   Id = 10,
                   Title = "Beans",
                   Description = "They can be cooked in many different ways, including boiling, frying, and baking.",
                   ProductCategoryId = 2,
                   Quantity = 500,
                   Price = 2,
                   ProductImgUrl = "https://i.pinimg.com/236x/65/f0/f1/65f0f1b477111727a1b320358d82638c--bean-varieties-poultry.jpg"
               },
               new Product
               {
                   Id = 11,
                   Title = "Mibola",
                   Description = "Extremely dangeour, fruit have red blood color and can squirt you to death.",
                   ProductCategoryId = 3,
                   Quantity = 20,
                   Price = 100,
                   ProductImgUrl = "https://i.pinimg.com/originals/6c/e8/50/6ce85072cd4b7e62d3904eec258b3aae.jpg"
               },
               new Product
               {
                   Id = 12,
                   Title = "Abyss Berry",
                   Description = "Berrys as black as the void. Can literally suck out your eye color if u look at it, but its tasty",
                   ProductCategoryId = 3,
                   Quantity = 50,
                   Price = 150,
                   ProductImgUrl = "https://thumbs.dreamstime.com/b/fruit-another-planet-unusual-red-sweet-fruit-fruit-another-planet-unusual-red-sweet-fruit-pink-inside-119018378.jpg"
               },
               new Product
               {
                   Id = 13,
                   Title = "Uriac",
                   Description = "Grown by the Klinorian people.As soon as the plant grow to 20cm it starts shooting chemicals at whomever comes close.",
                   ProductCategoryId = 3,
                   Quantity = 55,
                   Price = 200,
                   ProductImgUrl = "https://i.pinimg.com/736x/b4/29/e7/b429e708c40a1fa66109bc092419cf10--art-in-nature-passion-flower.jpg"
               },
               new Product
               {
                   Id = 14,
                   Title = "Dessert Mangosteen",
                   Description = "Grown near black holes. The extreme gravity gives this fruit te tasty juice being buy it for.",
                   ProductCategoryId = 3,
                   Quantity = 120,
                   Price = 400,
                   ProductImgUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/345237f3-7d6b-418e-81b6-09202746aea0/d864ut1-39a83796-c716-4cfd-9098-4fc68682b664.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzM0NTIzN2YzLTdkNmItNDE4ZS04MWI2LTA5MjAyNzQ2YWVhMFwvZDg2NHV0MS0zOWE4Mzc5Ni1jNzE2LTRjZmQtOTA5OC00ZmM2ODY4MmI2NjQuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.uSzOcMsG71KI3fq7FwLfX84CRZ_vtqUJrO0Hp2EE7Tg"
               },
               new Product
               {
                   Id = 15,
                   Title = "Ummeape",
                   Description = "The most rare vegetable in the galaxy. Is grown on magnetars and the legend is that this fruit will give you wings",
                   ProductCategoryId = 3,
                   Quantity = 10,
                   Price = 800,
                   ProductImgUrl = "https://c8.alamy.com/comp/J1KGNH/3d-rendering-of-a-science-fiction-alien-plant-isolated-on-white-background-J1KGNH.jpg"
               });
            #endregion
        }

    }

    }