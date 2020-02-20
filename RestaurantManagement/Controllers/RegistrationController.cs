using RestaurantManagementEntity;
using RestaurantManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantManagement.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
     
        public ActionResult Create_Post()
        {
            CustomerEntity customer = new CustomerEntity();
            UpdateModel(customer);
            CustomerRepository.Add(customer);
            TempData["Message"] = "Added Succesfully";
            return RedirectToAction("Index");

        }
    }
}