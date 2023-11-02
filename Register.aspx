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
    <form id="form1" runat="server">
   <div class="card text-center" id="welcome" style=" position: absolute;
                                                      top: 50%;
                                                      left: 50%;
                                                      transform: translate(-50%, -50%);
                                                      width: 29rem; box-shadow: 1px 1px 5px black;">
  <div class="card-body">
    <h5 class="card-title">Registro</h5>
       <asp:TextBox ID="usuario" placeholder="Usuario" style="margin-bottom: 5px;" runat="server" ></asp:TextBox>
       <!--<<input type = "text" id="usuario" placeholder = "Usuario" class = "searchbox" style="margin-bottom: 5px;">>--> 
      <asp:TextBox ID="correo" placeholder="Correo" style="margin-bottom: 5px;" runat="server" TextMode="Email" ></asp:TextBox>
      <!--<<input type = "text" id="correo" placeholder = "Correo" class = "searchbox" style="margin-bottom: 5px";>>--> 
      <asp:TextBox ID="password" placeholder="Contraseña" TextMode="Password" style="margin-bottom: 5px;" runat="server" ></asp:TextBox>
      <!--<<input type = "password" id="contraseña" placeholder = "Contraseña" class = "searchbox" style="margin-bottom: 5px";>>--> 
      <asp:TextBox ID="password2" placeholder="Repetir Contraseña" TextMode="Password" style="margin-bottom: 5px;" runat="server" ></asp:TextBox>
          <asp:CheckBox ID="CbPass" runat="server" AutoPostBack="True" OnCheckedChanged="CbPass_CheckedChanged" style="display: block" Text="Mostrar"/>
       <asp:Button ID="BtnCancelar" runat="server" OnClick="BtnCancelar_Click" Text="Cancelar" />
      <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" />
       <!--<<input type = "password" id="contraseña2" placeholder = "Repita Contraseña" class = "searchbox" style="margin-bottom: 5px";>>--> 
      <!--<<input type="checkbox" id="ok" onclick="condiciones()">>--> 
      <br><asp:Label ID="Alert" runat="server" style="color: red; font-style: italic; font-size: small;"></asp:Label>
      <!--<<a href="Signin.aspx" class="btn btn-primary" style = "margin-top: 5px; margin-bottom: 5px;" >Volver</a>>--> 
      <!--<<input type="button" id="btnreg" class="btn btn-success" onclick="validador()" value="Registrame" style="display: none;">>--> 

  </div>
</div>
        <p>
            &nbsp;</p>
    </form>
</body>

</html>