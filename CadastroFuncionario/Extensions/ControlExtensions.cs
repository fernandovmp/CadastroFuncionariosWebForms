using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroFuncionario.Extensions
{
    public static class ControlExtensions
    {
        public static void LimparControlesDeTexto(this Control control, params ITextControl[] textControls)
        {
            foreach (ITextControl textControl in textControls)
            {
                textControl.Text = "";
            }
        }

        public static bool VerificarSeFaltamCamposObrigatorios(this Control control, params TextBox[] textControls)
        {
            bool algumNaoFoiPreenchido = false;
            foreach (TextBox textBox in textControls)
            {
                textBox.Text = textBox.Text.Trim();
                bool naoPreenchido = string.IsNullOrEmpty(textBox.Text);
                if (naoPreenchido)
                {
                    textBox.BorderColor = Color.Red;
                }
                algumNaoFoiPreenchido = algumNaoFoiPreenchido || naoPreenchido;
            };
            return algumNaoFoiPreenchido;
        }
    }
}