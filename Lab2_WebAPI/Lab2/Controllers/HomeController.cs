using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Lab2.Models;

namespace Lab2.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        JavaScriptSerializer _js = new JavaScriptSerializer();
        [HttpGet]
        public ActionResult Index()
        {
            //ViewBag.ResultValue = _js.Serialize(new {result = Result.result});

            return View();
        }
    }
}
