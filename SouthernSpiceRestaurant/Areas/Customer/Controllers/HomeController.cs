using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SSR.DataAccess.Repository;
using SSR.DataAccess.Repository.IRepository;
using SSR.Models.Models;
using SSR.Utility;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace SouthernSpiceRestaurant.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                HttpContext.Session.SetInt32(SD.SessionCart,
                    _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value).Count());
            }

            IEnumerable<Dish> dishList = _unitOfWork.Dish.GetAll(includeDishes: "MenuItems");
            return View(dishList);
        }

        public IActionResult DishDetails(int dishId)
        {
            ShoppingCart cart = new()
            {
                Dish = _unitOfWork.Dish.Get(u => u.Id == dishId, includeDishes: "MenuItems"),
                Count = 1,
                DishId = dishId
            };
            
            return View(cart);
        }

        [HttpPost]
        [Authorize]
        public IActionResult DishDetails(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value; //Getting UserId when the user logs in from the Dish Details page through built in ClaimsIdentity method.
            shoppingCart.ApplicationUserId = userId;

            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.ApplicationUserId == userId &&
                u.DishId == shoppingCart.DishId);

            if (cartFromDb != null)
            {
                //shopping cart already exists
                cartFromDb.Count += shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                //add new cart record 
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart,
                    _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
            }
            TempData["success"] = "Cart updated sucessfully.";

            return RedirectToAction(nameof(Index));
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
