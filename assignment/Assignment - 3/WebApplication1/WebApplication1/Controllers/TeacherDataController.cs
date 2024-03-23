using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;


namespace WebApplication1.Controllers
{
    public class TeacherDataController : ApiController
    {
      [HttpGet]
      [Route("api/teacherdata/listteachers")]

        public string ListTeachers()
        {
            return "good morning";
        }
    }
}
