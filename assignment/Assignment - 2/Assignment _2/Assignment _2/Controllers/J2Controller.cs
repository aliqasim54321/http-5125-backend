using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment__2.Controllers
{
    public class J2Controller : ApiController
    { ///<summary>
      ///we have to determine how many ways a dices can roll a vlaue of 10
      ///eg: input m =3 and n = 3, 
      ///<return> There are 0 total ways to get the sum 10.</return>
      ///eg: second example is m = 5,n = 5;
      ///<return> There are 1 total ways to get the sum 10.</return>
      ///route :GET ../api/J2/DiceGame/6/8  
      ///<return> There are 5 total ways to get the sum 10.</return>
      ///</summary>
        [HttpGet]
        [Route("api/j2/DiceGame/{m}/{n}")]

        public string Calculate(int m, int n)
        {
            int waytoget10 = 0;
            //using for loop to loop the possible rolls of the two dice

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //condition to check the sum of two rolls is 10
                    if (i + j == 10)
                    {
                        waytoget10++;
                    }
                }

            }
            string result;
            // checking the condition for the total number of ways to get the sum'
            if (waytoget10 == 0)
            {
                result = "There are 0 ways to get the sum 10.";
            }
            else if (waytoget10 == 1)
            {
                result = "There are 1 ways to get the sum 10.";
            }
            else
            {
                result = $"There are {waytoget10} total ways to get the sum 10.";
            }
            //answer is stored in the result 
            return result;
        }
    }
}
