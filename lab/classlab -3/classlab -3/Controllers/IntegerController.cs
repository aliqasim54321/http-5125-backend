using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace classlab__3.Controllers
{
    public class IntegerController : ApiController
    {
        public int Get(int id)
        {
            return id;
        }

        public string post()
        {
            return "this is a post request!!";
        }
    }
}
