using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {

            int opcao = 0;
            while (opcao != 3)
            {
                MontaMenu();


                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    TelaCadastro();
                }
                else if (opcao == 2)
                {
                    TelaListaUsuario();

                }
                else if (opcao == 3)
                {
                    TelaLogin();
                }

            }

            Console.ReadLine();
        }

        
        static void MontaMenu()
        {
            Console.Clear();

            Console.WriteLine("-------Locadora-------");
            Console.WriteLine("1- Cadastro");
            Console.WriteLine("2- Listar");
            Console.WriteLine("3- login");
            Console.WriteLine("4- Sair");
            Console.WriteLine("Digite uma opção: ");
        }


        static void TelaCadastro()
        {
            Usuario uc = new Usuario();
            Console.WriteLine("------Cadastro------");
            Console.Write(" Digite o nome: ");
            uc.Nome = Console.ReadLine();
            Console.Write("Digite a Senha: ");
            uc.Senha = Console.ReadLine();
            uc.Cadastrar();
            TelaListaUsuario();
            Console.ReadLine();

        }

       
        static void TelaLogin()
        {
            Usuario uc = new Usuario();
            Console.WriteLine("-----Login-----");
            Console.Write("Usuario: ");
            uc.Nome = Console.ReadLine();
            Console.Write("Senha: ");
            uc.Senha = Console.ReadLine();

            Console.WriteLine(uc.Login());
            Console.ReadLine();


        }

        static void TelaListaUsuario()
        {
            Usuario uc = new Usuario();
            Console.WriteLine("--------Usuarios---------");
            List<Usuario> listU = uc.ListaUsuarios();
            foreach (var item in listU)
            {
                Console.WriteLine(item.Nome);
            }
            Console.ReadLine();
        }

    }
}
