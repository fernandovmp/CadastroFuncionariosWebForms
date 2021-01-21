<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormularioEndereco.ascx.cs" Inherits="CadastroFuncionario.Componentes.FormularioEndereco" %>
<%@ Register TagPrefix="cad" TagName="SecaoFormulario" Src="~/Componentes/SecaoFormulario.ascx" %>

<cad:SecaoFormulario ID="secaoFormulario" runat="server" Titulo="Endereço" OnContentInstantiate="secaoFormulario_ContentInstantiate">
    <Content>
        <table class="form-table">
            <tr>
                <td>
                    CEP:
                </td>
                <td>
                    <asp:TextBox ID="txtCep" runat="server" Width="100" CssClass="campo-cep"/>
                    <button runat="server" id="btnPesquisarCep" onserverclick="btnPesquisarCep_Click" style="background: none; border: none;">
                        <i runat="server" class="glyphicon glyphicon-search"/>
                    </button>
                </td>
                <td>
                    Rua:
                </td>
                <td>
                    <asp:TextBox ID="txtRua" runat="server" Width="300" />
                </td>
                <td>
                    Nº:
                </td>
                <td>
                    <asp:TextBox ID="txtNumero" runat="server" Width="60" TextMode="Number" />
                </td>
            </tr>
            <tr>
                <td>
                    Bairro:
                </td>
                <td>
                    <asp:TextBox ID="txtBairro" runat="server"/>
                </td>
                <td>
                    Cidade:
                </td>
                <td>
                    <asp:TextBox ID="txtCidade" runat="server"/>
                </td>
                <td>
                    Estado:
                </td>
                <td>
                    <asp:TextBox ID="txtEstado" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    Complemento:
                </td>
                <td>
                    <asp:TextBox ID="txtComplemento" runat="server" />
                </td>
            </tr>
        </table>
    </Content>
</cad:SecaoFormulario>