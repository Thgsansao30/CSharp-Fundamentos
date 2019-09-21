namespace CSharpFundamentos.WindowsApp
{
    partial class PessoaJuridicaForm
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
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.dgPj = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCnpj = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPj)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(205, 99);
            this.dtNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(321, 26);
            this.dtNascimento.TabIndex = 0;
            // 
            // dgPj
            // 
            this.dgPj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPj.Location = new System.Drawing.Point(118, 244);
            this.dgPj.Name = "dgPj";
            this.dgPj.RowHeadersWidth = 62;
            this.dgPj.RowTemplate.Height = 28;
            this.dgPj.Size = new System.Drawing.Size(1010, 311);
            this.dgPj.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(114, 64);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(63, 20);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome : ";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Location = new System.Drawing.Point(114, 104);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(71, 20);
            this.lbNascimento.TabIndex = 3;
            this.lbNascimento.Text = "Criação :";
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(114, 140);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(61, 20);
            this.lbCnpj.TabIndex = 4;
            this.lbCnpj.Text = "CNPJ : ";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(205, 58);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(321, 26);
            this.txbNome.TabIndex = 5;
            // 
            // txbCnpj
            // 
            this.txbCnpj.Location = new System.Drawing.Point(205, 137);
            this.txbCnpj.Name = "txbCnpj";
            this.txbCnpj.Size = new System.Drawing.Size(321, 26);
            this.txbCnpj.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(205, 183);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 30);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(354, 183);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(111, 30);
            this.bntLimpar.TabIndex = 8;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.BntLimpar_Click);
            // 
            // PessoaJuridicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbCnpj);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.dgPj);
            this.Controls.Add(this.dtNascimento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PessoaJuridicaForm";
            this.Text = "PessoaJuridica";
            ((System.ComponentModel.ISupportInitialize)(this.dgPj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.DataGridView dgPj;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCnpj;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button bntLimpar;
    }
}