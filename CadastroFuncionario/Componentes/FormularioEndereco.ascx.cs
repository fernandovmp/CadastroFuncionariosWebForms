using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Extensions;
using CadastroFuncionario.Models;
using CadastroFuncionarios.CepModulo;
using System;
using System.Drawing;
using System.Web.UI;

namespace CadastroFuncionario.Componentes
{
    public partial class FormularioEndereco : UserControl
    {
        public Popup PopupComponente { get; set; }
        protected void secaoFormulario_ContentInstantiate(object sender, EventArgs eventArgs)
        {
            if (!Page.IsPostBack)
            {
                txtRua.MaxLength = Endereco.TamanhoMaximoRua;
                txtEstado.MaxLength = Endereco.TamanhoMaximoEstado;
                txtCidade.MaxLength = Endereco.TamanhoMaximoCidade;
                txtBairro.MaxLength = Endereco.TamanhoMaximoBairro;
                txtComplemento.MaxLength = Endereco.TamanhoMaximoComplemento;
            }
        }

        public Endereco ObterEndereco()
        {
            bool faltaCamposObrigatorios = this.VerificarSeFaltamCamposObrigatorios(txtCep, txtRua, txtBairro, txtCidade, txtEstado);
            if (faltaCamposObrigatorios)
            {
                throw new ExcecaoFormularioInvalido("Preencha todos os campos obrigatórios");
            }
            long cep = ObterCep();
            int? numero = null;
            int numeroInformado;
            if (txtNumero.Text.Length > 0)
            {
                if (!int.TryParse(txtNumero.Text, out numeroInformado))
                {
                    txtNumero.BorderColor = Color.Red;
                    throw new ExcecaoFormularioInvalido("Informe um número válido");
                }
                numero = numeroInformado;
            }
            return new Endereco
            {
                Bairro = txtBairro.Text,
                Cep = cep,
                Cidade = txtCidade.Text,
                Complemento = txtComplemento.Text.Trim(),
                Estado = txtEstado.Text,
                Numero = numero,
                Rua = txtRua.Text
            };
        }

        protected async void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            try
            {
                ICepServico cepServico = new BrasilApiCepServico();
                long cep = ObterCep();
                DadosEndereco endereco = await cepServico.ObterEndereco(cep);
                if(endereco == null)
                {
                    PopupComponente?.Exibir("Informe um CEP válido");
                    return;
                }
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                txtEstado.Text = endereco.Estado;
                txtRua.Text = endereco.Rua;
            }
            catch (ExcecaoFormularioInvalido execao)
            {
                PopupComponente?.Exibir(execao.Message);
            }
        }

        private long ObterCep()
        {
            string cepSemMascara = txtCep.Text.Replace("-", "");
            long cep;
            if (!long.TryParse(cepSemMascara, out cep))
            {
                txtCep.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe um CEP válido");
            }

            return cep;
        }

        internal void Limpar()
        {
            this.LimparControlesDeTexto(txtCep, txtRua,
                txtNumero, txtBairro, txtCidade, txtEstado);
        }

    }
}