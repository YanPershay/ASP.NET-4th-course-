using Lab3_Hateoas.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab3_Hateoas.Controllers
{
    public class HomeController : Controller
    {

        StudentContext _context;
        string localhost = "https://localhost:44306";
        public HomeController()
        {
            _context = new StudentContext();
        }
        public ActionResult Index()
        {
            var s = _context.Students.ToList();
            return View(s);
        }

        //[HttpGet]
        //public async Task<ActionResult> GetStudent()
        //{
        //    HttpClient client = new HttpClient();
        //    var uri = new Uri("https://localhost:44306/api/Students/1");
        //    var response = await client.GetAsync(uri);

        //    response.EnsureSuccessStatusCode();
        //    string str = await response.Content.ReadAsStringAsync();
        //    //var str = responseTask.Result.Content.ReadAsStringAsync().ToString();
        //    TempData["res"] = str;

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public async Task<ActionResult> AddStudent(FormCollection form, CancellationToken cancellationToken)
        {
            Student student = new Student();
            student.Name = form["name"];
            student.Phone = form["phone"];

            HttpClient client = new HttpClient();
            using (var request = new HttpRequestMessage(HttpMethod.Post, $"{localhost}/api/Students"))
            {
                var json = JsonConvert.SerializeObject(student);
                using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    request.Content = stringContent;

                    using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false))
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        TempData["res"] = responseString;
                    }
                }
            }
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> GetStudent(int id)
        {
            var url = $"{localhost}/api/Students/{id}";

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            string str = await response.Content.ReadAsStringAsync();
            TempData["res"] = str;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> GetStudent(FormCollection form)
        {
            var builder = new UriBuilder($"{localhost}/api/Students");
            
            var query = HttpUtility.ParseQueryString(builder.Query);

            string val;
            foreach(var key in form.AllKeys)
            {
                if(form[key] != "")
                {
                    val = form[key];
                    query[key] = form[key];
                }
            }
            builder.Query = query.ToString();
            string url = builder.ToString();

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            string str = await response.Content.ReadAsStringAsync();
            TempData["res"] = str;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            var student = _context.Students.Single(s => s.Id == id);
            return View(student);
        }

        [HttpPost]
        public ActionResult EditStudent(Student student)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{localhost}/api/Students");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<Student>("", student);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    TempData["res"] = result.Content.ReadAsStringAsync().Result;
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Single(s => s.Id == id);
            return View(student);
        }

        [HttpPost]
        public ActionResult DeleteStudent(Student student)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{localhost}/api/Students/");

                //HTTP POST
                var deleteTask = client.DeleteAsync($"{student.Id}");
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    TempData["res"] = result.Content.ReadAsStringAsync().Result;
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
