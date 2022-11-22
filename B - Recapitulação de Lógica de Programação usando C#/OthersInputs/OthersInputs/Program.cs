using System.Globalization;

namespace OthersInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); //Parse Vai Converter a string para inteiro
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);// InvariantCulture Para aceitar tanto . quanto ,
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine("Digite os dados da Pessoa:");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char sexo = char.Parse(vet[1]); // Como Vet é uma string preciso converter
            int idade = int.Parse(vet[2]); // Como Vet é uma string preciso converter
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); // Como Vet é uma string preciso converter e Culture Invariante para aceitar , e .
            Console.WriteLine(name);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}