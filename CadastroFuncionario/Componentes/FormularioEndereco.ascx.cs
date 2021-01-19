using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Extensions;
using CadastroFuncionario.Models;
using System;
using System.Drawing;
using System.Web.UI;

namespace CadastroFuncionario.Componentes
{
    public partial class FormularioEndereco : UserControl
    {
        protected void secaoFormulario_ContentInstantiate(object sender, EventArgs eventArgs)
        {
            if (!Page.IsPostBack)
            {
                txtRua.MaxLength = Endereco.TamanhoMaximoRua;
                txtEstado.MaxLength = Endereco.TamanhoMaximoEstado;
                txtCidade.MaxLength = Endereco.TamanhoMaximoCidade;
                txtBairro.MaxLength = Endereco.TamanhoMaximoBairro;
            }
        }

        public Endereco ObterEndereco()
        {
            bool faltaCamposObrigatorios = this.VerificarSeFaltamCamposObrigatorios(txtCep, txtRua, txtBairro, txtCidade, txtEstado);
            if (faltaCamposObrigatorios)
            {
                throw new ExcecaoFormularioInvalido("Preencha todos os campos obrigatórios");
            }
            string cepSemMascara = txtCep.Text.Replace("-", "");
            long cep;
            if (!long.TryParse(cepSemMascara, out cep))
            {
                txtCep.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe um CEP válido");
            }
            int numero = 0;
            if (txtNumero.Text.Length > 0 && !int.TryParse(txtNumero.Text, out numero))
            {
                txtNumero.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe um número válido");
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

        internal void Limpar()
        {
            this.LimparControlesDeTexto(txtCep, txtRua,
                txtNumero, txtBairro, txtCidade, txtEstado);
        }
    }
}