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
      ///  public int Get(int rr)
       // {
      //      return rr;
       // }

        public string post()
        {
            return "this is a post request!!";
        }

        ///<summary>
        ///Divide a number by 2. Truncates the result
        ///</summary>
        ///<param name="id">the number to divide </param>
        ///<example>
        ///GET : localhost:xx/api/integer/-11 => 5
        ///</example>
        //////<example>
        ///GET : localhost:xx/api/integer/10 => 5
        ///</example>
        //////<example>
        ///GET : localhost:xx/api/integer/2 => 1
        ///</example>

        public int Get(int id)
        { 
        int result = id / 2;
        return result;
        }


    }
}
