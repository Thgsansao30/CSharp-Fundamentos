using CSharpFundamentos.Dados.Repositorio;
using CSharpFundamentos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.AplicativoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista");
            RepositorioBase<PessoaFisica> repositorio = new RepositorioBase<PessoaFisica>();
            foreach (var item in repositorio.ListaTodos())
            {
                Console.WriteLine(item.NomeCompleto + "-" + item.UsuarioId);
            }
            Console.ReadLine();
        }
    }
}
