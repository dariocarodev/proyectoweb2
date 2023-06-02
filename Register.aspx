<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="proyectoweb2.Register" %>

<!DOCTYPE html>

<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>ABM</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="Estilos/style.css"/>
     <script src="Estilos/LoginUILogic.js"></script>
  </head>

<body>
   <div class="card text-center" id="welcome" style=" position: absolute;
                                                      top: 50%;
                                                      left: 50%;
                                                      transform: translate(-50%, -50%);
                                                      width: 29rem; box-shadow: 1px 1px 5px black;">
  <div class="card-body">
    <h5 class="card-title">Registrese</h5>
      <input type = "text" placeholder = "Usuario" class = "searchbox" style="margin-bottom: 5px;">
      <input type = "text" placeholder = "Correo" class = "searchbox" style="margin-bottom: 5px";>
      <input type = "password" id="contraseña" placeholder = "Contraseña" class = "searchbox" style="margin-bottom: 5px";>
      <input type = "password" placeholder = "Repita Contraseña" class = "searchbox" style="margin-bottom: 5px";>
      <input type="checkbox" id="ok" onclick="condiciones()">
      <label for="ok">¿Estás de acuerdo en ceder tus datos para el registro?</label>
      <input type="button" id="btnreg" class="btn btn-success" onclick="condiciones()" value="Registrame" style="display: none;">
  </div>
</div>
</body>

</html>