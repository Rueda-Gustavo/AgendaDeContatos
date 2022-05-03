using AgendaDeContatos.Categorias.Models;
using AgendaDeContatos.Contatos.Models;
using AgendaDeContatos.Core;
using AgendaDeContatos.Core.Interfaces;
using AgendaDeContatos.Infra.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaDeContatos.Contatos
{
    public partial class FrmContatosManutencao : Form
    {
        public readonly OperacaoCadastro _operacaoCadastro;
        private readonly IDatabaseContato? _contatosDatabase;
        protected Contato Contato { get; set; }
        
        public FrmContatosManutencao(OperacaoCadastro operacaoCadastro, Contato contato)
        {
            InitializeComponent();
            _contatosDatabase = Program.ServiceProvider.GetService<IDatabaseContato>();
            _operacaoCadastro = operacaoCadastro;
            Contato = contato;
            contatosBindingSource.DataSource = Contato;            
            InicializarDados();
        }


        private void InicializarDados()
        {
            switch (_operacaoCadastro)
            {
                case OperacaoCadastro.Incluir:
                    {
                        //int Identity = _contatosDatabase.ObterIdentidade()[0] + 1;
                        //Contato.Id = Identity;
                        //txtCodigoCont.Text = Identity.ToString();
                        Contato.DataCadastro = DateTime.Now;
                        lblMensagem.Text = string.Format(lblMensagem.Text, "Inclusão");
                        this.Text = string.Format(this.Text, " - [Inclusão de Contato]");
                    }
                    break;
                case OperacaoCadastro.Alterar:
                    {
                        lblMensagem.Text = string.Format(lblMensagem.Text, "Alteração");
                        this.Text = string.Format(this.Text, " - [Alteração de Contato]");
                    }
                    break;
                case OperacaoCadastro.Excluir:
                    {
                        lblMensagem.Text = string.Format(lblMensagem.Text, "Exclusão");
                        this.Text = string.Format(this.Text, " - [Exclusão de Contato]");
                    }
                    break;
                case OperacaoCadastro.Consultar:
                    {
                        lblMensagem.Text = string.Format(lblMensagem.Text, "Consulta");
                        this.Text = string.Format(this.Text, " - [Consultar Contato]");
                        btnSim.Enabled = false;
                        btnNao.Text = "Fechar";
                    }
                    break;
            }
        }

        private async void btnSim_Click(object sender, EventArgs e)
        {
            switch (_operacaoCadastro)
            {
                case OperacaoCadastro.Incluir:
                    //await ContatosDatabase.InsertContato(Contato);
                    await _contatosDatabase.InsertContato(Contato);
                    break;
                case OperacaoCadastro.Alterar:
                    await _contatosDatabase.UpdateContato(Contato);
                    break;
                case OperacaoCadastro.Excluir:
                    await _contatosDatabase.DeleteContato(Contato.Id);
                    break;
            }
            Close();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmContatosManutencao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
