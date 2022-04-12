using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectweb2didinnuryahya51419788
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_click(object sender, EventArgs e)
        {
            string str = "";
            str += txtnama.Text + "<br/>";
            str += txtalamat.Text + "<br/>";
            str += txtkota.Text + "<br/>";
            str += txtprovinsi.Text + "<br/>";
            displayrow.InnerHtml = str;
        }
    }
}