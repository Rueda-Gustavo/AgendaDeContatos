namespace AgendaDeContatos.Infra.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string? Celular { get; set; }
        public string? Telefone { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? NumeroCasa { get; set; }
        public string? Email { get; set; }
        public string? Profissao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Descricao { get; set; }
        public int IdCategoria { get; set; }       
        
    }
}
