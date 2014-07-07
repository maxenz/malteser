// --> Inicializo opciones generales para el alerta que uso en vez del alert de javascript comun
Messenger().options = {
    extraClasses: 'messenger-fixed messenger-on-bottom messenger-on-right',
    theme: 'flat',
};

// --> Seteo alerta mas linda que el clasico alert. Le paso el mensaje y el tipo de alerta.
function setAlert(msg, tipoMsg) {
    Messenger().post({
        message: msg,
        type: tipoMsg,
        showCloseButton: true
    });
}

// --> Seteo tooltip de salir en boton salir, arriba a la derecha en el header
$('#navbar-top-logout').tooltip({
    title: 'Salir',
    placement: 'right'
});

// --> Seteo localization obj para traducir grillas de ingles

var localizationobj = {};
localizationobj.pagergotopagestring = "Ir a p&aacute;gina:";
localizationobj.pagershowrowsstring = "Mostrar Filas:";
localizationobj.pagerrangestring = " de ";
localizationobj.currencysymbol = "$";

















