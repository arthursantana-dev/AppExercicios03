using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicios3
{
    internal class Program
    {

        static void BonusNotaCriterio()
        {
            Console.Write("Seu nome: ");
            string nome = Console.ReadLine().ToUpper();

            Console.Write("Possui Afrodescendência? (S/N)");
            string stringEhAfrodescendente = Console.ReadLine().ToUpper();

            Console.Write("Renda per capita: ");
            double stringTemBaixaRenda = double.Parse(Console.ReadLine());

            Console.Write("Possui Escolaridade Pública? (S/N)");
            string stringTemEscolaridadePublica = Console.ReadLine().ToUpper();

            if (stringEhAfrodescendente == "S" || stringTemBaixaRenda <= 2 || stringTemEscolaridadePublica == "S") {

                Console.WriteLine("Pontuação Extra Adquirida");

            } else
            {
                Console.WriteLine("Pontuação Extra Rejeitada");
            }

        }

        static void AvaliacaoMediaPresenca()
        {
            //string nome = Console.ReadLine();

            double media = double.Parse(Console.ReadLine());
            float presenca = float.Parse(Console.ReadLine());
            
            if ((media < 4) || (media < 4 && presenca < 75))
            {
                Console.WriteLine("Retido");
            } else if ((media <= 7 && presenca >= 75) || (media >= 7 && presenca < 75))
            {
                Console.WriteLine("Recuperação");
            } else if (media >= 7 && presenca >= 75)
            {
                Console.WriteLine("Aprovado");
            }
        }
        static void Main(string[] args)
        {

            //BonusNotaCriterio();
            

            while (true)
            {
                AvaliacaoMediaPresenca();
            }
            Console.ReadLine();
        }
    }
}
