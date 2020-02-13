using RestaurantManagementEntity;
using RestaurantManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantManagement.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            IEnumerable<RestaurantEntity> RestaurantDetails = RestaurantRepository.Restaurants();
            return View("ModelView",RestaurantDetails);
        }
        public ActionResult DataPassing()
        {
            IEnumerable<RestaurantEntity> RestaurantDetails = RestaurantRepository.Restaurants();
            ViewBag.restaurants = RestaurantDetails;
            ViewData["Restaurants"] = RestaurantDetails;
            TempData["Restaurants"] = RestaurantDetails;
            return View();
        }
    }
}