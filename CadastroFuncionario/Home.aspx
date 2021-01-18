<%@ Page Title="Página Inicial" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CadastroFuncionario.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server" class="text-center" style="margin: 20px 120px;">
        <h1>Empresa XPTO</h1>
        <h3><%: Page.Title %></h3>
        <table style="display: inline;">
            <tr>
                <td>
                    <a class="btn btn-primary" href="~/Cadastro.aspx" runat="server">
                        <i class="glyphicon glyphicon-arrow-left glyphicon-white"></i> Cadastro
                    </a>
                </td>
                <td style="width: 200px;"/>
                <td>
                    <a class="btn color-gray" href="~/Pesquisa.aspx" runat="server">
                        Pesquisa <i class="glyphicon glyphicon-arrow-right"></i>
                    </a>
                </td>
            </tr>
        </table>
    </div>
    <style>
        .color-gray {
            background-color:  #ccc;
        }
        .color-gray:hover {
            background-color:  #bbb;
        }
        a.btn.color-gray {
            color: #333333;
        }
    </style>
</asp:Content>
