using AgendaDeContatos.Categorias.Models;
using AgendaDeContatos.Contatos.Models;
using AgendaDeContatos.Core;
using AgendaDeContatos.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaDeContatos
{
    internal class Program
    {
        private static IServiceCollection Services;
        public static IServiceProvider ServiceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IConfiguration configuration = SetConfigurations();
            CreateServices(configuration);

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
        }

        static IConfiguration SetConfigurations() 
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddUserSecrets<Program>()
                .Build();
        }

        static void CreateServices(IConfiguration configuration)
        {
            Services = new ServiceCollection();
            Services.AddSingleton(configuration);
            Services.AddScoped<IDatabaseCategoria, CategoriasDatabase>();
            Services.AddScoped<IDatabaseContato, ContatosDatabase>();
            Services.AddScoped<IConnectionFactory, ConnectionFactory>();
            ServiceProvider = Services.BuildServiceProvider();

        }
    }
}