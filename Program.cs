using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double salario;

            Console.Write("Digite seu Salário (R$)..: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double salario1;
            double salariores;

            salario1 = (8 * salario);
            salariores = salario1 / 100;

            Console.Write($"FGTS: R$ {salariores}");
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para Finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
