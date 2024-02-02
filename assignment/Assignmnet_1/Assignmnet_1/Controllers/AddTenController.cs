using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adding 10 to the user input  
        /// </summary>
        /// <param name="id">The input number to add by 10</param>
        /// <returns>The input number plus 10</returns>
        /// Get localhost:xx/api/AddTen/3 => 13
        public int Get(int id)
        {
            int add = id + 10;
            return add;
        } 
    }
}
