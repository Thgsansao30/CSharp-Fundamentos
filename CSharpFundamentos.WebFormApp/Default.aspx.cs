using CSharpFundamentos.Dados.Repositorio;
using CSharpFundamentos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpFundamentos.WebFormApp
{
    public partial class _Default : Page
    {
        RepositorioBase<Usuario> repositorio;
        Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Usuario>();
            usuario = new Usuario();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;

            if (usuario.Id == 0)
            {
                repositorio.Inserir(usuario);
            }
            else
            {
                repositorio.Alterar(usuario);
            }
            Limpar();
        }

        private void Limpar()
        {
            txtNome.Text = String.Empty;
            txtSenha.Text = String.Empty;
            usuario = new Usuario();
            btnSalvar.Text = "Criar";
        }
    }
}