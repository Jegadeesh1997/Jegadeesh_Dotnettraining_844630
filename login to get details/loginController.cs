using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace logininfo.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(string li, string ps)
        {
            masterEntities d = new masterEntities();

            var l = d.LOGININFOes.Where(i => i.USERNAME == li && i.PASSWORD == ps).Select(i => i.USERID).FirstOrDefault();
            if (l != 0)
            {
                var u = d.USERDETAILS.Where(i => i.USERID == l).Select(i => i);
                foreach (var i in u)
                {
                    ViewBag.un = i.DETID + " | " + i.FULLNAME +  " | " + i.AGE + " | " + i.CITY;
                }
            }
            else
            {
                ViewBag.un = "Wrong User name and password";
            }
            return View();
        }
       

    }
}
