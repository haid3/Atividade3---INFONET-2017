using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeA, nomeB;
            Console.WriteLine("Informe o Nome:");
            nomeA = Console.ReadLine();
            Console.WriteLine("Informe o Ano do Nascimento de " + nomeA + ":");
            int anoNascA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o outro Nome:");
            nomeB = Console.ReadLine();
            Console.WriteLine("Informe o Ano do Nascimento de " + nomeB + ":");
            int anoNascB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Ano Atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            int idadeA, idadeB, difIdade;
            idadeA = anoAtual - anoNascA;
            idadeB = anoAtual - anoNascB;
            if (idadeA > idadeB)
            {
                difIdade = idadeA - idadeB;
            }
            else
            {
                difIdade = idadeB - idadeA;

            }
            Console.WriteLine("A idade de: " + nomeA + " é: " + idadeA);
            Console.WriteLine("A idade de: " + nomeB + " é: " + idadeB);
            Console.WriteLine("A diferença de idade entre os dois é: " + difIdade + " anos");
            Console.Read();
        }
    }
}
