using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace classlab__3.Controllers
{
    public class TestController : ApiController

    {
        public string Get(string id)
        {
            string message = "hello " + id;
            return message;
        }
    }
}