using CSharpFundamentos.Dados.Repositorio;
using CSharpFundamentos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.WindowsApp
{
    public partial class PessoaJuridicaForm : Form
    {
        RepositorioBase<PessoaJuridica> repositorio = new RepositorioBase<PessoaJuridica>();
        public PessoaJuridicaForm()
        {
            InitializeComponent();
            CarregaLista();
        }


        private void BntLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.NomeCompleto = txbNome.Text;
            pessoaJuridica.CNPJ = txbCnpj.Text;
            pessoaJuridica.Nascimento = dtNascimento.Value;
            repositorio.Inserir(pessoaJuridica);
            CarregaLista();
            Limpar();
        }

        private void Limpar()
        {
            txbNome.Text = String.Empty;
            dtNascimento.Value = DateTime.Now;
            txbCnpj.Text = String.Empty;
        }
        private void CarregaLista()
        {
            dgPj.DataSource = repositorio.ListaTodos();
        }
    }
}
