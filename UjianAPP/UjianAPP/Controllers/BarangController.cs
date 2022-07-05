using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using UjianAPP.Models;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;

namespace UjianAPP.Controllers
{
    public class BarangController : Controller
    { //
        // GET: /Barang/

        // harus diganti dengan url api anda
        private Uri api_url = new Uri("http://localhost:18061/");

        //
        // GET: /Product/
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = this.api_url;
            client.DefaultRequestHeaders.Accept.Add(new
           MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/barang/").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.barang =
               response.Content.ReadAsAsync<IEnumerable<Barang>>().Result;
            }
            else
            {
                ViewBag.barang = "Product Not Found";
            }
            return View();
        }
        //
        // GET: /Product/Details/5
        public ActionResult Details(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = this.api_url;
            client.DefaultRequestHeaders.Accept.Add(new
           MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/barang/" +
           id).Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.detailbarang = response.Content.ReadAsAsync<Barang>().Result;
            }
            else
            {
                ViewBag.detailbarang = "error";
            }
            return View();
        }

    }
}
