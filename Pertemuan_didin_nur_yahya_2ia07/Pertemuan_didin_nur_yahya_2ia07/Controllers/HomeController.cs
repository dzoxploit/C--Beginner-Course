using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pertemuan_didin_nur_yahya_2ia07.Models;


namespace Pertemuan_didin_nur_yahya_2ia07.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            daftarmahasiswa viewmodel = new daftarmahasiswa();
            return View(viewmodel);
        }

        public ActionResult Infomhs(String id)
        {
            daftarmahasiswa viewmodel = new daftarmahasiswa();
            if (viewmodel.mhs.Any(i => i.npm == id))
            {
                mahasiswa dataitem = viewmodel.mhs.Where(i => i.npm == id).First();
                return View(dataitem);
            }
            else
            {
                return RedirectToAction("NotFound");
            }
        }

        public HttpNotFoundResult NotFound()
        {
            return HttpNotFound("NPM Tidak Ditemukan");
        }

    }
}
