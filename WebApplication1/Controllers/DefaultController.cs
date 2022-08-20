using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
            Employee employee = employeeBL.GetEmployeeDetails(103);
            //ViewData["Employee"] = employee;
            //ViewData["Header"] = "Employee Details";


            //ViewBag.Employee = employee;
            //ViewBag.Header = "Employee Details";

            return View(employee);
        }
    }
}