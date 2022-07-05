using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UjianAPI.Models;

namespace UjianAPI.Controllers
{
    public class TampilanController : Controller
    {
        private UjianAPIContext db = new UjianAPIContext();

        //
        // GET: /Tampilan/

        public ActionResult Index()
        {
            return View(db.Barangs.ToList());
        }

        //
        // GET: /Tampilan/Details/5

        public ActionResult Details(int id = 0)
        {
            Barang barang = db.Barangs.Find(id);
            if (barang == null)
            {
                return HttpNotFound();
            }
            return View(barang);
        }

        //
        // GET: /Tampilan/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tampilan/Create

        [HttpPost]
        public ActionResult Create(Barang barang)
        {
            if (ModelState.IsValid)
            {
                db.Barangs.Add(barang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(barang);
        }

        //
        // GET: /Tampilan/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Barang barang = db.Barangs.Find(id);
            if (barang == null)
            {
                return HttpNotFound();
            }
            return View(barang);
        }

        //
        // POST: /Tampilan/Edit/5

        [HttpPost]
        public ActionResult Edit(Barang barang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(barang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(barang);
        }

        //
        // GET: /Tampilan/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Barang barang = db.Barangs.Find(id);
            if (barang == null)
            {
                return HttpNotFound();
            }
            return View(barang);
        }

        //
        // POST: /Tampilan/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Barang barang = db.Barangs.Find(id);
            db.Barangs.Remove(barang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}