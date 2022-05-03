namespace AgendaDeContatos
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStripCadastros = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCadastros
            // 
            this.menuStripCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastros});
            this.menuStripCadastros.Location = new System.Drawing.Point(0, 0);
            this.menuStripCadastros.Name = "menuStripCadastros";
            this.menuStripCadastros.Size = new System.Drawing.Size(733, 24);
            this.menuStripCadastros.TabIndex = 0;
            this.menuStripCadastros.Text = "menuStrip1";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiContatos,
            this.tsmiCategorias});
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsmiCadastros.Text = "Cadastros";
            // 
            // tsmiContatos
            // 
            this.tsmiContatos.Name = "tsmiContatos";
            this.tsmiContatos.Size = new System.Drawing.Size(130, 22);
            this.tsmiContatos.Text = "Contatos";
            this.tsmiContatos.Click += new System.EventHandler(this.tsmiContatos_Click);
            // 
            // tsmiCategorias
            // 
            this.tsmiCategorias.Name = "tsmiCategorias";
            this.tsmiCategorias.Size = new System.Drawing.Size(130, 22);
            this.tsmiCategorias.Text = "Categorias";
            this.tsmiCategorias.Click += new System.EventHandler(this.tsmiCategorias_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 342);
            this.Controls.Add(this.menuStripCadastros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripCadastros;
            this.Name = "FrmPrincipal";
            this.Text = "Agenda de Contatos";
            this.menuStripCadastros.ResumeLayout(false);
            this.menuStripCadastros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripCadastros;
        private ToolStripMenuItem tsmiCadastros;
        private ToolStripMenuItem tsmiContatos;
        private ToolStripMenuItem tsmiCategorias;
    }
}