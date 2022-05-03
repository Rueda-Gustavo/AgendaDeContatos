using AgendaDeContatos.Infra.Models;

namespace AgendaDeContatos.Core.Interfaces
{
    public interface IDatabaseCategoria
    {
        List<Categoria> ObterLista();
        List<Categoria> ObterLista(string filtro);
        Task InsertCategoria(Categoria categoria);
        Task UpdateCategoria(Categoria categoria);
        Task DeleteCategoria(int idCategoria);
        int? ObterIdentidade();

    }
}
