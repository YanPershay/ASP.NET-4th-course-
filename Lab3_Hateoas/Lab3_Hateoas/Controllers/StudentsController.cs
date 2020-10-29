using Lab3_Hateoas.Models;
using Microsoft.Identity.Client;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Xml.Serialization;

namespace Lab3_Hateoas.Controllers
{
    public class StudentsController : ApiController
    {

        StudentContext _context = new StudentContext();
        string localhost = "https://localhost:44306";
        
        [HttpGet]
        public object GetStudents([FromUri] string[] parameters)
        {
            var students = _context.Students.ToList();
            var studentsList = students;

            var requestParams = Request.GetQueryNameValuePairs();

            var limit = requestParams.Where(p => p.Key.Equals("limit")).ToList();
            var sort = requestParams.Where(p => p.Key.Equals("sort")).ToList();
            var offset = requestParams.Where(p => p.Key.Equals("offset")).ToList();
            var minid = requestParams.Where(p => p.Key.Equals("minid")).ToList();
            var maxid = requestParams.Where(p => p.Key.Equals("maxid")).ToList();
            var like = requestParams.Where(p => p.Key.Equals("like")).ToList();
            var columns = requestParams.Where(p => p.Key.Equals("columns")).ToList();
            var globalike = requestParams.Where(p => p.Key.Equals("globalike")).ToList();
            var xml = requestParams.Where(p => p.Key.Equals("xml")).ToList();
            
            var resultList = studentsList;

            if (limit.Count == 1 || offset.Count == 1)
            {
                if(limit.Count == 1 && offset.Count == 1)
                {
                    resultList = students.Skip(int.Parse(offset[0].Value)).Take(int.Parse(limit[0].Value)).ToList();
                } 
                else if(limit.Count == 1 && offset.Count < 1)
                {
                    resultList = students.Take(int.Parse(limit[0].Value)).ToList();
                }
                else if (offset.Count== 1 && limit.Count  < 1)
                {
                    resultList = students.Skip(int.Parse(offset[0].Value)).ToList();
                }
              
            }

            if(sort.Count == 1)
            {
                resultList = resultList.OrderBy(s => s.Name).ToList();
            }

            if(minid.Count == 1)
            {
                int min = int.Parse(minid[0].Value);
                resultList = resultList.Where(s => s.Id >= min).ToList();
            }

            if(maxid.Count == 1)
            {
                int max = int.Parse(maxid[0].Value);
                resultList = resultList.Where(s => s.Id <= max).ToList();
            }

            if(like.Count == 1)
            {
                string name = like[0].Value;
                resultList = resultList.Where(s => s.Name.Equals(name)).ToList();
            }

            var studentApi = new List<StudentApi>();

            foreach(var student in resultList)
            {
                studentApi.Add(new StudentApi(student, new Hateoas($"{localhost}/api/Students/" + student.Id, student.Id.ToString(), "GET")));
            }

            if (globalike.Count() == 1)
            {
                string columnValue = globalike[0].Value; 
                
                bool isNumeric = int.TryParse(columnValue, out _);

                if (isNumeric)
                {
                    studentApi = studentApi.Where(s => s.Id.ToString().Contains(int.Parse(columnValue).ToString()) || s.Name.Contains(columnValue) || s.Phone.Contains(columnValue)).ToList();
                }
                else
                {
                    studentApi = studentApi.Where(s => s.Name.Contains(columnValue) || s.Phone.Contains(columnValue)).ToList();
                }
                
            }

            if (columns.Count() == 1)
            {
                string columnValue = columns[0].Value;
                string[] arr = columnValue.Split(",".ToCharArray());
                bool id = false, name = false, phone = false;

                foreach (string val in arr)
                {
                    if (val == "id")
                        id = true;

                    if (val == "name")
                        name = true;

                    if (val == "phone")
                        phone = true;
                }

                if (!id)
                {
                    foreach(var field in studentApi)
                    {
                        field.Id = 0;
                    }
                }
                if (!name)
                {
                    foreach (var field in studentApi)
                    {
                        field.Name = "";
                    }
                }
                if (!phone)
                {
                    foreach (var field in studentApi)
                    {
                        field.Phone = "";
                    }
                }
            } 

            //var jsonSerialiser = new JavaScriptSerializer();
            string resultHateoasString;

            if (xml.Count == 1)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<StudentApi>));

                var stringwriter = new System.IO.StringWriter();
                serializer.Serialize(stringwriter, studentApi);
                resultHateoasString = stringwriter.ToString();
                return Ok(resultHateoasString);
            }
            else
            {
                return Ok(studentApi);
            }

            //return Ok(resultHateoasString);
        }

        [HttpGet]
        [ResponseType(typeof(Student))]
        public object GetStudent(int id)
        {
            Student student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return Content(HttpStatusCode.NotFound, new Hateoas($"{localhost}/api/Errors/404", "error.404", "GET"));

            return Ok(new StudentApi(student, new Hateoas($"{localhost}/api/Students/" + id, "self", "GET")));
        }

        [HttpPost]
        [ResponseType(typeof(Student))]
        public object AddStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, new { ModelState, hateoas = new Hateoas($"{localhost}/api/Errors/400", "error.400", "POST") });
            }

            _context.Students.Add(student);
            _context.SaveChanges();
            student.Id = _context.Students.ToList().OrderByDescending(s => s.Id).First().Id;

            return Content(HttpStatusCode.Created, new StudentApi(student, new Hateoas($"{localhost}/api/Students/" + student.Id, student.Id.ToString(), "POST")));
        }

        [HttpPut]
        [ResponseType(typeof(Student))]
        public object UpdateStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, new { ModelState, hateoas = new Hateoas($"{localhost}/api/Errors/400", "error.400", "PUT") });
            }

            _context.Students.Update(student);
            _context.SaveChanges();

            student.Id = _context.Students.ToList().OrderByDescending(s => s.Id).First().Id;

            return Content(HttpStatusCode.OK, new StudentApi(student, new Hateoas($"{localhost}/api/Students/" + student.Id, student.Id.ToString(), "PUT")));
        }

        [HttpDelete]
        [ResponseType(typeof(Student))]
        public object DeleteStudent(int id)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, new { ModelState, hateoas = new Hateoas($"{localhost}/api/Errors/400", "error.400", "DELETE") });
            }

            var student = _context.Students.Single(s => s.Id == id);
            _context.Students.Remove(student);
            _context.SaveChanges();

            return Content(HttpStatusCode.OK, new StudentApi(student, new Hateoas($"{localhost}/api/Students/" + student.Id, student.Id.ToString(), "DELETE")));
        }
    }
}
