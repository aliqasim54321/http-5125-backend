using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet_1.Controllers
{
    public class Greeting_idController : ApiController

    {
        /// <summary>
        /// Greeting to the number of people given by the user
        /// </summary>
        /// <param name="id">The input number will be given by the user</param>
        /// <returns>Greeting to "the number given by the user" people</returns>
        /// GET localhost:xx/api/greeting_id/4 => Greeting to 4 people!
        public String Get(String id)
        {
            String greet = "Greeting to " + id + " people!";
            return greet;
        }
    }
}
