using System.Globalization;

namespace Exercicios4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int RetornaImpares(int a)
            {
                Console.Write("Digite um número e veja a lista de números impares até chegar nele: ");
                int X = int.Parse(Console.ReadLine());
                for (int i = 0; i <= X; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }

                return X;
            }
            static string DentroOuFora(int a)
            {
            int CountIn = 0;
            int CountOut = 0;
            Console.Write("Quer colocar quantos valores:");
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Qual valor quer verificar:");
                int verification = int.Parse(Console.ReadLine());
                if (verification >= 10 && verification <= 20) { CountIn++; }
                else
                {
                    CountOut++;
                }
            }
            string console = $"{CountIn} in and {CountOut} Out ";
            return console;
            }
            static string Testes(int a)
            {
                Console.Write("Quantos testes você quer fazer:");
                int testes = int.Parse(Console.ReadLine());
                for(int i = 1; i < testes; i++)
                {
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    double z = double.Parse(Console.ReadLine());
                    double media = (z + x + y)/testes;
                    Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
                }
            return "Deu certo";
            }
            static string Divison(int a)
            {
            int entradas = int.Parse(Console.ReadLine());
            for (int i = 0; i < entradas; i++)
            {
                string[] numbers = Console.ReadLine().Split(" ");
                int dividendo = int.Parse(numbers[0]);
                int divisor = int.Parse(numbers[1]);
                if(divisor == 0)
                {
                    Console.WriteLine("Divisão Impossivel!");
                }
                else
                {
                    double resultado = (double)dividendo / divisor;
                    Console.WriteLine(resultado.ToString("F1"));
                }
                    double retorno = (double)a;
                }
                    return "deu certo";
            }
        }
    }
}