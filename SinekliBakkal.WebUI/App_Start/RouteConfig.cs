using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SinekliBakkal.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "ProductList",
               url: "products",
               defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
             name: "ProductAdd",
             url: "product/Add",
             defaults: new { controller = "Products", action = "Add", id = UrlParameter.Optional }
             );


            routes.MapRoute(
             name: "ProductDelete",
             url: "productDelete/{id}",
             defaults: new { controller = "Products", action = "Delete", id = UrlParameter.Optional }
         );

            routes.MapRoute(
               name: "ProductEdit",
               url: "productEdit/{id}",
               defaults: new { controller = "Products", action = "Edit", id = UrlParameter.Optional }
           );


            routes.MapRoute(
           name: "CategoryList",
           url: "categories",
           defaults: new { controller = "Categories", action = "Index", id = UrlParameter.Optional }
       );

            routes.MapRoute(
             name: "CategoryAdd",
             url: "category/Add",
             defaults: new { controller = "Categories", action = "Add", id = UrlParameter.Optional }
             );

            routes.MapRoute(
               name: "CategoryDelete",
               url: "categoryDelete/{id}",
               defaults: new { controller = "Categories", action = "Delete", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "CategoryEdit",
               url: "categoryEdit/{id}",
               defaults: new { controller = "Categories", action = "Edit", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
