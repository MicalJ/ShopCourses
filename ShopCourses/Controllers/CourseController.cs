﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopCourses.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string nameCategory)
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

    }
}