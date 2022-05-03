using AgendaDeContatos.Infra.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AgendaDeContatos.Infra
{
    public class AgendaDeContatosContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
           /* 
            
            */
                optionsBuilder.UseSqlServer(
                @"Data Source=localhost,2433; Database=MeusContatos;Persist Security Info=True;User ID=sa;Password=1234@teste");
        }

        
    }
}
