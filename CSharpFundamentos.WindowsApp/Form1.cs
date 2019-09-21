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
    public partial class Form1 : Form
    {
        RepositorioBase<Usuario> repositorio;
        Usuario usuario;
        public Form1()
        {
            InitializeComponent();
            repositorio = new RepositorioBase<Usuario>();
            CarregaLista();
            usuario = new Usuario();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            usuario.Nome = txbNome.Text;
            usuario.Senha = txbSenha.Text;

            if (usuario.Id ==0)
            {
                repositorio.Inserir(usuario);
            }
            else
            {
                repositorio.Alterar(usuario);
            }            
            Limpar();
            CarregaLista();
        }

        private void Limpar()
        {
            txbNome.Text = String.Empty;
            txbSenha.Text = String.Empty;
            usuario = new Usuario();
            btnSalvar.Text = "Criar";
        }
        private void CarregaLista()
        {
            dgListaUsuarios.Rows.Clear();
            string[] cols = new string[3];
            foreach (var item in repositorio.ListaTodos())
            {
                cols[0] = item.Id.ToString();
                cols[1] = item.Nome;
                cols[2] = item.Senha;
                dgListaUsuarios.Rows.Add(cols);
            }
            
        }

        private void DgListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32( dgListaUsuarios.Rows[e.RowIndex].Cells[0].Value );
            if (e.ColumnIndex ==4)
            {
                Excluir(id);
            }
            else if(e.ColumnIndex ==3)
            {
                Editar(id);
            }
        }

        private void Editar(int id)
        {
            usuario = repositorio.ListarPorId(id);
            txbNome.Text = usuario.Nome;
            txbSenha.Text = usuario.Senha;
            btnSalvar.Text = "Editar";
        }

        private void Excluir(int id)
        {
            repositorio.Deletar(id);
            CarregaLista();
        }
    }
}
