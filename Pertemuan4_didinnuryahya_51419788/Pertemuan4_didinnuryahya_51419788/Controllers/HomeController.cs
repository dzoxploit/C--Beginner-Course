using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pertemuan4_didinnuryahya_51419788.Models;

namespace Pertemuan4_didinnuryahya_51419788.Controllers
{
    public class HomeController : Controller
    {

        Data isi = new Data();
        List<Data> data;

        public static List<Data> KaryawanList = new List<Data>
        {
            new Data{ID = 1, Name = "Didin Nur Yahya", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 22},
            new Data{ID = 2, Name = "Carson", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 45},
            new Data{ID = 3, Name = "Carson", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 37},
            new Data{ID = 4, Name = "Laura", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 26},
        };

        public ActionResult Index()
        {
            var DataList = from e in KaryawanList
                           orderby e.ID

                           select e;
            return View(DataList);
        }

       // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            List<Data> data_karyawan = KaryawanList;
            var pegawai = data_karyawan.Single(m => m.ID == id);
            return View(pegawai);
        }

        //GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(FormCollection collection) {
            try
            {
                Data dt = new Data();
                dt.Name = collection["Name"];
                DateTime date = new DateTime();
                dt.JoiningDate = Convert.ToDateTime(collection["JoiningDate"] + " " +
                date.TimeOfDay.ToString());

                string age = collection["Age"];
                dt.Age = Int32.Parse(age);
                KaryawanList.Add(dt);
                return RedirectToAction("Index");

            } catch {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id) {
            List<Data> data_karyawan = KaryawanList;
            var pegawai = data_karyawan.Single(m => m.ID == id);
            return View(pegawai);
        }

        [HttpPost]

        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var employee = KaryawanList.Single(m => m.ID == id);

                if (TryUpdateModel(employee)) {
                    return RedirectToAction("Index");
                }

                return View(employee);

            }
            catch
            {
                return View();
            }
        }
        // GET: Employee/Delete/5
        public ActionResult Delete(int id) {
            List<Data> data_karyawan = KaryawanList;
            KaryawanList.RemoveAt(id - 1);
            return RedirectToAction("Index");
        }
        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try
            {
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }
    }
}
