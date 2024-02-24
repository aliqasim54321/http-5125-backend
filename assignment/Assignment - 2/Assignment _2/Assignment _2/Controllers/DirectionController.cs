using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment__2.Controllers
{
    public class DirectionController : ApiController
    {    /// <summary> 
         /// we have to decode the instruction based on the secretformula used
         /// If their sum is odd, then the direction to turn is left. 
         /// If their sum is even and not zero, then the direction to turn is right.
         /// If their sum is zero,then the direction to turn is the sameas the previous instruction.
         /// <param name="decodeinstruction" ></param>
         /// </summary>
         /// 
         ///  <example>
         /// -->api/SecretInstruction/SecretFormula/57234 
         /// <returns>right 234</returns>

         /// -->api/SecretInstruction/SecretFormula/00907
         /// <returns>right 907</returns>

        /// -->api/SecretInstruction/SecretFormula/34100
        ///  <returns>left 100</returns>


        [HttpGet]
        [Route("api/SecretFormulaDecoder/DecodeInstructions/{decodeinstruction}")]
        public string DecodeInstructions(string decodeinstruction)
        {
            //it ittirates until the string is null or less than 5
            while (decodeinstruction != null && decodeinstruction.Length >= 5)
            {
                int digitone = int.Parse(decodeinstruction.Substring(0, 1));
                int digittwo = int.Parse(decodeinstruction.Substring(1, 1));
                int direction = digitone + digittwo;
                int moves = int.Parse(decodeinstruction.Substring(2));

                string directionTowards;
                //to check the direction according to the user input 
                if ((direction % 2 == 0) || (direction == 0))
                {
                    directionTowards = "right";
                }
                else
                {
                    directionTowards = "left";
                }
                //returnig the result                 
                return directionTowards + " " + moves + " " + DecodeInstructions(decodeinstruction.Substring(5));
            }
            // If the user input is null or less than 5 then  return an empty string
            return " ";

        }

    }
}

