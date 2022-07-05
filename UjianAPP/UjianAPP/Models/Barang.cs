using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UjianAPP.Models
{
    public class Barang
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public double Harga { get; set; }
        public int Stock { get; set; }
    }
}