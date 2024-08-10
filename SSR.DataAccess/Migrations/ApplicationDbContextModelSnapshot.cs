﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSR.DataAccess.Data;

#nullable disable

namespace SSR.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SSR.Models.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Idli which is a soft, pillowy steamed savory cake made from fermented rice and lentil batter, served with spicy tomato chutney.",
                            ImageUrl = "",
                            MenuId = 1,
                            Name = "Idli",
                            Price = 4.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            Description = "The classic Masala dosa recipe makes perfectly light, soft and crispy crepes stuffed with a savory, wonderfully spiced potato and onion filling.",
                            ImageUrl = "",
                            MenuId = 1,
                            Name = "Masala Dosa",
                            Price = 5.4900000000000002
                        },
                        new
                        {
                            Id = 3,
                            Description = "Appam (also known as “palappam”) are tasty, lacy and fluffy pancakes or hoppers from the Kerala cuisine that are made from ground, fermented rice and coconut batter, served with coconut milk veg stew.",
                            ImageUrl = "",
                            MenuId = 1,
                            Name = "Appam",
                            Price = 3.9900000000000002
                        },
                        new
                        {
                            Id = 4,
                            Description = "Delicious wraps or rolls stuffed with a spiced mix chicken stuffing. These kathi rolls make for a good brunch, lunch or tiffin box snack or a portable meal on the go!",
                            ImageUrl = "",
                            MenuId = 1,
                            Name = "Chapati Roll",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            Id = 5,
                            Description = "They feature a pastry-like crust but are filled with savory and spiced potato and green peas for a hearty, delicious breakfast.",
                            ImageUrl = "",
                            MenuId = 1,
                            Name = "Samosa",
                            Price = 5.4900000000000002
                        },
                        new
                        {
                            Id = 6,
                            Description = "Combining the goodness of the omelette and the versatility of the  bread, this dish can be considered a complete meal by itself.",
                            ImageUrl = "",
                            MenuId = 1,
                            Name = "Bread Omelette",
                            Price = 3.9900000000000002
                        },
                        new
                        {
                            Id = 7,
                            Description = "Hot rice served with spicy chicken curry alongside 2 pieces of rotis sided with channa masala.",
                            ImageUrl = "",
                            MenuId = 2,
                            Name = "Non-Veg Meal",
                            Price = 8.9900000000000002
                        },
                        new
                        {
                            Id = 8,
                            Description = "An aromatic chicken and rice dish flavoured with a combination of spices and herbs, yoghurt, peas and shallots.",
                            ImageUrl = "",
                            MenuId = 2,
                            Name = "Chicken Biryani",
                            Price = 8.4900000000000002
                        },
                        new
                        {
                            Id = 9,
                            Description = "The Prawn Fried Rice is here to treat your taste buds to some tasty prawns and a blend of spices.",
                            ImageUrl = "",
                            MenuId = 2,
                            Name = "Prawn Fried Rice",
                            Price = 7.9900000000000002
                        },
                        new
                        {
                            Id = 10,
                            Description = "Nothing beats a soothing curd rice. Have a bowl of our yummy curd rice and your tummy will thank you later.",
                            ImageUrl = "",
                            MenuId = 2,
                            Name = "Curd Rice",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            Id = 11,
                            Description = "A spicy and tasty fish curry that goes well with a roti or a bowl of white rice. Time to feast!",
                            ImageUrl = "",
                            MenuId = 2,
                            Name = "Fish Curry",
                            Price = 5.4900000000000002
                        },
                        new
                        {
                            Id = 12,
                            Description = "Hot rice served with spicy veg curry alongside 2 pieces of rotis sided with channa masala.",
                            ImageUrl = "",
                            MenuId = 2,
                            Name = "Veg Meal",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            Id = 13,
                            Description = "Beef Frankies or beef wraps are delicious and irresistible. Beef cubes cooked in spices and placed in a wrap along with onion, tomatoes and green chutney.",
                            ImageUrl = "",
                            MenuId = 3,
                            Name = "Beef Frankie",
                            Price = 4.9900000000000002
                        },
                        new
                        {
                            Id = 14,
                            Description = "Chilli parotta is made by deep frying the parotta (or roughly torn) and then tossing it in usual Indo-Chinese base.",
                            ImageUrl = "",
                            MenuId = 3,
                            Name = "Chilli Parotta",
                            Price = 5.4900000000000002
                        },
                        new
                        {
                            Id = 15,
                            Description = "A tasty one-pan stir-fry sizzler that's packed with flavour and good for you, too.",
                            ImageUrl = "",
                            MenuId = 3,
                            Name = "Chicken Noodles",
                            Price = 7.4900000000000002
                        },
                        new
                        {
                            Id = 16,
                            Description = "Chicken Kothu Parotta is a popular street food in South-India. It is made with parotta, a soft, crispy, and layered flat bread, and a spicy chicken curry.",
                            ImageUrl = "",
                            MenuId = 3,
                            Name = "Chicken Kothu",
                            Price = 7.9900000000000002
                        },
                        new
                        {
                            Id = 17,
                            Description = "Tandoori chicken is a dish made from chicken marinated in yogurt and spices and roasted in a tandoor, a cylindrical clay oven.",
                            ImageUrl = "",
                            MenuId = 3,
                            Name = "Tandoori Chicken",
                            Price = 8.4900000000000002
                        },
                        new
                        {
                            Id = 18,
                            Description = "This sticky chicken recipe turns out spicy, sweet, and tastes delicious. It's great as an appetizer or as a main dish served with rice and a veggie.",
                            ImageUrl = "",
                            MenuId = 3,
                            Name = "Sweet & Spicy Chicken",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            Id = 19,
                            Description = "300ml of coca-cola.",
                            ImageUrl = "",
                            MenuId = 4,
                            Name = "Coke",
                            Price = 2.9900000000000002
                        },
                        new
                        {
                            Id = 20,
                            Description = "This enticing cocktail is a refreshing start to any meal. It's a wonderful blend of sweet and sour flavours, highlighted by mint and rum.",
                            ImageUrl = "",
                            MenuId = 4,
                            Name = "Lemon Mojito",
                            Price = 2.9900000000000002
                        },
                        new
                        {
                            Id = 21,
                            Description = "Cool off with this easy mojito! Made with rum, lime juice, simple syrup, and fresh mint, this refreshing Cuban cocktail is perfect for summer.",
                            ImageUrl = "",
                            MenuId = 4,
                            Name = "Mint Mojito",
                            Price = 2.9900000000000002
                        });
                });

            modelBuilder.Entity("SSR.Models.Models.MenuItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Lunch"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Dinner"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Beverages"
                        });
                });

            modelBuilder.Entity("SSR.Models.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("OrderHeaderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("OrderHeaderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("SSR.Models.Models.OrderHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Carrier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("float");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentIntentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("OrderHeaders");
                });

            modelBuilder.Entity("SSR.Models.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("DishId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("SSR.Models.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSR.Models.Models.Dish", b =>
                {
                    b.HasOne("SSR.Models.Models.MenuItems", "MenuItems")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("SSR.Models.Models.OrderDetail", b =>
                {
                    b.HasOne("SSR.Models.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSR.Models.Models.OrderHeader", "OrderHeader")
                        .WithMany()
                        .HasForeignKey("OrderHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("OrderHeader");
                });

            modelBuilder.Entity("SSR.Models.Models.OrderHeader", b =>
                {
                    b.HasOne("SSR.Models.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("SSR.Models.Models.ShoppingCart", b =>
                {
                    b.HasOne("SSR.Models.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSR.Models.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Dish");
                });
#pragma warning restore 612, 618
        }
    }
}
