using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet_1.Controllers
{
    public class GreetingController : ApiController
    {   /// <summary>
        /// Greeting to the number of people given by the user
        /// </summary>
        /// <param name="id">The input number will be given by the user</param>
        /// <returns>Greeting to "the number given by the user" people</returns>
        /// post curl -d "" http://localhost:xx/api/Greeting => Hello World
        public String Post()
        {
            return "Hello World";
        }
    }
}
