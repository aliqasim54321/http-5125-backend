﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        //GET : /Student/List
        public ActionResult List()
        {
            StundentDataController controller = new StundentDataController();
            IEnumerable<Student> Students = controller.ListStudents();
            return View(Students);
        }

        //GET : /Student/Show/{id}
        public ActionResult Show(int id)
        {
            StundentDataController controller = new StundentDataController();
            Student NewStudent = controller.FindStudent(id);

            return View(NewStudent);
        }
    }
}