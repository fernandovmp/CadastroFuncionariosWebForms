using CadastroFuncionario.Extensions;
using CadastroFuncionario.Models;
using System;
using System.Drawing;
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

        public string ObterCtps() => txtCtps.Text.Trim();

        public void Limpar()
        {
            this.LimparControlesDeTexto(txtCargo, txtDataAdimissao, txtCtps);
        }
    }
}