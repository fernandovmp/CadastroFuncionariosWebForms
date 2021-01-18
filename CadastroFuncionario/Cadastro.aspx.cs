using System;
using System.Collections.Generic;
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
                drpSexo.DataSource = _sexos;
                drpSexo.DataBind();
            }
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