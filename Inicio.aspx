<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="proyectoweb2.Inicio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
       
<div class = "gridmenu">
<input type = "checkbox" id = "cat1" name = "cat1" value = "Bike">
    <label for = "cat2">Gaseosas</label>
<input type = "checkbox" id = "cat2" name = "cat2" value = "Bike">
    <label for = "cat2">Comestibles</label>
  <input type = "text" placeholder = "Buscar por Alias" class = "searchbox">
</div>

<table>
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
      </table>

</asp:Content>

