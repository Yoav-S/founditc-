using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace founditapp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            string message = "Success from UserController!";
            return (IHttpActionResult)Content(message);
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
