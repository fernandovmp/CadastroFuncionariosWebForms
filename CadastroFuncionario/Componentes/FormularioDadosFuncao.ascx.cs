using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Extensions;
using CadastroFuncionario.Models;
using System;
using System.Drawing;
using System.Web;
using System.Web.UI;

namespace CadastroFuncionario.Componentes
{
    public partial class FormularioDadosFuncao : UserControl
    {
        protected void secaoFormulario_ContentInstantiate(object sender, EventArgs eventArgs)
        {
            if (!Page.IsPostBack)
            {
                txtCtps.MaxLength = Funcionario.TamanhoMaximoCtps;
                txtCargo.MaxLength = Funcao.TamanhoMaximoCargo;
            }
        }

        public Funcao ObterDadosFuncao()
        {
            bool faltaCamposObrigatorios = this.VerificarSeFaltamCamposObrigatorios(txtCargo, txtDataAdimissao);
            if (faltaCamposObrigatorios)
            {
                throw new ExcecaoFormularioInvalido("Preencha todos os campos obrigatórios");
            }
            DateTime dataAdimissao;
            if (!DateTime.TryParse(txtDataAdimissao.Text, out dataAdimissao))
            {
                txtDataAdimissao.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe uma data válida");
            }
            return new Funcao
            {
                Cargo = txtCargo.Text,
                DataAdimissao = dataAdimissao
            };
        }

        public string ObterCtps() 
        {
            string ctps = txtCtps.Text.Trim();
            if(string.IsNullOrEmpty(ctps))
            {
                throw new ExcecaoFormularioInvalido("Preencha todos os campos obrigatórios");
            }
            return ctps;
        }

        public HttpPostedFile ObterDocumento()
        {
            const long TamnhoMaximoDocumento = 50 * 1048576;
            if(!uploadDocumento.HasFile)
            {
                throw new ExcecaoFormularioInvalido("Anexe um documento antes de prosseguir");
            }
            if (uploadDocumento.PostedFile.ContentLength > TamnhoMaximoDocumento)
            {
                throw new ExcecaoFormularioInvalido("O documento não deve exceder 50MB");
            }
            return uploadDocumento.PostedFile;
        }

        public void Limpar()
        {
            this.LimparControlesDeTexto(txtCargo, txtDataAdimissao, txtCtps);
        }
    }
}