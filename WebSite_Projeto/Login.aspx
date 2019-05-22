<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <script src="js/bootstrap.min.js"></script>

    <link href="css/bootstrap.css" rel="stylesheet" />

    <link href="css/MyCSS.css" rel="stylesheet" />

    <title></title>
</head>
<body >
    <form id="form1" runat="server" >
 
 <div class="login-page">
     
    <div class="form">
     
        <asp:TextBox ID="txtLogin"    placeholder="Usuario: " CssClass=" form-control mr-2-sm-2"     runat="server"></asp:TextBox>
           
            <asp:TextBox ID="txtSenha"  TextMode="Password" placeholder="Senha: "  CssClass=" form-control mr-2-sm-2"      runat="server" ></asp:TextBox>
         
                
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn btn-outline-success"  Text="Entrar" OnAuthenticate= "ValidateUser" />
        </div>
     </div>
    </form>
</body>
    
</html>
