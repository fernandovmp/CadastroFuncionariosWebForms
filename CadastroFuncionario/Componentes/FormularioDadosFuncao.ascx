<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormularioDadosFuncao.ascx.cs" Inherits="CadastroFuncionario.Componentes.FormularioDadosFuncao" %>
<%@ Register TagPrefix="cad" TagName="SecaoFormulario" Src="~/Componentes/SecaoFormulario.ascx" %>

<cad:SecaoFormulario ID="secaoFormulario" runat="server" Titulo="Função" OnContentInstantiate="secaoFormulario_ContentInstantiate">
    <Content>
        <table class="form-table">
            <tr>
                <td>
                    Cargo:
                </td>
                <td>
                    <asp:TextBox ID="txtCargo" runat="server" Width="300"/>
                </td>
                <td>
                    Data de Adimissão:
                </td>
                <td>
                    <asp:TextBox ID="txtDataAdimissao" ClientIDMode="Static" runat="server" Width="150" TextMode="Date" CssClass="campo-data"/>
                </td>
            </tr>
            <tr>
                <td>
                    CTPS:
                </td>
                <td>
                    <asp:TextBox ID="txtCtps" runat="server" Width="150"/>
                </td>
                <td>
                    Envio de documentos:
                </td>
                <td>
                    <div class="btn btn-primary upload-file">
                        Anexar
                        <asp:FileUpload ID="uploadDocumento" runat="server" />
                    </div>
                </td>
            </tr>
        </table>
    </Content>
</cad:SecaoFormulario>