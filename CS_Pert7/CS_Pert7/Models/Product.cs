using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Pert7.Models
{
    public class Product
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }
        public Int32 Stock { get; set; }
    }
}