<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="CadastroFuncionario.Cadastro" %>
<%@ Register TagPrefix="cad" TagName="FormularioDadosFuncionario" Src="~/Componentes/FormularioDadosFuncionario.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center">CADASTRO DE FUNCIONÁRIOS</h3>
    <cad:FormularioDadosFuncionario runat="server" ID="formularioDadosFuncionario"/>
    <section class="form-section">
        <h4>Endereço</h4>
        <table class="form-table">
            <tr>
                <td>
                    CEP:
                </td>
                <td>
                    <asp:TextBox ID="txtCep" ClientIDMode="Static" runat="server" Width="100"/>
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
        </table>
    </section>
    <section class="form-section">
        <h4>Função</h4>
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
                    <asp:TextBox ID="txtDataAdimissao" ClientIDMode="Static" runat="server" Width="150" TextMode="Date"/>
                </td>
            </tr>
            <tr>
                <td>
                    CTPS:
                </td>
                <td>
                    <asp:TextBox ID="txtCtps" runat="server" Width="150"/>
                </td>
            </tr>
        </table>
    </section>
    <div class="text-center">
        <table class="button-group">
            <tr>
                <td>
                    <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click"/>
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
    <script type="text/javascript">
         jQuery(function ($) {
             $("#txtTelefone").mask("(99)09999-9999");
             $("#txtCep").mask("99999-999");
             $("#txtCpf").mask("999.999.999-99");
         });
        if (isInternetExplorer()) {
            jQuery(function ($) {
                $("#txtDataNascimento").mask("99/99/9999");
                $("#txtDataAdimissao").mask("99/99/9999");
            });
        }
        function isInternetExplorer() {

            var ua = window.navigator.userAgent;
            var msie = ua.indexOf("MSIE ");
            return msie > 0 || navigator.userAgent.match(/Trident.*rv\:11\./);
        }
    </script>   
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
