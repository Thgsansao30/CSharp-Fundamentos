using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.ConsoleApp
{
    public class Usuario
    {
        private string nome = "usuario1";
        private string senha = "senha123";
        public string Nome { get; set; }
        public string Senha { get; set; }
        
        public string Login()
        {
            string resultado;

            if ( nome == Nome && senha == Senha)
            {
                resultado = "Logado";
            }
            else
            {
                resultado = "Usuario e senha invalido!";
            }

            return resultado;
        }

        public void Cadastrar()
        {
            string arquivo = @"C:\Locadora\usuario.txt";
            StreamWriter sw = File.AppendText(arquivo);
            sw.WriteLine($"{Nome}");
            sw.Close();
        }

        public List<Usuario> ListaUsuarios()
        {
            List<Usuario> listaU = new List<Usuario>();
            Usuario uL;
            string arquivo = @"C:\Locadora\usuario.txt";
            StreamReader sr = File.OpenText(arquivo);
            while (sr.EndOfStream == false)
            {
                uL = new Usuario();
                string linha = sr.ReadLine();
                uL.Nome = linha;
                listaU.Add(uL);
            }
            sr.Close();
            return listaU;
        }
    }
}
