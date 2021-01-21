using System;

namespace CadastroFuncionario.Logger
{
    public interface ILogger
    {
        void Log(DateTime dateTime, string message);
    }
}