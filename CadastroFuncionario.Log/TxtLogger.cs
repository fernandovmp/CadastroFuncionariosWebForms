using System;
using System.IO;

namespace CadastroFuncionario.Logger
{
    public class TxtLogger : ILogger
    {
        private const string LogPathRoot = @"C:\logs";
        private const string LogFile = "logs_cadastro_funcionario.txt";
        public void Log(DateTime dateTime, string message)
        {
            Directory.CreateDirectory(LogPathRoot);
            string filePath = Path.Combine(LogPathRoot, LogFile);
            File.AppendAllText(filePath, FormatLog(dateTime, message));
        }

        private string FormatLog(DateTime dateTime, string message) => $"[{dateTime:G}]: {message}{Environment.NewLine}";
    }
}
