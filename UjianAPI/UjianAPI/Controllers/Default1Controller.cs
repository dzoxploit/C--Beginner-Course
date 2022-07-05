using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using UjianAPI.Models;

namespace UjianAPI.Controllers
{
    public class Default1Controller : ApiController
    {
        private UjianAPIContext db = new UjianAPIContext();

        // GET api/Default1
        public IEnumerable<Barang> GetBarangs()
        {
            return db.Barangs.AsEnumerable();
        }

        // GET api/Default1/5
        public Barang GetBarang(int id)
        {
            Barang barang = db.Barangs.Find(id);
            if (barang == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return barang;
        }

        // PUT api/Default1/5
        public HttpResponseMessage PutBarang(int id, Barang barang)
        {
            if (ModelState.IsValid && id == barang.Id)
            {
                db.Entry(barang).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Default1
        public HttpResponseMessage PostBarang(Barang barang)
        {
            if (ModelState.IsValid)
            {
                db.Barangs.Add(barang);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, barang);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = barang.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Default1/5
        public HttpResponseMessage DeleteBarang(int id)
        {
            Barang barang = db.Barangs.Find(id);
            if (barang == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Barangs.Remove(barang);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, barang);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}