using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Data.Factories
{
    public class ContextoFuncionarioFactory : IContextoFuncionarioFactory
    {
        private readonly string _connectionString;

        public ContextoFuncionarioFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ContextoFuncionario Create() => new ContextoFuncionario(_connectionString);
    }
}