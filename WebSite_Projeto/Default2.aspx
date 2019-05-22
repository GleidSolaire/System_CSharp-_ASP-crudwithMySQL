<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

      <script src="https://code.jquery.com/jquery-3.1.1.js"></script>

    <script src="js/bootstrap.min.js"></script>

    <link href="css/bootstrap.css" rel="stylesheet" />

    <title></title>
</head>
<body>


    <form id="form1" runat="server">
   
      <div class="jumbotron text-center" >  
        <a href="Default.aspx">  <img src="Pictures/logo2.png" width="70" height="70" alt="" /> </a>

     <h2 class="text-info"  > LISTA DE RAMAIS</h2>
        
             <p class="text-info"  > Adicionar novo contato</p>
        </div>
        <div class="col-sm-5 mx mx-auto"  >
          
             <div class=" nav jumbotron w-100 h-auto">
                

        <asp:TextBox ID="txtNome" runat="server" placeholder="Nome "  CssClass=" form-control mr-2-sm-2" required=""  ></asp:TextBox>
        <asp:TextBox ID="txtRamal" runat="server"  placeholder="Ramal"  CssClass=" form-control mr-2-sm-2" required=""  ></asp:TextBox>
        <asp:TextBox ID="txtDepartamento" runat="server" placeholder="Departamento"  CssClass=" form-control mr-2-sm-2" required=""  ></asp:TextBox>
                   
        <asp:TextBox ID="txtTorre" runat="server" placeholder="Torre" CssClass=" form-control mr-2-sm-2" required=""  ></asp:TextBox>
  
        <asp:TextBox ID="txtEmail" runat="server"  placeholder="Email"  CssClass=" form-control mr-2-sm-2 " required="" pattern="[^@]+@[^@]+.[a-zA-Z]{2,6}" Height="27px" ></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success " OnClick="Button1_Click" Text="Salvar" />
            <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger " OnClick="Button1_Click1" Text="Deletar" CausesValidation="False"  OnClientClick="javascript:return confirm('Tem certeza que deseja realizar a ação?');" />
          
    
  

        <p>
            &nbsp;</p>
                </div> 
              <asp:Button ID="BtnVoltar" runat="server" CssClass=" btn btn-dark" OnClick="Button1_Click2" Text="Voltar" />
            </div> 
   





















    </form>
</body>
</html>
