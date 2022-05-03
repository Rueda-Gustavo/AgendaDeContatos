using AgendaDeContatos.Core.Interfaces;
using AgendaDeContatos.Infra;
using AgendaDeContatos.Infra.Models;
using Dapper;
using System.Data;

namespace AgendaDeContatos.Categorias.Models
{
    //Classe que realiza as operações com o banco de dados
    public class CategoriasDatabase : IDatabaseCategoria
    {
        private readonly IConnectionFactory _connectionFactory;

        public CategoriasDatabase(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        private const string Select_Categoria = "SELECT Id, Descricao FROM Categorias";
        private const string Insert_Categoria = "INSERT INTO Categorias (Descricao) VALUES (@Descricao); SELECT CAST (SCOPE_IDENTITY() as int);";
        private const string Update_Categoria = "UPDATE Categorias SET Descricao = @Descricao WHERE Id = @Id";
        private const string Delete_Categoria = "DELETE FROM Categorias WHERE Id = @Id";
        //public const string Obter_Identity = "SELECT @@IDENTITY";
        private const string Obter_Identity = "SELECT IDENT_CURRENT('Categorias')";

        public List<Categoria> ObterLista()
        {
            using (var db = new AgendaDeContatosContext())
            {
                var categoria = db.Categorias.ToList();                
                return categoria;
            }            
        }

        public List<Categoria> ObterLista(string filtro)
        {
            using (var db = new AgendaDeContatosContext())
            {
                int.TryParse(filtro, out int id);
                var categoria = db.Categorias
                                  .Where(c => c.Descricao == filtro || c.Id == id).ToList();
                return categoria;                
            }
        }

        public async Task InsertCategoria(Categoria categoria)
        {
            using IDbConnection connection = _connectionFactory.ObterConexao();
            int id = await connection.ExecuteScalarAsync<int>(Insert_Categoria, categoria);
            categoria.Id = id;
        }
        public async Task UpdateCategoria(Categoria categoria)
        {
            using IDbConnection connection = _connectionFactory.ObterConexao();
            await connection.ExecuteAsync(Update_Categoria, categoria);
        }

        public async Task DeleteCategoria(int idCategoria)
        {
            using IDbConnection connection = _connectionFactory.ObterConexao();
            await connection.ExecuteAsync(Delete_Categoria, new { Id = idCategoria });
        }

        public int? ObterIdentidade()
        {
            using IDbConnection connection = _connectionFactory.ObterConexao();
            return connection.QueryFirstOrDefault<int>(Obter_Identity);
        }


        /*
        using (var db = new AgendaDeContatosContext())
        {
            int id = 2;

            var categoria = db.Categorias
                .FirstOrDefault(c => c.Id == id);
            //.Where(cat => cat.Id == id)
            //.ToList();
        }

        using (var db = new AgendaDeContatosContext())
        {
            var categoria = new Categoria();
            categoria.Descricao = "Teste";
            db.Categorias.Add(categoria);
            db.SaveChanges();
        }

        using (var db = new AgendaDeContatosContext())
        {
            //db.Categorias.
        }
        */

    }
}
