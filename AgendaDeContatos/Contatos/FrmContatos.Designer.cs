namespace AgendaDeContatos.Contatos
{
    partial class FrmContatos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.pnlFiltroCat = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtFiltroCont = new System.Windows.Forms.TextBox();
            this.lblFiltroCont = new System.Windows.Forms.Label();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlFiltroCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetalhes);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 55);
            this.panel1.TabIndex = 6;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(255, 16);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 5;
            this.btnDetalhes.Text = "Detalhes...";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(174, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(93, 16);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 16);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // pnlFiltroCat
            // 
            this.pnlFiltroCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltroCat.Controls.Add(this.btnProcurar);
            this.pnlFiltroCat.Controls.Add(this.txtFiltroCont);
            this.pnlFiltroCat.Controls.Add(this.lblFiltroCont);
            this.pnlFiltroCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroCat.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltroCat.Name = "pnlFiltroCat";
            this.pnlFiltroCat.Size = new System.Drawing.Size(734, 66);
            this.pnlFiltroCat.TabIndex = 4;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(634, 27);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtFiltroCont
            // 
            this.txtFiltroCont.Location = new System.Drawing.Point(11, 27);
            this.txtFiltroCont.Name = "txtFiltroCont";
            this.txtFiltroCont.Size = new System.Drawing.Size(617, 23);
            this.txtFiltroCont.TabIndex = 1;
            // 
            // lblFiltroCont
            // 
            this.lblFiltroCont.AutoSize = true;
            this.lblFiltroCont.Location = new System.Drawing.Point(11, 8);
            this.lblFiltroCont.Name = "lblFiltroCont";
            this.lblFiltroCont.Size = new System.Drawing.Size(60, 15);
            this.lblFiltroCont.TabIndex = 0;
            this.lblFiltroCont.Text = "Pesquisar:";
            // 
            // dgvContatos
            // 
            this.dgvContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.celular,
            this.telefone,
            this.nome,
            this.endereco,
            this.numeroCasa,
            this.email,
            this.profissao,
            this.dataCadastro,
            this.descricao,
            this.idCategoria});
            this.dgvContatos.Location = new System.Drawing.Point(0, 67);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.RowTemplate.Height = 25;
            this.dgvContatos.Size = new System.Drawing.Size(734, 227);
            this.dgvContatos.TabIndex = 5;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Id";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 60;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "Celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "Telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "Endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.Width = 200;
            // 
            // numeroCasa
            // 
            this.numeroCasa.DataPropertyName = "NumeroCasa";
            this.numeroCasa.HeaderText = "Número";
            this.numeroCasa.Name = "numeroCasa";
            this.numeroCasa.Width = 60;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // profissao
            // 
            this.profissao.DataPropertyName = "Profissao";
            this.profissao.HeaderText = "Profissão";
            this.profissao.Name = "profissao";
            // 
            // dataCadastro
            // 
            this.dataCadastro.DataPropertyName = "DataCadastro";
            this.dataCadastro.HeaderText = "Data do Cadastro";
            this.dataCadastro.Name = "dataCadastro";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Categoria";
            this.descricao.Name = "descricao";
            this.descricao.Width = 200;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "IdCategoria";
            this.idCategoria.HeaderText = "IdCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.Visible = false;
            // 
            // FrmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFiltroCat);
            this.Controls.Add(this.dgvContatos);
            this.Name = "FrmContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contatos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmContatos_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlFiltroCat.ResumeLayout(false);
            this.pnlFiltroCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnDetalhes;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnIncluir;
        private Panel pnlFiltroCat;
        private TextBox txtFiltroCont;
        private Label lblFiltroCont;
        private DataGridView dgvContatos;
        private Button btnProcurar;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn celular;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn endereco;
        private DataGridViewTextBoxColumn numeroCasa;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn profissao;
        private DataGridViewTextBoxColumn dataCadastro;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn idCategoria;
    }
}