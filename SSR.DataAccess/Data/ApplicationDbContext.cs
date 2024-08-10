using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSR.Models.Models;

namespace SSR.DataAccess.Data
{


    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<MenuItems> Menu { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //If using IdentityDbContext from .Net Entity Framework, this code is required.

            modelBuilder.Entity<MenuItems>().HasData(
                new MenuItems { Id = 1, Name = "Breakfast", DisplayOrder = 1 },
                new MenuItems { Id = 2, Name = "Lunch", DisplayOrder = 2 },
                new MenuItems { Id = 3, Name = "Dinner", DisplayOrder = 3 },
                new MenuItems { Id = 4, Name = "Beverages", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Dish>().HasData(
                //Breakfast Items
                new Dish
                {
                    Id = 1,
                    Name = "Idli",
                    Description = "Idli which is a soft, pillowy steamed savory cake made from fermented rice and lentil batter, served with spicy tomato chutney.",
                    Price = 4.99,
                    MenuId = 1,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 2,
                    Name = "Masala Dosa",
                    Description = "The classic Masala dosa recipe makes perfectly light, soft and crispy crepes stuffed with a savory, wonderfully spiced potato and onion filling.",
                    Price = 5.49,
                    MenuId = 1,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 3,
                    Name = "Appam",
                    Description = "Appam (also known as “palappam”) are tasty, lacy and fluffy pancakes or hoppers from the Kerala cuisine that are made from ground, fermented rice and coconut batter, served with coconut milk veg stew.",
                    Price = 3.99,
                    MenuId = 1,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 4,
                    Name = "Chapati Roll",
                    Description = "Delicious wraps or rolls stuffed with a spiced mix chicken stuffing. These kathi rolls make for a good brunch, lunch or tiffin box snack or a portable meal on the go!",
                    Price = 5.99,
                    MenuId = 1,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 5,
                    Name = "Samosa",
                    Description = "They feature a pastry-like crust but are filled with savory and spiced potato and green peas for a hearty, delicious breakfast.",
                    Price = 5.49,
                    MenuId = 1,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 6,
                    Name = "Bread Omelette",
                    Description = "Combining the goodness of the omelette and the versatility of the  bread, this dish can be considered a complete meal by itself.",
                    Price = 3.99,
                    MenuId = 1,
                    ImageUrl = ""
                },

                //Lunch Items
                new Dish
                {
                    Id = 7,
                    Name = "Non-Veg Meal",
                    Description = "Hot rice served with spicy chicken curry alongside 2 pieces of rotis sided with channa masala.",
                    Price = 8.99,
                    MenuId = 2,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 8,
                    Name = "Chicken Biryani",
                    Description = "An aromatic chicken and rice dish flavoured with a combination of spices and herbs, yoghurt, peas and shallots.",
                    Price = 8.49,
                    MenuId = 2,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 9,
                    Name = "Prawn Fried Rice",
                    Description = "The Prawn Fried Rice is here to treat your taste buds to some tasty prawns and a blend of spices.",
                    Price = 7.99,
                    MenuId = 2,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 10,
                    Name = "Curd Rice",
                    Description = "Nothing beats a soothing curd rice. Have a bowl of our yummy curd rice and your tummy will thank you later.",
                    Price = 5.99,
                    MenuId = 2,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 11,
                    Name = "Fish Curry",
                    Description = "A spicy and tasty fish curry that goes well with a roti or a bowl of white rice. Time to feast!",
                    Price = 5.49,
                    MenuId = 2,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 12,
                    Name = "Veg Meal",
                    Description = "Hot rice served with spicy veg curry alongside 2 pieces of rotis sided with channa masala.",
                    Price = 6.99,
                    MenuId = 2,
                    ImageUrl = ""
                },

                //Dinner Items
                new Dish
                {
                    Id = 13,
                    Name = "Beef Frankie",
                    Description = "Beef Frankies or beef wraps are delicious and irresistible. Beef cubes cooked in spices and placed in a wrap along with onion, tomatoes and green chutney.",
                    Price = 4.99,
                    MenuId = 3,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 14,
                    Name = "Chilli Parotta",
                    Description = "Chilli parotta is made by deep frying the parotta (or roughly torn) and then tossing it in usual Indo-Chinese base.",
                    Price = 5.49,
                    MenuId = 3,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 15,
                    Name = "Chicken Noodles",
                    Description = "A tasty one-pan stir-fry sizzler that's packed with flavour and good for you, too.",
                    Price = 7.49,
                    MenuId = 3,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 16,
                    Name = "Chicken Kothu",
                    Description = "Chicken Kothu Parotta is a popular street food in South-India. It is made with parotta, a soft, crispy, and layered flat bread, and a spicy chicken curry.",
                    Price = 7.99,
                    MenuId = 3,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 17,
                    Name = "Tandoori Chicken",
                    Description = "Tandoori chicken is a dish made from chicken marinated in yogurt and spices and roasted in a tandoor, a cylindrical clay oven.",
                    Price = 8.49,
                    MenuId = 3,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 18,
                    Name = "Sweet & Spicy Chicken",
                    Description = "This sticky chicken recipe turns out spicy, sweet, and tastes delicious. It's great as an appetizer or as a main dish served with rice and a veggie.",
                    Price = 6.99,
                    MenuId = 3,
                    ImageUrl = ""
                },

                //Beverages
                new Dish
                {
                    Id = 19,
                    Name = "Coke",
                    Description = "300ml of coca-cola.",
                    Price = 2.99,
                    MenuId = 4,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 20,
                    Name = "Lemon Mojito",
                    Description = "This enticing cocktail is a refreshing start to any meal. It's a wonderful blend of sweet and sour flavours, highlighted by mint and rum.",
                    Price = 2.99,
                    MenuId = 4,
                    ImageUrl = ""
                },
                new Dish
                {
                    Id = 21,
                    Name = "Mint Mojito",
                    Description = "Cool off with this easy mojito! Made with rum, lime juice, simple syrup, and fresh mint, this refreshing Cuban cocktail is perfect for summer.",
                    Price = 2.99,
                    MenuId = 4,
                    ImageUrl = ""
                }
         
            );
        }
    }
    
}
