using CadastroFuncionario.Extensions;
using CadastroFuncionario.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroFuncionario
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                txtCtps.MaxLength = Funcionario.TamanhoMaximoCtps;
                txtCargo.MaxLength = Funcao.TamanhoMaximoCargo;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario dadosPessoais = formularioDadosFuncionario.ObterDadosPessoais();
            Endereco endereco = formularioEndereco.ObterEndereco();
            Funcao funcao = ObterDadosFuncao();
        }

        private Funcao ObterDadosFuncao()
        {
            bool faltaCamposObrigatorios = this.VerificarSeFaltamCamposObrigatorios(txtCargo, txtDataAdimissao);
            if (faltaCamposObrigatorios)
            {
                return null;
            }
            DateTime dataAdimissao;
            if (!DateTime.TryParse(txtDataAdimissao.Text, out dataAdimissao))
            {
                txtDataAdimissao.BorderColor = Color.Red;
                return null;
            }
            return new Funcao
            {
                Cargo = txtCargo.Text,
                DataAdimissao = dataAdimissao
            };
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            formularioDadosFuncionario.Limpar();
            formularioEndereco.Limpar();
            this.LimparControlesDeTexto(txtCargo, txtDataAdimissao, txtCtps);
        }
    }
}