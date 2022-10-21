
$(document).ready(function () {
    alert("hola")
    LlenarComboProductos();
});
function LlenarComboProductos() {
    $.ajax({
        type: "GET",
        url: "http://localhost:53613/api/TipoServicio",
        dataType: "json",
        success: function (TipoProducto) {

            LlenarComboDatos(TipoProducto, "#cboServicios");
        },
        error: function (RptaError) {
            $("#dvMensaje").html("Error: " + RptaError);
        }
    });
}