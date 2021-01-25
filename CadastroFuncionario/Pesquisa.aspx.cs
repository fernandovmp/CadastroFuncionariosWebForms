using CadastroFuncionario.Componentes.Excecoes;
using CadastroFuncionario.Data;
using CadastroFuncionario.Data.Factories;
using CadastroFuncionario.Logger;
using CadastroFuncionario.Models;
using CadastroFuncionario.Validacoes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroFuncionario
{
    public partial class Pesquisa : Page
    {
        private readonly IContextoFuncionarioFactory _contextoFuncionarioFactory;
        private readonly ILogger _logger;

        public Pesquisa(IContextoFuncionarioFactory contextoFuncionarioFactory, ILogger logger)
        {
            _contextoFuncionarioFactory = contextoFuncionarioFactory;
            _logger = logger;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            tabelaResultadoPesquisa.Visible = false;
            try
            {
                long cpf = ObterCpf();
                string connectionString = WebConfigurationManager.ConnectionStrings["CadastroFuncionario"].ConnectionString;
                using (ContextoFuncionario db = _contextoFuncionarioFactory.Create())
                {
                    Funcionario funcionario = db.Funcionarios
                        .AsNoTracking()
                        .FirstOrDefault(func => func.Cpf == cpf);
                    if(funcionario == null)
                    {
                        popup.Exibir("Erro", "CPF não encontrado");
                        return;
                    }
                    funcionario.Funcao = db.Funcoes
                        .AsNoTracking()
                        .FirstOrDefault(func => func.FuncionarioID == funcionario.Id);
                    ExibirResultadoPesquisa(funcionario);
                }
            }
            catch (ExcecaoFormularioInvalido excecao)
            {
                popup.Exibir("Erro", excecao.Message);
            }
            catch (Exception execao)
            {
                _logger.Log(DateTime.Now, execao.ToString());
                popup.Exibir("Erro", "Oops! Ocorreu um erro durante a pesquisa");
            }
        }

        private void ExibirResultadoPesquisa(Funcionario funcionario)
        {
            tabelaResultadoPesquisa.Visible = true;
            lblNome.Text = funcionario.Nome;
            lblCpf.Text = funcionario.Cpf.ToString("D11");
            lblDataNascimento.Text = funcionario.DataNascimento.ToString("d");
            lblFuncao.Text = funcionario.Funcao.Cargo;
            lblDataAdimissao.Text = funcionario.Funcao.DataAdimissao.ToString("d");
            nomeDocumento.Value = funcionario.Documento;
        }

        private long ObterCpf()
        {
            string cpfSemMascara = txtCpf.Text.Replace(".", "").Replace("-", "");
            long cpf;
            if (!long.TryParse(cpfSemMascara, out cpf) || ValidadorCpf.NaoEhValido(cpf))
            {
                txtCpf.BorderColor = Color.Red;
                throw new ExcecaoFormularioInvalido("Informe um CPF válido");
            }
            return cpf;
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf.Text = "";
            tabelaResultadoPesquisa.Visible = false;
        }

        protected void btnDocumentos_Click(object sender, EventArgs e)
        {
            string filename = nomeDocumento.Value;
            string caminhoDocumentos = WebConfigurationManager.AppSettings["CaminhoDocumentosAnexados"];
            Response.ContentType = "Application/unknown";
            Response.AppendHeader("Content-Disposition", $"attachment; filename=${filename}");
            Response.TransmitFile(Path.Combine(caminhoDocumentos, filename));
            Response.End();
        }
    }
}