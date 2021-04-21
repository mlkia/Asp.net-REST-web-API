using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DemoWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes //Attribute-based routing
            config.MapHttpAttributeRoutes();


            // Convention-based routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // My own route--Mitt eget route
            // The link will be for example: http://www.mybook.com/api/posts/archive/2019/03/21
            // or: http://www.mybook.com/api/posts/archive/2019/03
            // or: http://www.mybook.com/api/posts/archive/2019
            config.Routes.MapHttpRoute(
                name: "myRoute",
                routeTemplate: "api/{controller}/{action}/{year}/{month}/{day}",
                defaults: new { 
                    month = RouteParameter.Optional,
                    day = RouteParameter.Optional
                },
                constraints: new
                {
                    month=@"\d{0,2}", day=@"\d{0,2}"
                }
                ) ;
        }
    }
}
