function LlenarComboDatos(DatosJSON, ComboLlenar) {
    for (var op = 0; op < DatosJSON.length; op++) {
        $(ComboLlenar).append('<option value=' + DatosJSON[op].Valor + '>' + DatosJSON[op].Texto + '</option>');
    }
}