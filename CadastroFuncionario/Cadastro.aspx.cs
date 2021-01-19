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
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario dadosPessoais = formularioDadosFuncionario.ObterDadosPessoais();
            Endereco endereco = formularioEndereco.ObterEndereco();
            Funcao funcao = formularioDadosFuncao.ObterDadosFuncao();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            formularioDadosFuncionario.Limpar();
            formularioEndereco.Limpar();
            formularioDadosFuncao.Limpar();
        }
    }
}