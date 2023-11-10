using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public class NewRegister : Page
{
    public TextBox txtNombre;
    public TextBox txtApellidos;
    public TextBox txtEmail;
    public TextBox txtTelefono;

    public void Page_Load(object sender, EventArgs e)
    {
        // validate session
        if (Session["misContactos"] == null)
        {
            // create new DataTable
            DataTable dt = new DataTable();

            // add columns
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Email");
            dt.Columns.Add("Telefono");

            // save data in session
            Session["misContactos"] = dt;
        }
    }

    public void btnSubmit_Click(object sender, EventArgs e)
    {
        // get data from session
        DataTable dt = (DataTable)Session["misContactos"];

        // validate data
        if (txtNombre.Text == "" || txtApellidos.Text == "" || txtEmail.Text == "" || txtTelefono.Text == "")
        {
            // show alert
            Response.Write("<script>alert('Todos los campos son obligatorios');</script>");
            return;
        }

        // validate email
        string email = txtEmail.Text.Trim();

        // Expresión regular para validar una dirección de correo electrónico
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

        if (!(System.Text.RegularExpressions.Regex.IsMatch(email, pattern)))
        {
            // show alert
            Response.Write("<script>alert('Correo electrónico no válido');</script>");
            return;
        }

        //get the id
        int id = dt.Rows.Count + 1;

        // add new row
        dt.Rows.Add(id, txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text);

        // save data in session
        Session["misContactos"] = dt;

        // show alert
        Response.Write("<script>alert('Contacto agregado correctamente');</script>");

        // redirect to Contact List
        Response.Redirect("Default.aspx");
    }
}
