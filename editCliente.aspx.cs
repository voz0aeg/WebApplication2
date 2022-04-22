using dbcons.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication2
{

    public partial class editCliente : System.Web.UI.Page
    {
        dbCon f = new dbCon();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                return;
            }
            else
            {
                var idExp = Request.QueryString["id"];
                if (idExp != null)
                {
                    hid.Value = idExp;
                    CargaDatos(hid.Value);
                }
                else
                {
                    hid.Value = "0";
                }
                
            }
            

        }

        private void CargaDatos(string value)
        {

            reps p = new reps();
            Cliente c = new Cliente();
            c = p.CargaDatos(value);

            txtNombre.Text = c.nombre;
            txtap.Text = c.ap;
            txtam.Text = c.am;
            txtFNac.Text = c.FNac.ToString("yyyy-MM-dd");
            txtcp.Text = c.cp;
            txtCol.Text = c.Col;
            txtMun.Text = c.Mun;
            txtEdo.Text = c.Edo;
            txtTel.Text = c.Tel;
            txtCel.Text = c.Cel;
            txtEmail.Text = c.Email;

        }

        protected void txtcp_TextChanged(object sender, EventArgs e)
        {
            if (txtcp.Text == "") return;

            var r = f.Consulta1("select * from cat_cp where cp='"  + txtcp.Text + "'");

            if ( r != null)
            {
                txtCol.Text = r["col"].ToString();
                txtEdo.Text = r["edo"].ToString();
                txtMun.Text = r["mun"].ToString();
            }
            else
            {
                txtCol.Text = "";
                txtEdo.Text = "";
                txtMun.Text = "";
            }
            


        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Cliente c = new Cliente();
            c.nombre = txtNombre.Text;
            c.ap = txtap.Text;
            c.am = txtam.Text;
            c.FNac = Convert.ToDateTime(txtFNac.Text);
            c.cp = txtcp.Text;
            c.Col = txtCol.Text;
            c.Mun = txtMun.Text;
            c.Edo = txtEdo.Text;
            c.Tel = txtTel.Text;
            c.Cel = txtCel.Text;
            c.Email = txtEmail.Text;

            reps p = new reps();

            if (hid.Value == "0")
            {
                p.SaveCliente(c);
            }
            else
            {
                c.id = hid.Value;
                p.UpdateCliente(c);
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "ok();", true);

        }

       
    }
}