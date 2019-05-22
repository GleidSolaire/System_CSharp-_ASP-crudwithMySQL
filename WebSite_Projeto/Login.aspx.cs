using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=ramais; password=''");
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

     
        MySqlCommand comando = new MySqlCommand("SELECT login,senha FROM user_login WHERE login = '" + txtLogin.Text + "' and senha='" + txtSenha.Text + "'", conexao);
       
        try
        {
            conexao.Open();
           
            comando.Parameters.AddWithValue("@LOGIN", txtLogin.Text);
            comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);
            //comando.ExecuteNonQuery();
            MySqlDataReader reader = comando.ExecuteReader();
           
            if (reader.Read())

            {


                FormsAuthentication.RedirectFromLoginPage(txtLogin.Text,true);
                
               
            }
            else
            {
                Message("Login Incorreto");
            }
          

       
        }
        finally
        {
            conexao.Close();
        }




    }

    public void Message(string msg)
    {
        ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'> alert('" + msg + "');</script>");
    }
}