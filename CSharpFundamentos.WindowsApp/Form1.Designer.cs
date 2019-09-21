namespace CSharpFundamentos.WindowsApp
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
            this.lbNomeForm = new System.Windows.Forms.Label();
            this.dgListaUsuarios = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeForm
            // 
            this.lbNomeForm.AutoSize = true;
            this.lbNomeForm.Location = new System.Drawing.Point(18, 14);
            this.lbNomeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeForm.Name = "lbNomeForm";
            this.lbNomeForm.Size = new System.Drawing.Size(72, 20);
            this.lbNomeForm.TabIndex = 0;
            this.lbNomeForm.Text = "Usuarios";
            // 
            // dgListaUsuarios
            // 
            this.dgListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colSenha,
            this.colEditar,
            this.colExcluir});
            this.dgListaUsuarios.Location = new System.Drawing.Point(22, 303);
            this.dgListaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgListaUsuarios.Name = "dgListaUsuarios";
            this.dgListaUsuarios.RowHeadersWidth = 62;
            this.dgListaUsuarios.Size = new System.Drawing.Size(1137, 303);
            this.dgListaUsuarios.TabIndex = 1;
            this.dgListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListaUsuarios_CellContentClick);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(192, 55);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(59, 20);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome :";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(196, 114);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(64, 20);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha :";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(272, 45);
            this.txbNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(234, 26);
            this.txbNome.TabIndex = 4;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(272, 103);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(234, 26);
            this.txbSenha.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(272, 169);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Criar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(394, 169);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.Width = 150;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 8;
            this.colNome.Name = "colNome";
            this.colNome.Width = 150;
            // 
            // colSenha
            // 
            this.colSenha.HeaderText = "Senha";
            this.colSenha.MinimumWidth = 8;
            this.colSenha.Name = "colSenha";
            this.colSenha.Width = 150;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.MinimumWidth = 8;
            this.colEditar.Name = "colEditar";
            this.colEditar.Width = 150;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.MinimumWidth = 8;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.dgListaUsuarios);
            this.Controls.Add(this.lbNomeForm);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeForm;
        private System.Windows.Forms.DataGridView dgListaUsuarios;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSenha;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colExcluir;
    }
}

