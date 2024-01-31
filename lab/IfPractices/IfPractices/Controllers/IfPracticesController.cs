using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace IfPractices.Controllers
{
    public class IfPracticeController : ApiController
    {
        //GET api/IfPracctices/Test -> "if practices test"
        [HttpGet]
        [Route("api/IfPractice/TrackAudition/{HighJump}")]
        public string TrackAudition(int HighJump)
        {

            if (HighJump >= 145)
            {

                return "Qualified";
            }
            else if(HighJump >145 && HighJump >= 170)
            {
                return "tryout";
            }
            else {
                return "Not Qualified";
            }
             
        }
    }
}
