using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab3_Hateoas.Controllers
{
    public class ErrorsController : ApiController
    {
        public object Get(int id)
        {
            switch (id)
            {
                case 400:
                    return Ok(new { id = 400});
                case 404:
                    return Ok(new { id = 404});
                default:
                    return Ok(new { id = 500});
            }
        }
    }
}
