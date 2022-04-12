using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PertemuanTerakhir.Controllers
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
        public ActionResult Index(Models.Class1 mod)
        {
            mod.Login();
            if (mod.id.Equals(mod.usr) && (mod.pass.Equals(mod.ps)))
            {
                HttpCookie cookie = new HttpCookie("Admin");
                cookie.Value = "Hello Cookie! CreatedOn: " +
               DateTime.Now.ToShortTimeString();
                cookie.Expires = DateTime.Now.AddMinutes(2);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                return RedirectToAction("Admin", "Home");
            }
            return View();
        }
        public ActionResult Admin()
        {
            if (!this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Admin(Models.Class1 cs)
        {
            if (cs.title != null)
            {
                cs.isi_kontent();
            }
            if (cs.hapus != null)
            {
                cs.hapus_kontent();
            }
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(Models.Class1 mod)
        {
            mod.Login();
            if (mod.id.Equals(mod.usr) && (mod.pass.Equals(mod.ps)))
            {
                HttpCookie cookie = new HttpCookie("Admin");
                cookie.Value = "Hello Cookie! CreatedOn: " +
               DateTime.Now.ToShortTimeString();
                cookie.Expires = DateTime.Now.AddMinutes(2);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                return RedirectToAction("Admin", "Home");
            }
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Models.Class1 mod)
        {
            mod.Login();
            if (mod.id.Equals(mod.usr) && (mod.pass.Equals(mod.ps)))
            {
                HttpCookie cookie = new HttpCookie("Admin");
                cookie.Value = "Hello Cookie! CreatedOn: " +
               DateTime.Now.ToShortTimeString();
                cookie.Expires = DateTime.Now.AddMinutes(2);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                return RedirectToAction("Admin", "Home");
            }
            return View();
        }

    }
}
