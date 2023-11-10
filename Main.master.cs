using System;
using System.Web.UI;
using System.Web.UI.WebControls;
public class Main : MasterPage
{
    public void lnkBtnAll_Click(object sender, EventArgs e)
    {
        // navigate to default page
        Response.Redirect("Default.aspx");
        
    }

    public void lnkBtnAdd_Click(object sender, EventArgs e)
    {
        // Navigate to new register page
        Response.Redirect("NewRegister.aspx");
    }
}