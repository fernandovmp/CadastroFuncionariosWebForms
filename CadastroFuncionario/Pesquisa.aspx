<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="CadastroFuncionario.Pesquisa" %>
<%@ Register TagPrefix="cad" TagName="Popup" Src="~/Componentes/Popup.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center">PESQUISA DE FUNCIONÁRIOS</h3>
    <section class="text-center">
        <label>
            CPF:
            <asp:TextBox runat="server" ID="txtCpf" CssClass="campo-cpf"/>
        </label>
         <div class="text-center" style="margin-top: 30px;">
        <table class="button-group">
            <tr>
                <td>
                    <asp:Button ID="btnPesquisar" CssClass="btn btn-success" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click"/>
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
    <table runat="server" id="tabelaResultadoPesquisa" visible="false" class="table table-striped table-bordered text-left" style="margin-top: 16px;">
        <thead>
            <tr>
                <th>Nome</th>
                <th>CPF</th>
                <th>Data Nascimento</th>
                <th>Função</th>
                <th>Data Adimissão</th>
                <th>Anexos</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblNome" />
                </td>
                <td>
                    <asp:Label runat="server" ID="lblCpf" CssClass="campo-cpf"/>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblDataNascimento" />
                </td>
                <td>
                    <asp:Label runat="server" ID="lblFuncao" />
                </td>
                <td>
                    <asp:Label runat="server" ID="lblDataAdimissao" />
                </td>
                <td>
                    <asp:LinkButton runat="server" Text="Documentos" ID="btnDocumentos" OnClick="btnDocumentos_Click"/>
                </td>
            </tr>
        </tbody>
    </table>
    <asp:HiddenField ID="nomeDocumento" runat="server" />
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
    </section>
</asp:Content>
