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
        public void Exibir(string titulo, string mensagem)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "PopupScript", $"exibirPopup('{titulo}', '{mensagem}')", true);
        }
    }
}