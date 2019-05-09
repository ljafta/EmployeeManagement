using MvcTeams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcTeams.Controllers
{
    public class EmployeeController : Controller
    {
        //private static masterEntities db = new masterEntities()
        DevTeamDBEntities1 context = new DevTeamDBEntities1();

        // GET: Employee
        public ActionResult Index()
        {
                        
                // the rest

                try
                {
                    var emp = context.Employees.ToList();
                    return View(emp);
                }
                catch (Exception e)
                {
                    e.Message.ToString();
                }
           return View();
        }

        // Get  
        public ActionResult Create()
        {
            return View();
        }
    }
}