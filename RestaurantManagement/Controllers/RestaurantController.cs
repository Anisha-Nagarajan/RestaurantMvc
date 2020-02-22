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
            return RedirectToAction("TempDataCheck");
        }
        public ActionResult TempDataCheck()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            RestaurantEntity restaurant = new RestaurantEntity();
            UpdateModel(restaurant);

            RestaurantRepository.Add(restaurant);
            TempData["Message"] = "Added Succesfully";
            return RedirectToAction("Index");
        
        }
        public ActionResult Edit([Bind(Exclude = "Description")]RestaurantEntity res)
        {
            RestaurantEntity restaurant = RestaurantRepository.GetRestaurantById(res.Id);
            return View(restaurant);
        }
    
        [HttpPost]
        public ActionResult Update(RestaurantEntity restaurant)
        {
            RestaurantRepository.Update(restaurant);
            TempData["Message"] = "Updated Succesfully";
            return RedirectToAction("Index");
           
        }
        public ActionResult Delete(int id)
        {
            RestaurantRepository.Delete(id);
            TempData["Message"] = "Deleted Succesfully";
            return RedirectToAction("Index");
        }
    }
}