<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="proyectoweb2.Inicio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
       
    <form id="form1" runat="server">
        
    <div class = "gridmenu">
    <asp:Label ID="Welcome" runat="server" Text="Bienvenido/a: "></asp:Label>
    <asp:Label ID="LabelUser" runat="server" Font-Underline="False" ForeColor="#FFCC00"></asp:Label>
    <asp:Button ID="BtnCerrar"  runat="server" Text="X" OnClick="BtnCerrar_Click" BackColor="#666666" ForeColor="#FFCC00" BorderStyle="None"/>
     </div>

<div class = "gridmenu">
    <asp:CheckBox ID="Alchoholicas" AutoPostBack="true" runat="server" BackColor="#666666" BorderColor="Black" BorderStyle="Dotted" ForeColor="#FFCC00" Text="Alcoholicas" OnCheckedChanged="Alchoholicas_CheckedChanged" />
     <asp:CheckBox ID="NoAlchoholicas"  AutoPostBack="true" runat="server" BackColor="#666666" BorderColor="Black" BorderStyle="Dotted" ForeColor="#FFCC00" Text="No Alcoholicas" OnCheckedChanged="NoAlchoholicas_CheckedChanged" />
    </div>

        <div class = "gridmenu">
            <asp:TextBox ID="TxtSearch" placeholder = "Buscar por nombre" runat="server"></asp:TextBox>
            <asp:Button ID="Buscar" runat="server" OnClick="Buscar_Click" Text="Buscar" BackColor="#666666" BorderStyle="None" ForeColor="#FFCC00"/>
    <asp:Button ID="BtnEliminar"  runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" BackColor="#666666" ForeColor="Red" BorderStyle="None" Height="22px"/>
            <asp:CheckBox ID="CBDili" runat="server" AutoPostBack="True" BackColor="#666666" Enabled="False" EnableViewState="False" ForeColor="#FFCC00" OnCheckedChanged="CBDili_CheckedChanged" Text="Diligenciado" />
           
    </div>

        <div class = "gridmenu">
        <asp:Label ID="LDelete" runat="server" BorderStyle="Dotted" ForeColor="#FFCC00"></asp:Label>
             </div>

        <div class = "gridmenu">
            <asp:TextBox ID="TxtNombre" placeholder = "Nombre" runat="server"></asp:TextBox>
            <asp:TextBox ID="TxtDesc" placeholder = "Descripción" runat="server" Width="185px"></asp:TextBox>
            <asp:TextBox ID="TxtCosto" placeholder = "Costo" runat="server" Width="70px" TextMode="Number"></asp:TextBox>
            <asp:TextBox ID="TxtVenta" placeholder = "Venta" runat="server" Width="70px" TextMode="Number"></asp:TextBox>
            <asp:TextBox ID="TxtStock" placeholder = "Stock" runat="server" Width="70px" TextMode="Number"></asp:TextBox>
            <asp:DropDownList ID="DropTipo" runat="server" AutoPostBack="True">
                <asp:ListItem>No Alcoholicas</asp:ListItem>
                <asp:ListItem>Alcoholicas</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TxtProve" placeholder = "Proveedor" runat="server"></asp:TextBox>
             <asp:Button ID="BtnSumar" runat="server" Text="+" OnClick="BtnSumar_Click" BackColor="#666666" ForeColor="#FFCC00" BorderStyle="None" style="height: 23px"/>
            </div>

         <asp:GridView ID="Grid" runat="server">
        </asp:GridView>

<!--<table>
        <thead>
          <tr>
            <th>Product ID</th>
            <th>Alias</th>
            <th>Categorias</th>
            <th>Stock</th>
            <th>Descripción</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>1</td>
            <td>Manaos</td>
              <td>Gaseosas</td>
            <td>20</td>
            <td>Lorem Ipsum</td>
          </tr>
          <tr>
            <td>2</td>
            <td>Coca-Cola</td>
              <td>Gaseosas</td>
            <td>12</td>
            <td>Lorem Ipsum</td>
          </tr>
          <tr>
            <td>3</td>
            <td>Cordoba Cola</td>
             <td>Gaseosas</td>
            <td>5</td>
            <td>Lorem Ipsum</td>
          </tr>
          <tr>
           <td>4</td>
           <td>Pepsi</td>
              <td>Gaseosas</td>
           <td>2</td>
           <td>Lorem Ipsum</td>
          </tr>
             <tr>
           <td>5</td>
           <td>Jorgito</td>
              <td>Comestibles</td>
           <td>10</td>
           <td>Lorem Ipsum</td>
          </tr>
        </tbody>
      </table> -->

    </form>

</asp:Content>

