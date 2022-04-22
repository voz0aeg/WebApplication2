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
    public partial class Ej4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            dbCon f = new dbCon();

            t = f.Consulta2("select id, nombre, ap, am, CONVERT(nvarchar, fnac,103)fnac from t_clientes");

            GridView1.DataSource = t;
            GridView1.DataBind();
            
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("editCliente.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            var id = row.Cells[1].Text;
            

            Response.Redirect("editCliente.aspx?id="+id);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = GridView1.Rows[e.RowIndex].Cells[1];
            idr.InnerText = cell.Text;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "OpenModal('MPregunta1');", true);
        }

        protected void btnSI_Click(object sender, EventArgs e)
        {
            dbCon f = new dbCon();
            f.Guardar("delete t_Clientes where id='" + idr.InnerText + "'");
            Response.Redirect("Ej4.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" && txtAp.Text == "" && txtfNac.Text == "")
            {
                return;
            }

                DataTable t = new DataTable();
            dbCon f = new dbCon();

            string where ="";

            if (txtNombre.Text != "")
                where = " nombre = '" + txtNombre.Text + "' ";
            
            if (txtAp.Text != "" )
                where = " ap ='" + txtAp.Text + "' ";
            
            if (txtfNac.Text != "")
                where = " fnac=convert(date,'" + txtfNac.Text + "',103) ";

            if (txtNombre.Text != "" && txtAp.Text != "")
                where = " nombre = '" + txtNombre.Text + "' and ap='" + txtAp.Text + "'" ;

            if (txtNombre.Text != "" && txtAp.Text != "" && txtfNac.Text != "")
                where = " nombre = '" + txtNombre.Text + "' and ap='" + txtAp.Text + "' and fnac=convert(date,'" + txtfNac.Text  + "',103)";

            if (txtNombre.Text != "" && txtfNac.Text != "")
                where = " nombre = '" + txtNombre.Text + "' and fnac=convert(date,'" + txtfNac.Text + "',103)";

            if (txtAp.Text != "" && txtfNac.Text != "")
                where = " ap='" + txtAp.Text + "' and fnac='" + txtfNac.Text + "'";



            t = f.Consulta2("select id, nombre, ap, am, CONVERT(nvarchar, fnac,103)fnac from t_clientes where " + where);
            GridView1.DataSource = t;
            GridView1.DataBind();
        }


    }
}