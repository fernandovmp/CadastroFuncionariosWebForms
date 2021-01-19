using System;

namespace CadastroFuncionario.Componentes.Excecoes
{
    public class ExcecaoFormularioInvalido : Exception
    {
        public ExcecaoFormularioInvalido(string mensagem) : base(mensagem) { }
    }
}