using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Data;
using CadastroFuncionario.Data.Factories;
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
        private readonly IContextoFuncionarioFactory _contextoFuncionarioFactory;
        private readonly ILogger _logger;
        public Cadastro(IContextoFuncionarioFactory contextoFuncionarioFactory, ILogger logger)
        {
            _contextoFuncionarioFactory = contextoFuncionarioFactory;
            _logger = logger;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            formularioEndereco.PopupComponente = popup;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
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
                Response.Redirect("~/Home.aspx");
            }
            catch (ExcecaoFormularioInvalido excecao)
            {
                popup.Exibir("Erro", excecao.Message);
            }
            catch (Exception execao)
            {
                _logger.Log(DateTime.Now, execao.ToString());
                popup.Exibir("Erro", "Oops! Ocorreu um erro durante o cadastro");
            }
        }

        private void CadastrarFuncionario(Funcionario dadosPessoais)
        {
            using (ContextoFuncionario db = _contextoFuncionarioFactory.Create())
            {
                bool jaCadastrdado = db.Funcionarios
                    .AsNoTracking()
                    .Where(funcionario => funcionario.Cpf == dadosPessoais.Cpf)
                    .Select(funcionario => funcionario.Id)
                    .FirstOrDefault() != 0;
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