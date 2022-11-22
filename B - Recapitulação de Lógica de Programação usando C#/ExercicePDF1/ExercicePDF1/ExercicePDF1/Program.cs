using System.Globalization;

namespace ExercicePDF1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Exercicio 1!");
            //Console.WriteLine("Entre com o 1 número");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o 2 número");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(n1 + n2);

            //Console.WriteLine("Exercicio 2!");

            //double pi, raio;

            //pi = 3.14159;
            //Console.WriteLine("Entre com o Raio do Circulo: ");
            //raio = double.Parse(Console.ReadLine());
            //raio = Math.Pow(raio, 2);
            //double result = pi * raio;
            //Console.WriteLine($"O Resultado é {result.ToString("F4")}");


            //console.writeline("excercio 3!");

            //console.writeline("entre com 4 valores inteiros:");
            //int a = int.parse(console.readline());
            //int b = int.parse(console.readline());
            //int c = int.parse(console.readline());
            //int d = int.parse(console.readline());

            //int result = a * b - c * d;
            //console.writeline($"o resultado é {result}");

            Console.WriteLine("Exercicio 4!");
            Console.WriteLine("Qual seu registro:");
            int registry = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas foram trabalhadas:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto recebe por hora: ");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double salary = value * hours;

            Console.WriteLine($"O funcionario n° {registry} recebe R${salary.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}