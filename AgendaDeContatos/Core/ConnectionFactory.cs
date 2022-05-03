using AgendaDeContatos.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AgendaDeContatos.Core
{
    internal class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;
        public string ConnectionString { get { return _connectionString; } }

        public ConnectionFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SqlServer");
        }
        public IDbConnection ObterConexao()
        {
            SqlConnection conexao = new (ConnectionString);
            conexao.Open();
            return conexao;
        }
    }
}
