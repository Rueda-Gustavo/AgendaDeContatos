using AgendaDeContatos.Core.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace AgendaDeContatos.Core
{
    public class SqlConnectionFactory : IConnectionFactory
    {        
        public string ConnectionString { get { return _connectionString; } }

        private readonly string _connectionString;

        public SqlConnectionFactory()
        {
            _connectionString = "Data Source=Localhost;Database=MeusContatos; User ID=sa;Password=1234@teste;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
                       
        public IDbConnection ObterConexao()
        {
            SqlConnection conexao = new (ConnectionString);
            conexao.Open();
            return conexao;
        }
    }
}
