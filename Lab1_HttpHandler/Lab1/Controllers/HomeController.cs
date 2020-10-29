using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Lab1.Models;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                var url = "http://localhost:5000/service.pyb";
                var responseTask = client.GetAsync(url);
                responseTask.Wait();

                var response = responseTask.Result;

                if (response.IsSuccessStatusCode)
                {
                    ViewData["result"] = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    ViewData["result"] = "Error";
                }
            }
            return View("Index");
        }

        [HttpPost]
        public async Task<ActionResult> AddResult(ServiceValues serviceValues, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                     var url = $"http://localhost:5000/service.pyb?result={serviceValues.Result}";
                    // var responseTask = client.PostAsync(url, null);
                    var request = new HttpRequestMessage(HttpMethod.Post, url);
                    var response = await client
                        .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPut]
        public async Task<ActionResult> PutResult(ServiceValues serviceValues, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    var url = $"http://localhost:5000/service.pyb?add={serviceValues.Add}";
                    // var responseTask = client.PostAsync(url, null);
                    var request = new HttpRequestMessage(HttpMethod.Put, url);
                    var response = await client
                        .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                }
            }
            return RedirectToAction("Index");
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