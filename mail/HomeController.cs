using mail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mail.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult mailinfo(string un, string ps)
        {
            jegaEntities jd = new jegaEntities();
            csmodel mode = new csmodel();
            List<csmodel> l = new List<csmodel>();
            int ui = jd.userinfoes.Where(i => i.username == un && i.pass == ps).Select(i => i.userid).FirstOrDefault();
            if(ui!=0)
            {
                
                var m = jd.maildetails.Where(i => i.userid == ui).Select(i => i);
                foreach(var i in m)
                {
                    l.Add(new csmodel() { mailid = i.mailid, sub=i.sub , Date=(DateTime)i.recieveddate});
                }
               
            }

            return View(l);
        }
        public ActionResult info(int id)
        {
            jegaEntities jd = new jegaEntities();
            csmodel mode = new csmodel();
            var m = jd.maildetails.Where(i => i.mailid ==id ).Select(i => i).FirstOrDefault();
            mode.mes = m.mes;
            return View(mode);
            
        }


    }
}
