function condiciones() {

    let okstat = document.getElementById('ok')

    if (okstat.checked == true) { 
    document.getElementById('btnreg').style.display = 'block';
    document.getElementById('btnreg').style.margin = '0 auto';
    } else {
    document.getElementById('btnreg').style.display = 'none';
    }
}
function validador() {

    let usuario = document.getElementById('usuario')
    let correo = document.getElementById('correo')
    let contraseña = document.getElementById('contraseña')
    let contraseña2 = document.getElementById('contraseña2')

    if (usuario.value == "" || usuario.value == null || correo.value == "" || correo.value == null ||
        contraseña.value == "" || contraseña.value == null || contraseña2.value == "" || contraseña2.value == null) {
        alert("Ningún campo puede quedar vacio.")
    } else {
        if (contraseña.value != contraseña2.value) {
            alert("Las contraseñas no coinciden")
        } else {
            location.href = "Inicio.aspx";
        }
    }
}
function validador2() {

    let usuario = document.getElementById('user')
    let pass = document.getElementById('pass')

    if (user.value == "" || user.value == null || pass.value == "" || pass.value == null) {
        alert("Ningún campo puede quedar vacio.")
    } else {
        if (user.value == "admin" || pass.value == "admin") {
            location.href = "Inicio.aspx";
        } else {
            alert("Usuario o contraseña incorrecta.")
        }
    }
}
