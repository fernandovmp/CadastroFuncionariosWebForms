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
        public event EventHandler ContentInstantiate;

        protected override void CreateChildControls()
        {
            if (Content != null)
            {
                Content.InstantiateIn(contentPlaceHolder);
            }
            base.CreateChildControls();
            ContentInstantiate?.Invoke(this, new EventArgs());
        }

    }
}