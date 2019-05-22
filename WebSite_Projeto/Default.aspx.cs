using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;


public partial class _Default : System.Web.UI.Page
{

    /// <summary>
    /// Page_load acontece todos os eventos da pagina sem uma acao requisitada
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {




        MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=ramais; password=''"); //para abrir conexao com o banco de dados precisa
        // criar essa 'string' colocando servidor(localhost nesse caso)
        // id do usuario nome do banco e senha do mesmo


        MySqlCommand comando = new MySqlCommand("SELECT  code, nome, ramal, departamento, torre, email FROM lista ", conexao); //comando: variavel que faz a instrucao sql

          DataTable tabela = new DataTable();  //DataTable exibe a tabela buscando no banco de dados os regsitros

        MySqlDataAdapter da = new MySqlDataAdapter(comando);

        try
        {
            conexao.Open(); // abre a conexao com banco de dados
            da.Fill(tabela);


            GridViewli.DataSource = tabela; 
            GridViewli.DataBind();


        }
        finally
        {
            conexao.Close(); // fecha a conexao com o banco de dados
        }

    }

    protected void GridView1(object sender, EventArgs e)
    {

    }

    /// <summary>
    ///  todos os eventos do  botao click na pagina default o botao pesquisar
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {



        MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=ramais; password=''");
        MySqlCommand comando = new MySqlCommand("SELECT  *FROM lista where ramal LIKE @PESQUISAR or nome LIKE @PESQUISAR", conexao);

        DataTable tabela = new DataTable();
        try
        {
            conexao.Open();
            comando.Parameters.AddWithValue("PESQUISAR", "%" + txtBusca.Text + "%");
            GridViewli.DataSource = comando.ExecuteReader();
            GridViewli.DataBind();
        }




        finally
        {
            conexao.Close();
        }



    }
    /// <summary>
    /// metodo para limpar os textbox 
    /// </summary>
    /// <param name="controle"></param>

    public void LimparTextBox(Control controle)
    {
        foreach (Control ctle in controle.Controls)
        {

            if (ctle is TextBox)
            {
                ((TextBox)ctle).Text = String.Empty;
            }
            else if (ctle.Controls.Count > 0)
            {
                LimparTextBox(ctle);
            }
        }
    }





    protected void BtnRedirect_Click(object sender, EventArgs e)
    {
        Session["Code"] = "0"; //variao de sessao (tipo um cookie) que ira identificar o update ou insert, recuperando seu valor em outra pagina
        Response.Redirect("Default2.aspx"); //redireciona para a pagina que deseja


    }

    protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
    {

        Session["Code"] = GridViewli.SelectedValue; // essa session identifica qual a linha do meu grid eu to selecionando para recuparar seus valores em outra pagina
        Session["adicionar"] = "1"; // essa session serve para identificar se eu vou adicionar um novo cadastro ou se estou selecionado um para editar (vide ela na default2)

        Response.Redirect("Default2.aspx");


    }

}