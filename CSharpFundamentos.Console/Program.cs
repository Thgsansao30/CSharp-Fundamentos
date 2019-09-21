using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            int opcao = 0;
            while (opcao != 3)
            {
                MontaMenu();
                opcao = Convert.ToInt32( Console.ReadLine() );
                if (opcao == 1)
                {
                    TelaCadastro();
                }
                else if (opcao == 2)
                {
                    TelaLogin();
                }
            }
            Console.WriteLine("Saindo...");
            Console.ReadLine();
        }

        static void MontaMenu()
        {
            Console.Clear();
            Console.WriteLine("------ Locadora -------");
            Console.WriteLine("1- Cadastro");
            Console.WriteLine("2- Login");
            Console.WriteLine("3- Sair");
            Console.Write("Digite uma opção : ");
        }
        static void TelaCadastro()
        {
            Usuario uc = new Usuario();
            Console.WriteLine("------ Cadastro -------");
            Console.Write("Digite o nome: ");
            uc.Nome = Console.ReadLine();
            Console.Write("Digite o senha: ");
            uc.Senha = Console.ReadLine();
            uc.Cadastrar();
            TelaListaUsuarios();
            Console.ReadLine();
        }
        static void TelaLogin()
        {
            Usuario uc = new Usuario();
            Console.WriteLine("------ Login -------");
            Console.Write("Usuario : ");
            uc.Nome = Console.ReadLine();
            Console.Write("Senha : ");
            uc.Senha = Console.ReadLine(); 
            Console.WriteLine(uc.Login());
            Console.ReadLine();
        }
        static void TelaListaUsuarios()
        {
            Usuario uc = new Usuario();
            Console.WriteLine("------ Usuarios -------");
            List<Usuario> listaU = uc.ListaUsuarios();
            foreach (var item in listaU)
            {
                Console.WriteLine(item.Nome); 
            }
            Console.ReadLine();
        }
    }
}
