using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Security;


public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
 
        

//Efetua o logout, desconectando o usuário.

        FormsAuthentication.SignOut();

Response.Redirect("Login.aspx");

//Redireciona o usuário para a página "default.aspx".
    }
}