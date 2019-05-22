<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>

    <script src="https://code.jquery.com/jquery-3.1.1.js"></script>

    <script src="js/bootstrap.min.js"></script>

    <link href="css/bootstrap.css" rel="stylesheet" />
    
 
</head>
<body>
    <div class="jumbotron text-center" >  
        <a href="Default.aspx">  <img src="Pictures/logo2.png" width="70" height="70" alt="" /> </a>

     <h2 class="text-info"  > LISTA DE RAMAIS</h2>
        </div>



    <form id="form1" runat="server">
     <div class="container ">
        
         <ul class="nav">
             <li class="nav-item">
     <asp:TextBox ID="txtBusca" runat="server" CssClass=" form-control mr-2-sm-2" placeholder="Pesquisar" Height="30px"   />
       </li>
          
                <li class="nav-item">
            <asp:Button ID="Button1" runat="server" Text="Pesquisar" OnClick="Button1_Click" CssClass="btn btn-info" Height="30px"    />
                    </li>

                     
             <li class="nav-item">

                       <asp:Button ID="BtnRedirect" runat="server" Text="Adicionar" OnClick="BtnRedirect_Click"  CssClass="btn btn-primary" Height="30px" Width="99px"  />
             </li>

              <li class="nav-item">

                       <input type="button" name="imprimir" value="Imprimir" onclick="window.print();" class="btn btn-secondary"   />
                          </li>   


             </ul> 
       
   

            </div> 

        <asp:GridView ID="GridViewli" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  CssClass="table table-bordered" OnSelectedIndexChanged="GridView_SelectedIndexChanged" DataKeyNames="Code" AutoGenerateColumns="False">

            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Selecionar" ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-primary"  >
<ControlStyle CssClass="btn btn-outline-primary"></ControlStyle>
                </asp:CommandField>
                <asp:BoundField DataField="nome" HeaderText="Nome" />
                <asp:BoundField DataField="ramal" HeaderText="Ramal" />
                <asp:BoundField DataField="departamento" HeaderText="Departamento" />
                <asp:BoundField DataField="torre" HeaderText="Torre" />
                <asp:BoundField DataField="email" HeaderText="E-mail" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
           
     
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

  

    </form>
</body>
</html>
