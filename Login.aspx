<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="proyectoweb2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

  <div class="card text-center" id="welcome" style="width: 18rem; margin-left: auto; margin-right: auto; text-align: center; margin-top: 10px; box-shadow: 1px 1px 5px black;">
  <img src="Estilos/wallmain.jpg" class="card-img-top" alt="Inicio" style="width: 287px; height:350px">
  <div class="card-body">
    <h5 class="card-title">Bienvenido</h5>
      <input type = "text" placeholder = "Usuario" class = "searchbox" style="margin-bottom: 5px;">
      <input type = "password" placeholder = "Contraseña" class = "searchbox">
    <a href="Inicio.aspx" class="btn btn-primary" style = "margin-top: 5px;">Iniciar</a>
  </div>
</div>

</asp:Content>
