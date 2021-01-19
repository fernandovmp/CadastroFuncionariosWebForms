<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Popup.ascx.cs" Inherits="CadastroFuncionario.Componentes.Popup" %>
<asp:Panel runat="server" ID="popupPanel" CssClass="popup-panel" Visible="false" 
    BackColor="#FAFAFA" BorderStyle="Solid" BorderWidth="1px">
    <p><%: Mensagem %></p>
    <div class="text-right popup-button-container">
        <asp:Button runat="server" ID="btnOk" CssClass="btn btn-info popup-ok-button" Text="OK" OnClick="btnOk_Click"/>
    </div>
</asp:Panel>