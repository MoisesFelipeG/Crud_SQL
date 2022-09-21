namespace CRUD_SQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_novo = new System.Windows.Forms.ToolStripButton();
            this.btn_salvar = new System.Windows.Forms.ToolStripButton();
            this.btn_limpar = new System.Windows.Forms.ToolStripButton();
            this.btn_excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscar_id = new System.Windows.Forms.ToolStripLabel();
            this.txt_buscaid = new System.Windows.Forms.ToolStripTextBox();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_novo,
            this.btn_salvar,
            this.btn_limpar,
            this.btn_excluir,
            this.toolStripSeparator1,
            this.buscar_id,
            this.txt_buscaid,
            this.btn_buscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            this.btn_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(23, 22);
            this.btn_novo.Text = "toolStripButton1";
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(23, 22);
            this.btn_salvar.Text = "toolStripButton3";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(23, 22);
            this.btn_limpar.Text = "toolStripButton1";
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(23, 22);
            this.btn_excluir.Text = "toolStripButton2";
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buscar_id
            // 
            this.buscar_id.Name = "buscar_id";
            this.buscar_id.Size = new System.Drawing.Size(79, 22);
            this.buscar_id.Text = "Buscar Por Id:";
            // 
            // txt_buscaid
            // 
            this.txt_buscaid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_buscaid.Name = "txt_buscaid";
            this.txt_buscaid.Size = new System.Drawing.Size(100, 25);
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(23, 22);
            this.btn_buscar.Text = "toolStripButton5";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(16, 56);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(81, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(118, 56);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(570, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereco:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(16, 106);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(672, 20);
            this.txt_endereco.TabIndex = 6;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(16, 154);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(95, 20);
            this.txt_cep.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(125, 154);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(188, 20);
            this.txt_bairro.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(328, 154);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(188, 20);
            this.txt_cidade.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "UF:";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(528, 154);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(160, 20);
            this.txt_uf.TabIndex = 14;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(12, 202);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(169, 20);
            this.txt_telefone.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 234);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_limpar;
        private System.Windows.Forms.ToolStripButton btn_excluir;
        private System.Windows.Forms.ToolStripButton btn_salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel buscar_id;
        private System.Windows.Forms.ToolStripTextBox txt_buscaid;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton btn_novo;
    }
}

