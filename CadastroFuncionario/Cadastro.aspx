<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="CadastroFuncionario.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center">CADASTRO DE FUNCIONÁRIOS</h3>
    <section class="form-section">
        <h4>Dados Pessoais</h4>
        <table class="form-table">
            <tr>
                <td>
                    Nome:
                </td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="300"/>
                </td>
                <td>
                    Data de Nascimento:
                </td>
                <td>
                    <asp:TextBox ID="txtDataNascimento" runat="server" TextMode="Date" />
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
    </section>
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
                    <asp:TextBox ID="txtDataAdimissao" runat="server" Width="150" TextMode="Date"/>
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
                    <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" />
                </td>
                <td>
                    <asp:Button ID="btnLimpar" CssClass="btn" runat="server" Text="Limpar" />
                </td>
                <td>
                    <asp:Button ID="btnVoltar" CssClass="btn btn-danger" runat="server" Text="Voltar" />
                </td>
            </tr>
        </table>
    </div>
    <script type="text/javascript">
         jQuery(function ($) {
             $("#txtTelefone").mask("(099)9999-9999");
             $("#txtCep").mask("99999-999");
             $("#txtCpf").mask("999.999.999-99");
         });
    </script>   
    <style>
        .form-section h4 {
            color: #265a88;
        }
        .form-table tr td {
            padding: 6px;
        }
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
