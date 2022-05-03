namespace AgendaDeContatos.Categorias.Models
{
    partial class FrmCategoriaManutencao
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
            this.lblCodigoCat = new System.Windows.Forms.Label();
            this.txtCodigoCat = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescricaoCat = new System.Windows.Forms.TextBox();
            this.lblDescricaoCat = new System.Windows.Forms.Label();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.pnlMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoCat
            // 
            this.lblCodigoCat.AutoSize = true;
            this.lblCodigoCat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoCat.Location = new System.Drawing.Point(12, 12);
            this.lblCodigoCat.Name = "lblCodigoCat";
            this.lblCodigoCat.Size = new System.Drawing.Size(60, 17);
            this.lblCodigoCat.TabIndex = 0;
            this.lblCodigoCat.Text = "Código:";
            // 
            // txtCodigoCat
            // 
            this.txtCodigoCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Id", true));
            this.txtCodigoCat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoCat.Location = new System.Drawing.Point(12, 31);
            this.txtCodigoCat.Name = "txtCodigoCat";
            this.txtCodigoCat.ReadOnly = true;
            this.txtCodigoCat.Size = new System.Drawing.Size(106, 23);
            this.txtCodigoCat.TabIndex = 1;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(AgendaDeContatos.Infra.Models.Categoria);
            // 
            // txtDescricaoCat
            // 
            this.txtDescricaoCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Descricao", true));
            this.txtDescricaoCat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoCat.Location = new System.Drawing.Point(12, 94);
            this.txtDescricaoCat.Name = "txtDescricaoCat";
            this.txtDescricaoCat.Size = new System.Drawing.Size(300, 23);
            this.txtDescricaoCat.TabIndex = 3;
            // 
            // lblDescricaoCat
            // 
            this.lblDescricaoCat.AutoSize = true;
            this.lblDescricaoCat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricaoCat.Location = new System.Drawing.Point(12, 75);
            this.lblDescricaoCat.Name = "lblDescricaoCat";
            this.lblDescricaoCat.Size = new System.Drawing.Size(78, 17);
            this.lblDescricaoCat.TabIndex = 2;
            this.lblDescricaoCat.Text = "Descrição:";
            // 
            // pnlMsg
            // 
            this.pnlMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMsg.Controls.Add(this.btnNao);
            this.pnlMsg.Controls.Add(this.btnSim);
            this.pnlMsg.Controls.Add(this.lblMensagem);
            this.pnlMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMsg.Location = new System.Drawing.Point(0, 165);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(495, 60);
            this.pnlMsg.TabIndex = 4;
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
            // FrmCategoriaManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 225);
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.txtDescricaoCat);
            this.Controls.Add(this.lblDescricaoCat);
            this.Controls.Add(this.txtCodigoCat);
            this.Controls.Add(this.lblCodigoCat);
            this.Name = "FrmCategoriaManutencao";
            this.Text = "Manutenção {0}";
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCodigoCat;
        private TextBox txtCodigoCat;
        private TextBox txtDescricaoCat;
        private Label lblDescricaoCat;
        private Panel pnlMsg;
        private Label lblMensagem;
        private Button btnNao;
        private Button btnSim;
        private BindingSource categoriaBindingSource;
    }
}