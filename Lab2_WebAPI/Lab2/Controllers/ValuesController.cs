using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class ValuesController : ApiController
    {
        //Stack<int> _stack = new Stack<int>();
        //private int _result = 0;
        JavaScriptSerializer _js = new JavaScriptSerializer();

        // GET api/values
        public string Get()
        {
            if (Result.stack.Count != 0)
            {
                Result.result += Result.stack.Peek();
            }
            
            return _js.Serialize(new {result = Result.result});
        }

        // POST api/values
        [HttpPost]
        public string Post(int result)
        {
            if (Result.stack.Count != 0)
            {
                Result.result += Result.stack.Peek();
            }
            
            Result.result = result;
            return _js.Serialize(new {result = Result.result});
        }

        // PUT api/values
        [HttpPut]
        public void Put(int add = 0)
        {
            Result.stack.Push(add);
        }

        // DELETE api/values/5
        public void Delete()
        {
            Result.stack.Pop();
        }
    }
}
