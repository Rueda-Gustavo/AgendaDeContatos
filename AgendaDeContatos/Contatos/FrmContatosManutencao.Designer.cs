namespace AgendaDeContatos.Contatos
{
    partial class FrmContatosManutencao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtNomeCont = new System.Windows.Forms.TextBox();
            this.contatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNomeCont = new System.Windows.Forms.Label();
            this.txtCodigoCont = new System.Windows.Forms.TextBox();
            this.lblCodigoCont = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.lblProfissão = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.lblNumCasa = new System.Windows.Forms.Label();
            this.pnlMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMsg
            // 
            this.pnlMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMsg.Controls.Add(this.btnNao);
            this.pnlMsg.Controls.Add(this.btnSim);
            this.pnlMsg.Controls.Add(this.lblMensagem);
            this.pnlMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMsg.Location = new System.Drawing.Point(0, 235);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(507, 60);
            this.pnlMsg.TabIndex = 9;
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(411, 18);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(72, 23);
            this.btnNao.TabIndex = 7;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(333, 18);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(72, 23);
            this.btnSim.TabIndex = 6;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensagem.Location = new System.Drawing.Point(12, 20);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(100, 17);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Confirma {0}?";
            // 
            // txtNomeCont
            // 
            this.txtNomeCont.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "Nome", true));
            this.txtNomeCont.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeCont.Location = new System.Drawing.Point(124, 25);
            this.txtNomeCont.Name = "txtNomeCont";
            this.txtNomeCont.Size = new System.Drawing.Size(352, 23);
            this.txtNomeCont.TabIndex = 8;
            // 
            // contatosBindingSource
            // 
            this.contatosBindingSource.DataSource = typeof(AgendaDeContatos.Infra.Models.Contato);
            // 
            // lblNomeCont
            // 
            this.lblNomeCont.AutoSize = true;
            this.lblNomeCont.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCont.Location = new System.Drawing.Point(124, 6);
            this.lblNomeCont.Name = "lblNomeCont";
            this.lblNomeCont.Size = new System.Drawing.Size(52, 17);
            this.lblNomeCont.TabIndex = 7;
            this.lblNomeCont.Text = "Nome:";
            // 
            // txtCodigoCont
            // 
            this.txtCodigoCont.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "Id", true));
            this.txtCodigoCont.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoCont.Location = new System.Drawing.Point(12, 25);
            this.txtCodigoCont.Name = "txtCodigoCont";
            this.txtCodigoCont.ReadOnly = true;
            this.txtCodigoCont.Size = new System.Drawing.Size(106, 23);
            this.txtCodigoCont.TabIndex = 6;
            // 
            // lblCodigoCont
            // 
            this.lblCodigoCont.AutoSize = true;
            this.lblCodigoCont.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoCont.Location = new System.Drawing.Point(12, 6);
            this.lblCodigoCont.Name = "lblCodigoCont";
            this.lblCodigoCont.Size = new System.Drawing.Size(60, 17);
            this.lblCodigoCont.TabIndex = 5;
            this.lblCodigoCont.Text = "Código:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCelular.Location = new System.Drawing.Point(12, 63);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(61, 17);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular:";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "Celular", true));
            this.mtxtCelular.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtCelular.Location = new System.Drawing.Point(13, 82);
            this.mtxtCelular.Mask = "(99) 00000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(124, 23);
            this.mtxtCelular.TabIndex = 12;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "Telefone", true));
            this.mtxtTelefone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtTelefone.Location = new System.Drawing.Point(143, 82);
            this.mtxtTelefone.Mask = "(99) 00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(124, 23);
            this.mtxtTelefone.TabIndex = 14;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(143, 63);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 17);
            this.lblTelefone.TabIndex = 13;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtProfissao
            // 
            this.txtProfissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "Profissao", true));
            this.txtProfissao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProfissao.Location = new System.Drawing.Point(273, 82);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(203, 23);
            this.txtProfissao.TabIndex = 16;
            // 
            // lblProfissão
            // 
            this.lblProfissão.AutoSize = true;
            this.lblProfissão.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfissão.Location = new System.Drawing.Point(273, 63);
            this.lblProfissão.Name = "lblProfissão";
            this.lblProfissão.Size = new System.Drawing.Size(73, 17);
            this.lblProfissão.TabIndex = 15;
            this.lblProfissão.Text = "Profissão:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "Email", true));
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(12, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 23);
            this.txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(13, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.Location = new System.Drawing.Point(307, 119);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 17);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contatosBindingSource, "IdCategoria", true));
            this.cbCategoria.DataSource = this.categoriasBindingSource;
            this.cbCategoria.DisplayMember = "Descricao";
            this.cbCategoria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(307, 138);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(169, 24);
            this.cbCategoria.TabIndex = 20;
            this.cbCategoria.ValueMember = "Id";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(AgendaDeContatos.Infra.Models.Categoria);
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "Endereco", true));
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(13, 196);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(393, 23);
            this.txtEndereco.TabIndex = 22;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(13, 177);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(76, 17);
            this.lblEndereco.TabIndex = 21;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "NumeroCasa", true));
            this.txtNumCasa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumCasa.Location = new System.Drawing.Point(412, 196);
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(64, 23);
            this.txtNumCasa.TabIndex = 23;
            // 
            // lblNumCasa
            // 
            this.lblNumCasa.AutoSize = true;
            this.lblNumCasa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumCasa.Location = new System.Drawing.Point(412, 177);
            this.lblNumCasa.Name = "lblNumCasa";
            this.lblNumCasa.Size = new System.Drawing.Size(66, 17);
            this.lblNumCasa.TabIndex = 24;
            this.lblNumCasa.Text = "Número:";
            // 
            // FrmContatosManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 295);
            this.Controls.Add(this.lblNumCasa);
            this.Controls.Add(this.txtNumCasa);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.lblProfissão);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.txtNomeCont);
            this.Controls.Add(this.lblNomeCont);
            this.Controls.Add(this.txtCodigoCont);
            this.Controls.Add(this.lblCodigoCont);
            this.Name = "FrmContatosManutencao";
            this.Text = "Manutenção {0}";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmContatosManutencao_FormClosed);
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlMsg;
        private Button btnNao;
        private Button btnSim;
        private Label lblMensagem;
        private TextBox txtNomeCont;
        private Label lblNomeCont;
        private TextBox txtCodigoCont;
        private Label lblCodigoCont;
        private Label lblCelular;
        private MaskedTextBox mtxtCelular;
        private MaskedTextBox mtxtTelefone;
        private Label lblTelefone;
        private TextBox txtProfissao;
        private Label lblProfissão;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtNumCasa;
        private Label lblNumCasa;
        private BindingSource contatosBindingSource;
        private BindingSource categoriasBindingSource;
    }
}