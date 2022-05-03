using AgendaDeContatos.Categorias.Models;
using AgendaDeContatos.Contatos;
using AgendaDeContatos.Infra;
using AgendaDeContatos.Infra.Models;
using System.Windows.Forms;

namespace AgendaDeContatos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmiContatos_Click(object sender, EventArgs e)
        {
            abrirFrmContatos();                
        }

        private void tsmiCategorias_Click(object sender, EventArgs e)
        {
            abrirFrmCategorias();
        }
        private void Ativar(Form form)
        {
            this.ActivateMdiChild(form);
        }

        private void abrirFrmCategorias()
        {
            foreach (var form in this.MdiChildren)
            {
                if (form is FrmCategorias)
                {
                    form.Show();
                    form.Focus();   
                    Ativar(form);
                    return;
                }
            }

            FrmCategorias categoria = new ()
            {
                MdiParent = this
            };
            categoria.Show();
            Ativar(categoria);
        }

        private void abrirFrmContatos()
        {
            foreach(var form in this.MdiChildren)
            {
                if (form is FrmContatos)
                {
                    form.Show();
                    form.Focus();
                    Ativar(form);
                    return;
                }
            }

            FrmContatos contatos = new()
            {
                MdiParent = this
            };
            contatos.Show();
            Ativar(contatos);

        }
    }
}