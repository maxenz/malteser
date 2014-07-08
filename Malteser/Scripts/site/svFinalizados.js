/**** SERVICIOS FINALIZADOS ****/

// --> VARIABLES PARA SERVICIOS FINALIZADOS

// --> Filtro de fecha de servicios finalizados
$("#dtServFinalizados").jqxDateTimeInput({ width: '100%', height: '25px', theme: 'bootstrap', culture: 'es-AR', selectionMode: 'range' });

// --> Seteo las columnas para la grilla de servicios finalizados
var colGridFinalizados = [
                        { text: 'ID', datafield: 'ID', hidden: true },
                        { text: 'Fecha', datafield: 'FechaInc', width: '5%' },
                        { text: 'Inc', datafield: 'NroInc', width: '5%', cellsalign: 'center' },
                        { text: 'Interno', datafield: 'NroInterno', width: '5%', cellsalign: 'center' },
                        { text: 'Nro. Afiliado', datafield: 'NroAfiliado', width: '8%', cellsalign: 'center' },
                        { text: 'Paciente', datafield: 'Paciente', width: '15%' },
                        { text: 'Domicilio', datafield: 'Domicilio', width: '17%' },
                        { text: 'Loc', datafield: 'Localidad', width: '10%' },
                        { text: 'Síntoma', datafield: 'Sintomas', width: '15%' },
                        { text: 'Grado', datafield: 'Grado', width: '5%', cellsalign: 'center' },
                        { text: 'Cierre', datafield: 'Cierre', width: '10%' },
                        { text: 'Final', datafield: 'Final', width: '5%', cellsalign: 'center' }
];

// --> Seteo los datafields para la grilla de servicios finalizados
var dtFieldsFinalizados = [{ name: 'ID', type: 'number' }, { name: 'FechaInc', type: 'string' },
                        { name: 'NroInc', type: 'string' }, { name: 'NroInterno', type: 'string' },
                        { name: 'NroAfiliado', type: 'string' }, { name: 'Paciente', type: 'string' },
                        { name: 'Domicilio', type: 'string' }, { name: 'Localidad', type: 'string' },
                        { name: 'Sintomas', type: 'string' },  { name: 'Grado', type: 'string' },
                        { name: 'Cierre', type: 'string' }, { name: 'Final', type: 'string' }];

// --> FUNCIONES PARA SERVICIOS FINALIZADOS

// --> Obtengo via ajax los datos de la grilla de servicios finalizados
function getSourceGrdFinalizados() {
    var objDatetime = $('#dtServFinalizados');
    var fd = getRangoFechas(0, objDatetime);
    var fh = getRangoFechas(1, objDatetime);

    var src = {
        datatype: "json",
        datafields: dtFieldsFinalizados,
        url: 'Operativa/getFinalizados',
        data:
            {
                fecDesde: fd,
                fecHasta: fh
            }
    };

    var dt = new $.jqx.dataAdapter(src);

    return dt;
}

function getRangoFechas(idx, objDateTime) {
    var jsDate = objDateTime.jqxDateTimeInput('getText');
    var vDate = jsDate.split("-");
    var dateCalculate = vDate[idx].trim();
    var vMesAnioDia = dateCalculate.split("/");
    return vMesAnioDia[2] + '-' + vMesAnioDia[1] + '-' + vMesAnioDia[0];

}


/**** TERMINA SERVICIOS FINALIZADOS ****/

function setValuesGrid(objGrid, src, columnas) {

    objGrid.jqxGrid(
        {
            width: '100%',
            autoheight: true,
            source: src,
            pageable: true,
            pagesize: 15,
            altrows: true,
            theme: 'arctic',
            columns: columnas,
            pagesizeoptions: ['15']
        });

}

$('#exportarAExcel').click(function () {

    $("#grdServFinalizados").jqxGrid('exportdata', 'xls', 'servicios_finalizados');

});

$('#dtServFinalizados').on('valuechanged', function (event) {

    $('#grdServFinalizados').jqxGrid({ source: getSourceGrdFinalizados() });

    //refrescar source de grilla de servicios finalizados  
});

// --> EJECUTO CUANDO INICIO

// --> Seteo la grilla de servicios en curso con el source, columnas y datafields

setValuesGrid($('#grdServFinalizados'),
              getSourceGrdFinalizados(),
              colGridFinalizados);



