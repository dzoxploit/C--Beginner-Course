using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pert7_Harry.Models
{
    public class Product
    {
        //ID, Name, Price, Stock
        public int Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int Stock { set; get; }
    }
}