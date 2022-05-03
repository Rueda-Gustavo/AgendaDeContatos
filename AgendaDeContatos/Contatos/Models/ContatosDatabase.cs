using AgendaDeContatos.Core;
using AgendaDeContatos.Core.Interfaces;
using AgendaDeContatos.Infra.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AgendaDeContatos.Contatos.Models
{
    public class ContatosDatabase : IDatabaseContato
    {
        public ContatosDatabase(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        private readonly IConnectionFactory _connectionFactory;

        private const string Select_Contato = "SELECT cont.Id, cont.Celular, cont.Telefone, cont.Nome, cont.Endereco, cont.NumeroCasa, " +
                                                     "cont.Email, cont.Profissao, cont.DataCadastro, cat.Descricao, cont.IdCategoria " +
                                              "FROM Contatos cont LEFT JOIN Categorias cat ON cont.IdCategoria = cat.Id";

        private const string Insert_Contato = "INSERT INTO Contatos (Celular, Telefone, Nome, Endereco, NumeroCasa, Email, Profissao, DataCadastro, IdCategoria) VALUES " +
                                                                  "(@Celular, @Telefone, @Nome, @Endereco, @NumeroCasa, @Email, @Profissao, @DataCadastro, @IdCategoria); " +
                                             "SELECT CAST (SCOPE_IDENTITY() as int);";

        private const string Update_Contato = "UPDATE Contatos SET Celular = @Celular,  Telefone = @Telefone, Nome = @Nome, Endereco = @Endereco, " +
                                                                 "NumeroCasa = @NumeroCasa, Email = @Email, Profissao = @Profissao, IdCategoria = @IdCategoria WHERE Id = @Id";

        private const string Delete_Contato = "DELETE FROM Contatos WHERE Id = @Id";
        private const string Obter_Identity = "SELECT IDENT_CURRENT('Contatos')";
        public List<Contato> ObterLista()
        {
            //using SqlConnection connection = SqlConnectionFactory.ObterConexao();
            using IDbConnection connection = _connectionFactory.ObterConexao();
            return connection.Query<Contato>(Select_Contato).ToList();
        }

        public List<Contato> ObterLista(string filtro)
        {
            string sql = Select_Contato + " WHERE cont.Id = @id or cont.Celular like @filtro or cont.Telefone like @filtro or cont.Nome like @filtro";
            int.TryParse(filtro, out int id);
            //using SqlConnection connection = SqlConnectionFactory.ObterConexao();
            using IDbConnection connection = _connectionFactory.ObterConexao();
            return connection.Query<Contato>(sql, new { id, filtro = $"%{filtro}%" }).ToList();
        }

        public async Task InsertContato(Contato contato)
        {
            //using SqlConnection connection = SqlConnectionFactory.ObterConexao();
            using IDbConnection connection = _connectionFactory.ObterConexao();
            int id = await connection.ExecuteScalarAsync<int>(Insert_Contato, contato);
            contato.Id = id;
        }

        public async Task UpdateContato(Contato contato)
        {
            //using SqlConnection connection = SqlConnectionFactory.ObterConexao();
            using IDbConnection connection = _connectionFactory.ObterConexao();
            await connection.ExecuteAsync(Update_Contato, contato);
        }

        public async Task DeleteContato(int idCategoria)
        {
            //using SqlConnection connection = SqlConnectionFactory.ObterConexao();
            using IDbConnection connection = _connectionFactory.ObterConexao();
            await connection.ExecuteAsync(Delete_Contato, new { Id = idCategoria });
        }

        public int? ObterIdentidade()
        {
            using IDbConnection connection = _connectionFactory.ObterConexao();
            return connection.QueryFirstOrDefault<int>(Obter_Identity);
        }

    }
}
