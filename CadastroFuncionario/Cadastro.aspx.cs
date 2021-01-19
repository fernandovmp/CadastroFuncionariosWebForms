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
                txtRua.MaxLength = Endereco.TamanhoMaximoRua;
                txtEstado.MaxLength = Endereco.TamanhoMaximoEstado;
                txtCidade.MaxLength = Endereco.TamanhoMaximoCidade;
                txtBairro.MaxLength = Endereco.TamanhoMaximoBairro;
                txtCargo.MaxLength = Funcao.TamanhoMaximoCargo;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario dadosPessoais = formularioDadosFuncionario.ObterDadosPessoais();
            Endereco endereco = ObterEndereco();
            Funcao funcao = ObterDadosFuncao();
        }

        private Endereco ObterEndereco()
        {
            bool faltaCamposObrigatorios = this.VerificarSeFaltamCamposObrigatorios(txtCep, txtRua, txtBairro, txtCidade, txtEstado);
            if (faltaCamposObrigatorios)
            {
                return null;
            }
            string cepSemMascara = txtCep.Text.Replace("-", "");
            long cep;
            if (!long.TryParse(cepSemMascara, out cep))
            {
                txtCep.BorderColor = Color.Red;
                return null;
            }
            int numero;
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                txtNumero.BorderColor = Color.Red;
                return null;
            }
            return new Endereco
            {
                Bairro = txtBairro.Text,
                Cep = cep,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Numero = numero,
                Rua = txtRua.Text
            };
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
            this.LimparControlesDeTexto(txtCep, txtRua,
                txtNumero, txtBairro, txtCidade, txtEstado,
                txtCargo, txtDataAdimissao, txtCtps);
        }
    }
}