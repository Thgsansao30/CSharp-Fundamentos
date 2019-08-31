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
            int n1;
            int n2;
            int resultado;

            Console.WriteLine("----Calculadora ----");

            Console.WriteLine("Digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma dos numeros é: " + (n1 + n2));

            Console.ReadLine();



        }
    }
}
