using AgendaDeContatos.Infra.Models;

namespace AgendaDeContatos.Core.Interfaces
{
    public interface IDatabaseContato
    {
        List<Contato> ObterLista();

        List<Contato> ObterLista(string filtro);

        Task InsertContato(Contato contato);

        Task UpdateContato(Contato contato);

        Task DeleteContato(int id);

        int? ObterIdentidade();

    }
}
