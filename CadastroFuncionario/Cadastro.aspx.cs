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
        private readonly string[] _sexos = new string[] { "Feminino", "Masculino", "Indefinido" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                txtNome.MaxLength = Funcionario.TamanhoMaximoNome;
                txtRg.MaxLength = Funcionario.TamanhoMaximoRg;
                txtCtps.MaxLength = Funcionario.TamanhoMaximoCtps;
                txtOrgaoEmissor.MaxLength = Funcionario.TamanhoMaximoOrgaoEmissor;
                txtRua.MaxLength = Endereco.TamanhoMaximoRua;
                txtEstado.MaxLength = Endereco.TamanhoMaximoEstado;
                txtCidade.MaxLength = Endereco.TamanhoMaximoCidade;
                txtBairro.MaxLength = Endereco.TamanhoMaximoBairro;
                txtCargo.MaxLength = Funcao.TamanhoMaximoCargo;
                drpSexo.DataSource = _sexos;
                drpSexo.DataBind();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario dadosPessoais = ObterDadosPessoais();
            Endereco endereco = ObterEndereco();
            Funcao funcao = ObterDadosFuncao();
        }

        private Funcionario ObterDadosPessoais()
        {
            bool faltaCamposObrigatorios = VerificarSeFaltamCamposObrigatorios(txtNome, txtDataNascimento, txtCpf, txtTelefone, txtRg, txtOrgaoEmissor);
            if(faltaCamposObrigatorios)
            {
                return null;
            }
            string nome = txtNome.Text;
            DateTime dataNascimento;
            if(!DateTime.TryParse(txtDataNascimento.Text, out dataNascimento))
            {
                txtDataNascimento.BorderColor = Color.Red;
                return null;
            }
            string telefoneSemMascara = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            long telefone;
            if (!long.TryParse(telefoneSemMascara, out telefone))
            {
                txtTelefone.BorderColor = Color.Red;
                return null;
            }
            string rg = txtRg.Text.Replace(".", "").Replace("-", "");
            string cpfSemMascara = txtCpf.Text.Replace(".", "").Replace("-", "");
            long cpf;
            if(!long.TryParse(cpfSemMascara, out cpf)) 
            {
                txtCpf.BorderColor = Color.Red;
                return null;
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

        private Endereco ObterEndereco()
        {
            bool faltaCamposObrigatorios = VerificarSeFaltamCamposObrigatorios(txtCep, txtRua, txtBairro, txtCidade, txtEstado);
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
            bool faltaCamposObrigatorios = VerificarSeFaltamCamposObrigatorios(txtCargo, txtDataAdimissao);
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

        private bool VerificarSeFaltamCamposObrigatorios(params TextBox[] textControls) {
            bool algumNaoFoiPreenchido = false;
            foreach(TextBox control in textControls)
            {
                control.Text = control.Text.Trim();
                bool naoPreenchido = string.IsNullOrEmpty(control.Text);
                if(naoPreenchido)
                {
                    control.BorderColor = Color.Red;
                }
                algumNaoFoiPreenchido = algumNaoFoiPreenchido || naoPreenchido;
            };
            return algumNaoFoiPreenchido;
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            LimparControlesDeTexto(txtNome, txtDataNascimento, txtCpf,
                txtRg, txtOrgaoEmissor, txtTelefone, txtCep, txtRua,
                txtNumero, txtBairro, txtCidade, txtEstado,
                txtCargo, txtDataAdimissao, txtCtps);
            drpSexo.SelectedIndex = 0;
        }

        private void LimparControlesDeTexto(params ITextControl[] textControls)
        {
            foreach (ITextControl control in textControls)
            {
                control.Text = "";
            }
        }
    }
}