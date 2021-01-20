jQuery(function ($) {
    $(".campo-cpf").mask("999.999.999-99");
    $(".campo-telefone").mask("(099)09999-9999");
    $(".campo-cep").mask("99999-999");
});
if (isInternetExplorer()) {
    jQuery(function ($) {
        $(".campo-data").mask("99/99/9999");
    });
}
function isInternetExplorer() {

    var ua = window.navigator.userAgent;
    var msie = ua.indexOf("MSIE ");
    return msie > 0 || navigator.userAgent.match(/Trident.*rv\:11\./);
}