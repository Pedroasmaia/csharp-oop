using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome e sobrenome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int room = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual preço da sua ultima compra: ");
            double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha e espaçados)");
            string[] infos = Console.ReadLine().Split(' ');
            string LastName = infos[0];
            int Age = int.Parse(infos[1]);
            double height = double.Parse(infos[2],CultureInfo.InvariantCulture);
            Console.WriteLine(name);
            Console.WriteLine(room);
            Console.WriteLine(price);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
            Console.WriteLine(height);


        }
    }
}