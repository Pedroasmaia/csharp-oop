namespace Estrutura_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            //For (Executa a 1° vez;Condição; Executa toda vez que reinicia)
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Valor #{i}:");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}