using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pert5_didinnuryahya_51419788.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(Pert5_didinnuryahya_51419788.Models.Class1 c1)
        {
            c1.ambil(c1.nm);
            if (c1.nm.Equals(c1.dta1) && c1.Pass.Equals(c1.dta2))
            {
                return RedirectToActionPermanent("Index1");
            }
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Index2()
        {
            Pert5_didinnuryahya_51419788.Models.Class2 c = new Models.Class2();
            c.status = "";
            return View(c);
        }

        [HttpPost]
        public ActionResult Index2(Pert5_didinnuryahya_51419788.Models.Class2 c2)
        {
            if (c2.status == null)
            {
                c2.status = c2.isi(c2.nm, c2.Pass);
                Response.Write(" <a href='Index' > Click here to Login</a>");
            }
            return View(c2);
        }



    }
}
