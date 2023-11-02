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
      <form runat="server">
    <h5 class="card-title">Bienvenido</h5>
      <asp:TextBox ID="user" runat="server"  placeholder = "Usuario" style="margin-bottom: 5px;"></asp:TextBox>
          <asp:TextBox ID="password" runat="server" TextMode="Password" placeholder = "Contraseña" style="margin-bottom: 5px;"></asp:TextBox>
          <asp:CheckBox ID="CbPass" runat="server" AutoPostBack="True" OnCheckedChanged="CbPass_CheckedChanged" style="display: block" Text="Mostrar"/>
          <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />
          <asp:Button ID="BtnIniciar" runat="server" OnClick="BtnIniciar_Click" Text="Iniciar" />
    <!--<input type="button" class="btn btn-primary" onclick="validador2()" value="Iniciar" style = "margin-top: 5px" >-->
    <!--<a href="Register.aspx" class="btn btn-success" style = "margin-top: 5px">Registrar</a>>-->
          <br><asp:Label ID="Alert" runat="server" style="color: red; font-style: italic; font-size: small;"></asp:Label>
          </form>
  </div>
</div>

</body>

</html>
