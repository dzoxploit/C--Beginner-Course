using Pert6_didinnuryahya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pert6_didinnuryahya.Controllers
{
    public class MusikController : ApiController
    {
        List<Musik> musiks = new List<Musik>{
         new Musik {
            id = 1,
            judul = "bebas",
            penyanyi = "Didin Nur Yahya",
            tahun = 2000
         },
          new Musik {
            id = 2,
            judul = "Alone",
            penyanyi = "Ahmad Badowi",
            tahun = 2001
         },
          new Musik {
            id = 3,
            judul = "Its me",
            penyanyi = "cecep supriatna",
            tahun = 2002
         },
        };
        public IEnumerable<Musik> Get() {
            return musiks;
        }
        public Musik Get(int id) {
            var musik = musiks.FirstOrDefault((m) => m.id == id);
            return musik;
        }
    }
}
