﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.ViewModels;
using ContosoUniversity.DAL;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            /*
            IQueryable<EnrollmentDataGroup> data = from student in db.Students
                                                   group student by student.EnrollmentDate
                                                   into dateGroup
                                                   select new EnrollmentDataGroup()
                                                   {
                                                       EnrollmentDate = dateGroup.Key,
                                                       StudentCount = dateGroup.Count()
                                                   };
                                                    */
            string query = "SELECT EnrollmentDate, COUNT(*) AS StudentCount "
                + "FROM Person " +
                "WHERE Discriminator = 'Student' " +
                "GROUP BY EnrollmentDate";
            IEnumerable<EnrollmentDataGroup> data = db.Database.SqlQuery<EnrollmentDataGroup>(query);


            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}