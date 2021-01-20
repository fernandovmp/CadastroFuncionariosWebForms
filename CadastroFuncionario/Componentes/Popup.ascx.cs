using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroFuncionario.Componentes
{
    public partial class Popup : System.Web.UI.UserControl
    {
        public string Titulo { get; set; }
        public string Mensagem { get; set; }

        public void Exibir(string mensagem)
        {
            popupPanel.Visible = true;
            Mensagem = mensagem;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            popupPanel.Visible = false;
        }
    }
}