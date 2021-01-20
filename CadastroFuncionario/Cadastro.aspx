<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="CadastroFuncionario.Cadastro" %>
<%@ Register TagPrefix="cad" TagName="FormularioDadosFuncionario" Src="~/Componentes/FormularioDadosFuncionario.ascx" %>
<%@ Register TagPrefix="cad" TagName="FormularioEndereco" Src="~/Componentes/FormularioEndereco.ascx" %>
<%@ Register TagPrefix="cad" TagName="FormularioDadosFuncao" Src="~/Componentes/FormularioDadosFuncao.ascx" %>
<%@ Register TagPrefix="cad" TagName="Popup" Src="~/Componentes/Popup.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center">CADASTRO DE FUNCIONÁRIOS</h3>
    <cad:FormularioDadosFuncionario runat="server" ID="formularioDadosFuncionario"/>
    <cad:FormularioEndereco runat="server" ID="formularioEndereco" />
    <cad:FormularioDadosFuncao runat="server" ID="formularioDadosFuncao" />
    <div class="text-center" style="margin-top: 30px;">
        <table class="button-group">
            <tr>
                <td>
                    <asp:Button ID="btnSalvar" CssClass="btn btn-success" runat="server" Text="Salvar" OnClick="btnSalvar_Click"/>
                </td>
                <td>
                    <asp:Button ID="btnLimpar" CssClass="btn" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                </td>
                <td>
                    <a href="Home.aspx" class="btn btn-danger">Voltar</a>
                </td>
            </tr>
        </table>
    </div>
    <cad:Popup runat="server" ID="popup" Titulo="Erro"/>
    <style>
        body {
            padding: 0 20px;
        }
        .button-group {
            display: inline;
        }
        .button-group .btn {
            width: 100px;
        }
        .button-group tr td {
            padding: 0 8px;
        }
    </style>
</asp:Content>
