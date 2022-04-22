using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Ej3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            decimal n1, n2, r;
            n1 = Int32.Parse(txtEntero1.Text);
            n2 = Int32.Parse(txtEntero2.Text);
            r =  ((n1 * n2) / 2);

            txtResultado.Text = r.ToString();
        }

    }
}