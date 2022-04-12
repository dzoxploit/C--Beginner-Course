using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pertemuan_1_didinnuryahya_51419788
{
    public partial class TextboxExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsCallback)
            {
                Label_Hasil.Text = "";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
             Label_Hasil.Text = "Hello" + TextBox1.Text + ", apa kabar";
        }
    }
}