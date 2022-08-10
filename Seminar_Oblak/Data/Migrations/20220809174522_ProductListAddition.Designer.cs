﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seminar_Oblak.Data;

#nullable disable

namespace Seminar_Oblak.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220809174522_ProductListAddition")]
    partial class ProductListAddition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Seminar_Oblak.Models.Dbo.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Seminar_Oblak.Models.Dbo.FileStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DownloadUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FileStorage");
                });

            modelBuilder.Entity("Seminar_Oblak.Models.Dbo.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apples are the ideal fruit to eat at any time, having a positive role in the achievement of nourish balance.",
                            Price = 5m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://i.pinimg.com/originals/ea/a0/cb/eaa0cbbe14fe8e03cbf6028cea3b3854.jpg",
                            Quantity = 19m,
                            Title = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A peach is a soft, round, slightly furry fruit with sweet yellow flesh and pinky-orange skin.",
                            Price = 10m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://producemadesimple.ca/wp-content/uploads/2015/08/peaches-chef-d-1-200x300.jpg",
                            Quantity = 10m,
                            Title = "Peach"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ripe cherries are deep red and exquisitely sweet, with small inedible pits.",
                            Price = 2m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://b.rgbimg.com/users/w/wo/woodsy/300/mgQLSmw.jpg",
                            Quantity = 100m,
                            Title = "Cherry"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Watermelon boasts a triad of flavors—bitter, sweet, and sour.",
                            Price = 4m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://www.foodiesfeed.com/wp-content/uploads/2019/02/fresh-watermelon-close-up-200x300.jpg",
                            Quantity = 50m,
                            Title = "Watermelon"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The strawberry is a succulent and fragrant fruit of bright red colour, obtained from the plant with the same name.",
                            Price = 20m,
                            ProductCategoryId = 1,
                            ProductImgUrl = "https://i.pinimg.com/236x/b5/d0/cc/b5d0cce882fa0c4be7678e903c3b71e9--everbearing-strawberries-strawberry-plants.jpg",
                            Quantity = 200m,
                            Title = "Strawberries"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Among common varieties root shapes range from globular to long, with lower ends blunt to pointed.",
                            Price = 2m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://uk.hazera.com/wp-content/uploads/sites/16/2022/04/SUBITO-VN150230c-HD-200x300.jpg",
                            Quantity = 80m,
                            Title = "Carrot"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Spinach is a herbaceous plant whose leaves, green and arranged in rosette, are eaten raw or cooked.",
                            Price = 8m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://www.canna-uk.com/sites/default/files/images/articles/default/articles-spinach-growityourself_text_3.jpg",
                            Quantity = 80m,
                            Title = "Spinach"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An onion is a round vegetable with a brown skin that grows underground.",
                            Price = 14m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://i.pinimg.com/236x/3d/79/95/3d7995c6d987320d255fd4984cd54274--growing-onions-growing-vegetables.jpg",
                            Quantity = 50m,
                            Title = "Onion"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A vegetable with large light green or purple leaves formed into a tight head and a short thick stem.",
                            Price = 3m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://feelgoodfoodie.net/wp-content/uploads/2020/04/how-to-cut-cabbage-12-200x300.jpg",
                            Quantity = 40m,
                            Title = "Cabbage"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "They can be cooked in many different ways, including boiling, frying, and baking.",
                            Price = 2m,
                            ProductCategoryId = 2,
                            ProductImgUrl = "https://i.pinimg.com/236x/65/f0/f1/65f0f1b477111727a1b320358d82638c--bean-varieties-poultry.jpg",
                            Quantity = 500m,
                            Title = "Beans"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Extremely dangeour, fruit have red blood color and can squirt you to death.",
                            Price = 100m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://i.pinimg.com/originals/6c/e8/50/6ce85072cd4b7e62d3904eec258b3aae.jpg",
                            Quantity = 20m,
                            Title = "Mibola"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Berrys as black as the void. Can literally suck out your eye color if u look at it, but its tasty",
                            Price = 150m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://thumbs.dreamstime.com/b/fruit-another-planet-unusual-red-sweet-fruit-fruit-another-planet-unusual-red-sweet-fruit-pink-inside-119018378.jpg",
                            Quantity = 50m,
                            Title = "Abyss Berry"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grown by the Klinorian people.As soon as the plant grow to 20cm it starts shooting chemicals at whomever comes close.",
                            Price = 200m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://i.pinimg.com/736x/b4/29/e7/b429e708c40a1fa66109bc092419cf10--art-in-nature-passion-flower.jpg",
                            Quantity = 55m,
                            Title = "Uriac"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grown near black holes. The extreme gravity gives this fruit te tasty juice being buy it for.",
                            Price = 400m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/345237f3-7d6b-418e-81b6-09202746aea0/d864ut1-39a83796-c716-4cfd-9098-4fc68682b664.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzM0NTIzN2YzLTdkNmItNDE4ZS04MWI2LTA5MjAyNzQ2YWVhMFwvZDg2NHV0MS0zOWE4Mzc5Ni1jNzE2LTRjZmQtOTA5OC00ZmM2ODY4MmI2NjQuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.uSzOcMsG71KI3fq7FwLfX84CRZ_vtqUJrO0Hp2EE7Tg",
                            Quantity = 120m,
                            Title = "Dessert Mangosteen"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The most rare vegetable in the galaxy. Is grown on magnetars and the legend is that this fruit will give you wings",
                            Price = 800m,
                            ProductCategoryId = 3,
                            ProductImgUrl = "https://c8.alamy.com/comp/J1KGNH/3d-rendering-of-a-science-fiction-alien-plant-isolated-on-white-background-J1KGNH.jpg",
                            Quantity = 10m,
                            Title = "Ummeape"
                        });
                });

            modelBuilder.Entity("Seminar_Oblak.Models.Dbo.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fruit is the fleshy or dry ripened ovary of a flowering plant, enclosing the seed or seeds",
                            ProductId = 0,
                            Title = "Fruit"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A vegetable is the edible portion of a plant. Vegetables are usually grouped according to the portion of the plant that is eaten.",
                            ProductId = 0,
                            Title = "Vegetable "
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Most extremly rare. These kind's of eatable fruit and plants come from far far away... We can't know for sure if you are gonna survive after eating",
                            ProductId = 0,
                            Title = "Alien Fruit & Vegetables"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Seminar_Oblak.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Seminar_Oblak.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seminar_Oblak.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Seminar_Oblak.Models.Dbo.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seminar_Oblak.Models.Dbo.Product", b =>
                {
                    b.HasOne("Seminar_Oblak.Models.Dbo.ProductCategory", "ProductCategory")
                        .WithMany("Product")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("Seminar_Oblak.Models.Dbo.ProductCategory", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
