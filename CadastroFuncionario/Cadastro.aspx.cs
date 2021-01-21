using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Data;
using CadastroFuncionario.Extensions;
using CadastroFuncionario.Logger;
using CadastroFuncionario.Models;
using CadastroFuncionario.Servicos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
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
            ILogger logger = new TxtLogger();
            try
            {
                Funcionario dadosPessoais = formularioDadosFuncionario.ObterDadosPessoais();
                Endereco endereco = formularioEndereco.ObterEndereco();
                Funcao funcao = formularioDadosFuncao.ObterDadosFuncao();
                string ctps = formularioDadosFuncao.ObterCtps();
                HttpPostedFile documento = formularioDadosFuncao.ObterDocumento();
                var salvarDocumentoServico = new SalvarDocumentoAnexadoServico(documento);
                dadosPessoais.Endereco = endereco;
                dadosPessoais.Funcao = funcao;
                dadosPessoais.Ctps = ctps;
                dadosPessoais.Documento = salvarDocumentoServico.NomeDocumento;
                string raizParaSalvar = WebConfigurationManager.AppSettings["CaminhoDocumentosAnexados"];
                salvarDocumentoServico.SalvarDocumento(raizParaSalvar);
                CadastrarFuncionario(dadosPessoais);
            }
            catch (ExcecaoFormularioInvalido excecao)
            {
                popup.Exibir(excecao.Message);
            }
            catch (Exception execao)
            {
                logger.Log(DateTime.Now, execao.ToString());
                popup.Exibir("Oops! Ocorreu um erro durante o cadastro");
            }
        }

        private void CadastrarFuncionario(Funcionario dadosPessoais)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CadastroFuncionario"].ConnectionString;
            using (ContextoFuncionario db = new ContextoFuncionario(connectionString))
            {
                bool jaCadastrdado = db.Funcionarios.FirstOrDefault(funcionario => funcionario.Cpf == dadosPessoais.Cpf) != null;
                if (jaCadastrdado)
                {
                    return;
                }
                db.Funcionarios.Add(dadosPessoais);
                db.SaveChanges();
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