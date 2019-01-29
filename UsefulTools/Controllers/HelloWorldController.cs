﻿using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Recipe newRecipe)
        {
            // ...

            return View();
        }
    }

    public class Recipe
    {
        public string name { get; set; }
    }
}