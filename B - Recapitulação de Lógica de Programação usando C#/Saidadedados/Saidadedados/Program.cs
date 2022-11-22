using System.Globalization;

namespace Saidadedados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia!"); //Esse não quebra a linha no final
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("------------------");
            char genero = 'F';
            int idade = 32;
            double saldo = 10.52799;
            string nome = "Maria";
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2")); // F* retorna o número de casas decimais solicitados arrendondando
            Console.WriteLine(saldo.ToString("F4")); // F* retorna o número de casas decimais solicitados arrendondando
            Console.WriteLine(saldo.ToString("F2",CultureInfo.InvariantCulture)); // O InvariantCulture ele imprime desconsidera formatação do usuario.

            // PlaceHolder
            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais ",nome,idade,saldo);
            // Interpolaçao
            Console.WriteLine($"{nome} tem {idade} anos e o saldo igual a {saldo:F2} reais ");
            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e o saldo igual a "  + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais ");
        }
    }
}