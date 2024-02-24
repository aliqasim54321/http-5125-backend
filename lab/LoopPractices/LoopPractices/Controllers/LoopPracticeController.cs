using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoopPractices.Controllers
{

    public class LoopPracticeController : ApiController
    {
        [HttpGet]
        [Route("api/LoopPractice/whilelooptest/{ceiling}")]
        public string Test(int ceiling)
        {
            int start = 1;
            string message = "";

            while (start == ceiling)
            {

                message = message + start.ToString();
                start = start + 1; ;


            }

            return message;
        }

        [HttpGet]
        [Route("api/LoopPractice/forloop/{start}/{run}")]

        public string Tesp(int run, int start)
        {
            string message = "";
            for (; start >= run; start--)
            {
                if (start == run)
                {
                    message = message + start.ToString();
                }
                else
                {
                    message = message + start.ToString() + ",";
                }
            }


            return message;
        }

        [HttpGet]
        [Route("api/looppractice/foreachloop")]
        
        public string Foreachloop()
        {
        List<string> tvshows = new List<string>();

         tvshows.Add("got");
         tvshows.Add("black water");
         tvshows.Add("watergirl");
         tvshows.Add("friends");
         tvshows.Add("ola");
         tvshows.Add("24");
         string delimitor = ",";
         string favshows = "";

        for (int i = 0; i <=tvshows.Count()-1 ; i++)
            {
                if(i== tvshows.Count() - 1)
                {
                     delimitor="";
                }
               
                
                    favshows += tvshows[i]+delimitor;
                  
              
               
            }

            return favshows;
        }
    }

}
   


