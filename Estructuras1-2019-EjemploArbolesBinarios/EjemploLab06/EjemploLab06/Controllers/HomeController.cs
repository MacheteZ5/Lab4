using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArbolBinario; 

namespace EjemploLab06.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Nodo medicamento = new Nodo(); 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}