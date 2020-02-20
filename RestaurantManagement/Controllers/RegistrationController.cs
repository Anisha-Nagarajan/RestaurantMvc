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
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserEntity user)
        {
            if (ModelState.IsValid)
            {
                bool loginStatus = CustomerRepository.Login(user);
                if (loginStatus == true)
                {

                    return RedirectToAction("Index", "Restaurant");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
     
        public ActionResult Create(CustomerEntity customer)
        {
           
                CustomerRepository.Add(customer);
                TempData["Message"] = "Added Succesfully";
                return RedirectToAction("Login");
           

        }
       
    }
}