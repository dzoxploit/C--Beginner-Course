using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UjianAPI.Models
{
    public class Barang
    {
        //Id, Name, Price, Stock
        public int Id { set; get; }
        public String Nama { set; get; }
        public double Harga { set; get; }
        public int Stock { set; get; }
    }
}