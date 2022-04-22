using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Ej2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, m;
            n1= Int32.Parse(txtEntero1.Text);
            n2 = Int32.Parse(txtEntero2.Text);
            n3 = Int32.Parse(txtEntero3.Text);
            m = n1;
            if (m>n2 && m>n3)
            {
                m = n1;
            }else if (n2>n1 && n2>n3)
            {
                m = n2;
            }else  
            {
                m = n3;
            }
            

            txtResultado.Text = m.ToString();
        }
    }
}