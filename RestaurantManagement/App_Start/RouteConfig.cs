﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RestaurantManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                  name: "RegisterRouting",
                  url: "{controller}/{action}/{id}",
                  defaults: new { controller = "Registration", action = "Create", id = UrlParameter.Optional }
                  );
            routes.MapRoute(
                name: "RestaurantDataPassing",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Restaurant", action = "DataPassing", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "RestaurantModel",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Restaurant", action = "ModelView", id = UrlParameter.Optional }
           );
            routes.MapRoute(
            name: "NewRestaurant",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Restaurant", action = "Create", id = UrlParameter.Optional }
        );
        }
    }
}
