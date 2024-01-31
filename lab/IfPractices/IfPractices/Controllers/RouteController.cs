using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfPractices.Controllers
{
    public class RouteController : ApiController
    {
        [HttpGet]
        [Route("api/Route/Method")]
        public string Method1()
        {
            return "Method 1";
        }
        [HttpGet]
        public string Method2()
        {
            return "Method 2";
        }

    }
}
