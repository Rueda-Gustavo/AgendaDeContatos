using System.Data;

namespace AgendaDeContatos.Core.Interfaces
{
    public interface IConnectionFactory
    {
        string ConnectionString { get; }

        IDbConnection ObterConexao();
    }
}
