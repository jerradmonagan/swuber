using Swuber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;
using System.Net;

namespace Swuber.Controllers
{
    public class CurrentCustomerController : Controller
    {
        private SWOOPEntities db = new SWOOPEntities();
        List<CurrentCustomer> walkerList = new List<CurrentCustomer>();
        List<CurrentCustomer> driverList = new List<CurrentCustomer>();
        // GET: CurrentCustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Driver()
        {
            return View();
        }
        /*var driverTemp = new Swuber.Models.CurrentCustomer(Session["FirstName"].ToString(), Session["LastName"].ToString(), Session["Phone"].ToString());
        // CurrentCustomer driverTemp = new CurrentCustomer(Session["FirstName"].ToString(), Session["LastName"].ToString(), Session["Phone"].ToString());
         driverList.Add(driverTemp);
         //Console.WriteLine(driverList);
         ViewData["driverList"] = driverList;
         return View(driverList);*/

        public ActionResult Walker()
        {
            var walkerTemp = new Swuber.Models.CurrentCustomer(Session["FirstName"].ToString(), Session["LastName"].ToString(), Session["Phone"].ToString());
            // CurrentCustomer WalkerTemp = new CurrentCustomer(Session["FirstName"].ToString(), Session["LastName"].ToString(), Session["Phone"].ToString());
            walkerList.Add(walkerTemp);
            ViewData["WalkerList"] = walkerList;
            return View(walkerList);

        }
        public ActionResult GMaps()
        {
            return View();
        }
    }
}