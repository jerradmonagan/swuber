using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Swuber.Models;

namespace Swuber.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Customer objUser)
        {
            if (ModelState.IsValid)
            {
                using (SWOOPEntities db = new SWOOPEntities())
                {
                    var obj = db.Customers.Where(a => a.NNumber.Equals(objUser.NNumber) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["NNumber"] = obj.NNumber.ToString();
                        Session["FirstName"] = obj.FirstName.ToString();
                        Session["LastName"] = obj.LastName.ToString();
                        Session["Phone"] = obj.Phone.ToString();
                        Session["Tag"] = obj.Tag.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["NNumber"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Login");
            }
        }
    }
}