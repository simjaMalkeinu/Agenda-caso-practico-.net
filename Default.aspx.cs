using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public class Default : Page
{
    public DataGrid misContactos;
    public Label alert;
    public void Page_Load(object sender, EventArgs e)
    {
        if (Session["misContactos"] == null)
        {
            // Create a new DataTable
            DataTable dt = new DataTable();

            // Add some columns to the table
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellidos", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Telefono", typeof(string));

            // Set the data source of the DataGrid
            misContactos.DataSource = dt;
            misContactos.DataBind();

            //save data in session
            Session["misContactos"] = dt;
        }
        else
        {
            //load data from session
            misContactos.DataSource = Session["misContactos"];
            misContactos.DataBind();
        }

        if (misContactos.Items.Count > 0)
        {
            alert.Visible = true;
        }
        {
            alert.Visible = false;
        }
    }
}