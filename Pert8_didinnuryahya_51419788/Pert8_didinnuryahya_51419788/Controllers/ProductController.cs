using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Pert8_didinnuryahya_51419788.Models;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;

namespace Pert8_didinnuryahya_51419788.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        // harus diganti dengan url api anda
        private Uri api_url = new Uri("http://localhost:1109/");

        //
        // GET: /Product/
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = this.api_url;
            client.DefaultRequestHeaders.Accept.Add(new
           MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/products/").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.products =
               response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            }
            else
            {
                ViewBag.products = "Product Not Found";
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
            HttpResponseMessage response = client.GetAsync("api/products/" +
           id).Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.product = response.Content.ReadAsAsync<Product>().Result;
            }
            else
            {
                ViewBag.product = "error";
            }
            return View();
        }

    }
}
