using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Pert7.Models
{
    public class Order
    {
	public Int32 Id { get; set; }
        public Int32 Timestamp { get; set; }
        public Int32 User_Id { get; set; }
        public Int32 Product_Id { get; set; }
        public String Status { get; set; }
    }
}
