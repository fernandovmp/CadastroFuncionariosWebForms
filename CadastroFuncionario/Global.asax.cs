using CadastroFuncionario.Data.Factories;
using CadastroFuncionario.Logger;
using CadastroFuncionarios.CepModulo;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace CadastroFuncionario
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que é executado na inicialização do aplicativo
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IUnityContainer container = this.AddUnity();
            container.RegisterType<ICepServico, BrasilApiCepServico>();
            container.RegisterSingleton<ILogger, TxtLogger>();

            string connectionString = WebConfigurationManager.ConnectionStrings["CadastroFuncionario"].ConnectionString;
            var contextoFuncionarioFactory = new ContextoFuncionarioFactory(connectionString);
            container.RegisterInstance<IContextoFuncionarioFactory>(contextoFuncionarioFactory);
        }
    }
}