
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment__2.Controllers
{
    public class HappinessController : ApiController

    ///<summary>
    ///we have to determine wheather the dog is happy or sad based on the formula
    ///formula = 1*S+2*M+3*L, where S,M,L stands for small,medium,Large respectively.
    ///If the sum of the given input is greater than 10 then the dog is happy else he is sad
    ///eg: input is "310" and expected output is  =>1*3+2*1+3*0 = 3+2+0 = 5< 10 and hence barley is "sad"
    ///eg: second example is "321"; the expected output is 1×3+2×2+3×1=10, that is barley is "happy"
    ///<param name ="s,m,l"</param>
    ///route : api/j1/calculate/{4}/{2}/{4} ---> 20
    ///<return> happy</return>
    ///</summary>
    {
        [HttpGet]
        [Route("api/j1/calculate/{S}/{M}/{L}")]

        public string Mood(int S, int M, int L)
        {
            // Calculate Barley's happiness score
            int happinessscore = 1 * S + 2 * M + 3 * L;
            
            //Determine if barley is happy or sad
            if(happinessscore >= 10){
                return "happy";
            }
            else
            {
                return "sad";
            }
                }


    }
}


