<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="CadastroFuncionario.Pesquisa" %>
<%@ Register TagPrefix="cad" TagName="Popup" Src="~/Componentes/Popup.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center">PESQUISA DE FUNCIONÁRIOS</h3>
    <section class="text-center">
        <label>
            CPF:
            <asp:TextBox runat="server" ID="txtCpf" ClientIDMode="Static"/>
        </label>
         <div class="text-center" style="margin-top: 30px;">
        <table class="button-group">
            <tr>
                <td>
                    <asp:Button ID="btnPesquisar" CssClass="btn btn-success" runat="server" Text="Salvar" OnClick="btnPesquisar_Click"/>
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
    <script type="text/javascript">
         jQuery(function ($) {
             $("#txtCpf").mask("999.999.999-99");
         });
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
    </section>
</asp:Content>
