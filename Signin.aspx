<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="proyectoweb2.Signin" %>
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
                                                     width: 18rem; box-shadow: 1px 1px 5px black;">
  <img src="Estilos/wallmain.jpg" class="card-img-top" alt="Inicio" style="width: 287px; height:350px">
  <div class="card-body">
    <h5 class="card-title">Bienvenido</h5>
      <input type = "text" id="user" placeholder = "Usuario" class = "searchbox" style="margin-bottom: 5px;">
      <input type = "password" id="pass" placeholder = "Contraseña" class = "searchbox" style="margin-bottom: 5px;">
    <input type="button" class="btn btn-primary" onclick="validador2()" value="Iniciar" style = "margin-top: 5px" >
    <a href="Register.aspx" class="btn btn-success" style = "margin-top: 5px">Registrar</a>
  </div>
</div>
</body>

</html>
