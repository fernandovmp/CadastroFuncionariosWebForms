# Cadastro de Funcionários

> Projeto de cadastro de funcionários em ASP.NET WebForms

## Configurações

No web.config deve-se alterar no AppSettings a chave `CaminhoDocumentosAnexados` para o valor que melhor se adequar para salvar os arquivos que serão anexados.

É usado como banco de dados o SQL Server LocalDB, o entity framework criará o arquivo na primeira execução no local especificado na connection string que está no web.config

## Estrutura

- CadastroFuncionarios
    Projeto WEB contendo as páginas, componentes, configuração do entity e regras.
- CadastroFuncionarios.Logger
    Projeto com a interface ILogger e classe que a implementa para armazernar logs em um arquivo texto
- CadastroFuncionarios.CepModulo
    Projeto com a interface ICepServico que define como obter os dados de um CEP e uma classe que implementa essa interface buscando os dados através da [Brasil API](https://github.com/BrasilAPI/BrasilAPI)
- CadastroFuncionarios.Testes
    Projeto com testes de unidade apenas para a validação de CPF definida no projeto CadastroFuncionarios