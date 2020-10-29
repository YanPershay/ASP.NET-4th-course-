using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using Newtonsoft.Json;

namespace Lab1.Handlers
{
    public class ServiceHandler : IHttpHandler, IRequiresSessionState
    {
        private static int _result = 0;
        JavaScriptSerializer js = new JavaScriptSerializer();
        Stack<int> _stack = new Stack<int>();
        
        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            HttpRequest req = context.Request;
            res.ContentType = "application/json";

            if(context.Request.HttpMethod.Equals("POST"))
            {
                int number = 1;
                if(int.TryParse(req.Params["result"], out number))
                {
                    _result += number;
                    res.Write(js.Serialize(new {result = _result}));
                }
                
            }
            else if(context.Request.HttpMethod.Equals("GET"))
            {
                if (_stack.Count != 0)
                {
                    _result += _stack.Peek();
                }

                res.Write(js.Serialize(new {result = _result}));
            }
            else if(context.Request.HttpMethod.Equals("PUT"))
            {
                int number = 1;
                if(int.TryParse(req.Params["add"], out number))
                {
                    _stack.Push(number);
                    res.Write(js.Serialize(new {result = _result}));
                }
            } 
            else if (context.Request.HttpMethod.Equals("DELETE"))
            {
                _stack.Pop();
                res.Write(js.Serialize(new {result = _result}));
            }
        }

        public bool IsReusable => true;
    }
}