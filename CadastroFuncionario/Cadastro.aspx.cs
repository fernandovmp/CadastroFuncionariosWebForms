using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Data;
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
            try
            {
                Funcionario dadosPessoais = formularioDadosFuncionario.ObterDadosPessoais();
                Endereco endereco = formularioEndereco.ObterEndereco();
                Funcao funcao = formularioDadosFuncao.ObterDadosFuncao();
                string ctps = formularioDadosFuncao.ObterCtps();
                dadosPessoais.Endereco = endereco;
                dadosPessoais.Funcao = funcao;
                dadosPessoais.Ctps = ctps;
                using (ContextoFuncionario db = new ContextoFuncionario())
                {
                    bool jaCadastrdado = db.Funcionarios.FirstOrDefault(funcionario => funcionario.Cpf == dadosPessoais.Cpf) != null;
                    if(jaCadastrdado)
                    {
                        return;
                    }
                    db.Funcionarios.Add(dadosPessoais);
                    db.SaveChanges();
                }
            }
            catch (ExcecaoFormularioInvalido excecao)
            {
                popup.Exibir(excecao.Message);
            }
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