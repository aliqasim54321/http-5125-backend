using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProjectW2024.Controllers
{
    public class ExampleController : ApiController
    {
        //Get request
        public int Get(int id) 
        {
            return id*3; 
        }

    }
}
