using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Extensions;
using CadastroFuncionario.Models;
using System;
using System.Drawing;
using System.Web.UI;

namespace CadastroFuncionario.Componentes
{
    public partial class FormularioDadosFuncionario : UserControl
    {
        private readonly string[] _sexos = new string[] { "Feminino", "Masculino", "Indefinido" };

        protected void secaoFormulario_ContentInstantiate(object sender, EventArgs eventArgs)
        {
            if (!Page.IsPostBack)
            {
                txtNome.MaxLength = Funcionario.TamanhoMaximoNome;
                txtRg.MaxLength = Funcionario.TamanhoMaximoRg;
                txtOrgaoEmissor.MaxLength = Funcionario.TamanhoMaximoOrgaoEmissor;
                drpSexo.DataSource = _sexos;
                drpSexo.DataBind();
            }
        }

        public Funcionario ObterDadosPessoais()
        {
            bool faltaCamposObrigatorios = this.VerificarSeFaltamCamposObrigatorios(txtNome, txtDataNascimento, txtCpf,
                txtTelefone, txtRg, txtOrgaoEmissor);
            if (faltaCamposObrigatorios)
            {
                throw new ExcecaoFormularioInvalido("Preencha todos os campos obrigatórios");
            }
            string nome = txtNome.Text;
            DateTime dataNascimento;
            if (!DateTime.TryParse(txtDataNascimento.Text, out dataNascimento))
            {
                txtDataNascimento.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe uma data válida");
            }
            string telefoneSemMascara = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            long telefone;
            if (!long.TryParse(telefoneSemMascara, out telefone))
            {
                txtTelefone.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe um telefone válido");
            }
            string rg = txtRg.Text.Replace(".", "").Replace("-", "");
            string cpfSemMascara = txtCpf.Text.Replace(".", "").Replace("-", "");
            long cpf;
            if (!long.TryParse(cpfSemMascara, out cpf))
            {
                txtCpf.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe um CPF válido");
            }
            return new Funcionario
            {
                Nome = nome,
                Cpf = cpf,
                DataNascimento = dataNascimento,
                OrgaoEmissor = txtOrgaoEmissor.Text,
                Telefone = telefone,
                Rg = rg,
                Sexo = drpSexo.SelectedValue
            };
        }

        public void Limpar()
        {
            this.LimparControlesDeTexto(txtNome, txtDataNascimento, txtCpf,
                txtRg, txtOrgaoEmissor, txtTelefone);
            drpSexo.SelectedIndex = 0;
        }
    }
}