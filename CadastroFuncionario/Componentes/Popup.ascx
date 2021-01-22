<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Popup.ascx.cs" Inherits="CadastroFuncionario.Componentes.Popup" %>

<div id="popup" class="modal fade" tabindex="-1" role="dialog">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
        <header class="modal-header">
            <h4 id="tituloPopup"></h4>
        </header>
        <div class="modal-body">
            <p id="mensagemPopup"></p>
        </div>
        <div class="modal-footer">
            <button data-dismiss="modal" class="btn btn-info popup-ok-button">Fechar</button>
        </div>
    </div>
  </div>
</div>