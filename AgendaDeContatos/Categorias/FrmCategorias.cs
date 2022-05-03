using AgendaDeContatos.Core;
using AgendaDeContatos.Core.Interfaces;
using AgendaDeContatos.Infra.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaDeContatos.Categorias.Models
{
    public partial class FrmCategorias : Form
    {
        private readonly IDatabaseCategoria? _categoriasDatabase;
        public FrmCategorias()
        {
            InitializeComponent();
            _categoriasDatabase = Program.ServiceProvider.GetService<IDatabaseCategoria?>();
        }
        CategoriasDatabase CategoriasDatabase = new(new SqlConnectionFactory());

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            List<Categoria> categorias;
            
            if (txtFiltroCat.Text == string.Empty)
                categorias = _categoriasDatabase.ObterLista();                        
            else            
                categorias = _categoriasDatabase.ObterLista(txtFiltroCat.Text);                           

            dgvCategorias.DataSource = categorias;

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCategoriaManutencao manutencao = new(OperacaoCadastro.Incluir, new Categoria());
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Categoria? categoria = ObterSelecionado();
            if (categoria is null)
            {
                MessageBox.Show("Selecione uma categoria no Grid!");
                return;
            }
            FrmCategoriaManutencao manutencao = new(OperacaoCadastro.Alterar, categoria);
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Categoria? categoria = ObterSelecionado();
            if (categoria is null)
            {
                MessageBox.Show("Selecione uma categoria no Grid!");
                return;
            }
            FrmCategoriaManutencao manutencao = new(OperacaoCadastro.Excluir, categoria);
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            Categoria? categoria = ObterSelecionado();
            if (categoria is null)
            {
                MessageBox.Show("Selecione uma categoria no Grid!");
                return;
            }
            FrmCategoriaManutencao manutencao = new(OperacaoCadastro.Consultar, categoria);
            manutencao.ShowDialog();
            btnProcurar_Click(this, e);
        }

        private Categoria? ObterSelecionado()
        {
            if (dgvCategorias.SelectedCells.Count > 0)
            {
                int indice = dgvCategorias.SelectedCells[0].RowIndex;
                /*
                Categoria categoria = new();                
                categoria.Id = (int)dgvCategorias.Rows[indice].Cells[0].Value;
                categoria.Descricao = dgvCategorias.Rows[indice].Cells[1].Value.ToString();
                return categoria;
                */
                return dgvCategorias.Rows[indice].DataBoundItem as Categoria;
            }
            else if (dgvCategorias.SelectedRows.Count == 0)
                return null;
            return dgvCategorias.SelectedRows[0]?.DataBoundItem as Categoria;
        }

        private void FrmCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
