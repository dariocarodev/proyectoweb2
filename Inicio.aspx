<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="proyectoweb2.Inicio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
       
<div class = "gridmenu">
<input type = "checkbox" id = "cat1" name = "cat1" value = "Gaseosa">
    <label for = "cat1">Gaseosa</label>
<input type = "checkbox" id = "cat2" name = "cat2" value = "Cerveza">
    <label for = "cat2">Cerveza</label>
    <input type = "checkbox" id = "cat3" name = "cat3" value = "Agua Saborizada">
    <label for = "cat3">Agua Saborizada</label>
      <input type = "checkbox" id = "cat4" name = "cat4" value = "Vinos">
    <label for = "cat4">Vinos</label>
     <input type = "checkbox" id = "cat5" name = "cat5" value = "Aguas">
    <label for = "cat4">Aguas</label>
    <div>
        <input type = "text" placeholder = "Buscar por Alias" class = "searchbox">
        <button type="button" class="btn btn-info"><img src="Estilos/lupa.png"/ style="width:25px; height:25px;"></button>
        <button type="button" class="btn btn-success"><img src="Estilos/suma.png"/ style="width:25px; height:25px;"></button>
        <button type="button" class="btn btn-danger"><img src="Estilos/x.png"/ style="width:25px; height:25px;"></button>
    </div>
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

