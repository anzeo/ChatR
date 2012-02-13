using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using SignalR;

namespace SignalResearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome!";

            return View();
        }

        public ActionResult Stream()
        {
            ViewBag.Message = "Streaming dates";

            return View();
        }
    }
}
