using AgendaDeContatos.Contatos.Models;
using AgendaDeContatos.Core;
using AgendaDeContatos.Core.Interfaces;
using AgendaDeContatos.Infra.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaDeContatos.Contatos
{
    public partial class FrmContatos : Form
    {
        private readonly IDatabaseContato _contatosDatabase;
        //private ContatosDatabase? ContatosDatabase { get; set; }//Teste
        ContatosDatabase ContatosDatabase = new(new SqlConnectionFactory());
        public FrmContatos()
        {
            InitializeComponent();            
            _contatosDatabase = Program.ServiceProvider.GetService<IDatabaseContato>();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            List<Contato> contatos;
            if (txtFiltroCont.Text == String.Empty)
                contatos = _contatosDatabase.ObterLista();                
            else                
                contatos = _contatosDatabase.ObterLista(txtFiltroCont.Text);

            dgvContatos.DataSource = contatos;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {            
            FrmContatosManutencao manutencao = new(OperacaoCadastro.Incluir, new Contato());
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Contato? contato = ObterSelecionado();
            if(contato is null)
            {
                MessageBox.Show("Selecione um contato no Grid!");
                return;
            }

            FrmContatosManutencao manutencao = new(OperacaoCadastro.Alterar, contato);
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);   
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato? contato = ObterSelecionado();
            if (contato is null)
            {
                MessageBox.Show("Selecione um contato no Grid!");
                return;
            }
            FrmContatosManutencao manutencao = new(OperacaoCadastro.Excluir, contato);
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            Contato? contato = ObterSelecionado();
            if (contato is null)
            {
                MessageBox.Show("Selecione um contato no Grid!");
                return;
            }
            FrmContatosManutencao manutencao = new(OperacaoCadastro.Consultar, contato);
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);
        }
        
        private Contato? ObterSelecionado()
        {
            if (dgvContatos.SelectedCells.Count > 0)
            {                
                int indice = dgvContatos.SelectedCells[0].RowIndex;
                return dgvContatos.Rows[indice].DataBoundItem as Contato;
            }
            else if (dgvContatos.SelectedRows.Count == 0)
                return null;

            return dgvContatos.SelectedRows[0]?.DataBoundItem as Contato;
        }
        
        private void FrmContatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }      
    }
}
