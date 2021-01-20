<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Popup.ascx.cs" Inherits="CadastroFuncionario.Componentes.Popup" %>
<asp:Panel runat="server" ID="popupPanel" CssClass="popup-panel" Visible="false">
    <div class="popup-button-container">
        <h4><%: Titulo %></h4>
        <p><%: Mensagem %></p>
        <div class="text-right">
            <asp:Button runat="server" ID="btnOk" CssClass="btn btn-info popup-ok-button" Text="Fechar" OnClick="btnOk_Click"/>
        </div>
    </div>
</asp:Panel>