﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormularioDadosFuncionario.ascx.cs" Inherits="CadastroFuncionario.Componentes.FormularioDadosFuncionario" %>
<%@ Register TagPrefix="cad" TagName="SecaoFormulario" Src="~/Componentes/SecaoFormulario.ascx" %>

<cad:SecaoFormulario ID="secaoFormulario" runat="server" Titulo="Dados Pessoais" OnContentInstantiate="secaoFormulario_ContentInstantiate">
    <Content>
        <table class="form-table">
            <tr>
                <td>
                    Nome:
                </td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="300" />
                </td>
                <td>
                    Data de Nascimento:
                </td>
                <td>
                    <asp:TextBox ID="txtDataNascimento" ClientIDMode="Static" runat="server" TextMode="Date" />
                </td>
                <td>
                    Sexo:
                </td>
                <td>
                    <asp:DropDownList ID="drpSexo" runat="server" Width="150" Height="24" />
                </td>
            </tr>
            <tr>
                <td>
                    CPF:
                </td>
                <td>
                    <asp:TextBox ID="txtCpf" ClientIDMode="Static" runat="server" Width="150" />
                </td>
                <td class="text-right">
                    Tel:
                </td>
                <td>
                    <asp:TextBox ID="txtTelefone" ClientIDMode="Static" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    RG:
                </td>
                <td>
                    <asp:TextBox ID="txtRg" runat="server" Width="150"/>
                </td>
                <td class="text-right">
                    Orgão Emissor:
                </td>
                <td>
                    <asp:TextBox ID="txtOrgaoEmissor" runat="server" />
                </td>
            </tr>
        </table>
    </Content>
</cad:SecaoFormulario>