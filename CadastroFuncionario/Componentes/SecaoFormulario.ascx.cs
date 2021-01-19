using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroFuncionario.Componentes
{
    public partial class SecaoFormulario : System.Web.UI.UserControl
    {
        public string Titulo { get; set; }
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TemplateInstance(TemplateInstance.Single)]
        public ITemplate Content { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Content != null)
            {
                Content.InstantiateIn(contentPlaceHolder);
            }
        }

    }
}