using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;


public partial class Default2 : System.Web.UI.Page
{

    MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=ramais; password=''");

    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack) // esse postback é para a pagina nao fazer o reload 
        {

            if (Session["adicionar"].ToString() == "0") //recuperando a variavel de sesso, se for 0 seu valor ele limpa os textbox para realizar o cadastro 
            {
                LimpaCampos();
            }
            else
            {
                PesquisarLista(); 
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Session["Code"].ToString() == "0") // recuperando a sessao, se for igual a 0 ele vai adicionar um novo registro, isto e se vier com os texbox vazios
        {

            MySqlCommand comando = new MySqlCommand("INSERT INTO lista (nome, ramal, departamento, torre, email)  values (@nome, @ramal, @departamento, @torre, @email )", conexao);

            DataTable tabela = new DataTable();
            try
            {
                conexao.Open();

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@RAMAL", txtRamal.Text);
                comando.Parameters.AddWithValue(@"DEPARTAMENTO", txtDepartamento.Text);
                comando.Parameters.AddWithValue("@TORRE", txtTorre.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.ExecuteNonQuery();
                LimpaCampos();
                conexao.Close();

                Response.Redirect("Default.aspx");
            }


            finally
            {
                conexao.Close();
            }

        }
        else if(Session["code"].ToString() != "0") // se for diferente de 0 ele vai atualizar o registro, que ira vir 
                                                  //com a linha selecionada do grid e carregada com os dados na textbox
        { 

            MySqlCommand comando2 = new MySqlCommand("UPDATE  lista SET  nome = @nome, ramal = @ramal, departamento=@departamento, torre=@torre, email= @email WHERE code =@Code  ", conexao);


            try
            {
                conexao.Open();

                comando2.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando2.Parameters.AddWithValue("@RAMAL", txtRamal.Text);
                comando2.Parameters.AddWithValue(@"DEPARTAMENTO", txtDepartamento.Text);
                comando2.Parameters.AddWithValue("@TORRE", txtTorre.Text);
                comando2.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando2.Parameters.AddWithValue("@CODE", Session["code"]);
                comando2.ExecuteNonQuery();

                conexao.Close();

                Response.Redirect("Default.aspx");
            }

            finally
            {
                conexao.Close();
            }

        }
    }

    private void LimpaCampos()
    {
        txtNome.Text = "";
        txtRamal.Text = "";
        txtDepartamento.Text = "";
        txtTorre.Text = "";
        txtEmail.Text = "";

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

        MySqlCommand comando = new MySqlCommand("DELETE FROM lista WHERE code = @DELETAR", conexao);


        try
        {
            conexao.Open();

            comando.Parameters.AddWithValue("@DELETAR", Session["Code"]);
            comando.ExecuteNonQuery();


            conexao.Close();

            Response.Redirect("Default.aspx");
        }

        finally
        {
            conexao.Close();
        }
    }

    protected void PesquisarLista()
    {  
        //esse metodo recupera a linha selecionada da grid para carregar nos textbox
  
        MySqlCommand comando = new MySqlCommand("SELECT  code, nome, ramal, departamento, torre, email FROM lista  where code = @SELECIONAR", conexao);

        try
        {
            conexao.Open();

            comando.Parameters.AddWithValue("@SELECIONAR", Session["Code"]);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {


                txtNome.Text = reader["nome"].ToString();
                txtRamal.Text = reader["ramal"].ToString();

                txtDepartamento.Text = reader["departamento"].ToString();
                txtTorre.Text = reader["torre"].ToString();
                txtEmail.Text = reader["email"].ToString();


            }


        }
        finally
        {
            conexao.Close();
        }



    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    public void Message(string msg)
    {
        ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'> alert('"+msg+"');</script>");
    }


}










