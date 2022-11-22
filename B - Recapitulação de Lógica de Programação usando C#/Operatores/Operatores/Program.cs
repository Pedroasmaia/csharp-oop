// See https://aka.ms/new-console-template for more information
namespace Operatores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"Variavel a vale {a}");

            a += 2;
            Console.WriteLine($" Variavel a valia 10 agora vale {a}");

            a *= 3;
            Console.WriteLine($" Variavel a valia 12 agora vale {a}");

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);
        
           int b = 10;
            b++;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);
        }

    }
}
