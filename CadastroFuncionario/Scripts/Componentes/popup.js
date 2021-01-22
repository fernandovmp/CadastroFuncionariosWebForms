function exibirPopup(titulo, mensagem) {
    var popup = $('#popup');
    popup.modal();
    popup.find('#tituloPopup').text(titulo);
    popup.find('#mensagemPopup').text(mensagem);
}