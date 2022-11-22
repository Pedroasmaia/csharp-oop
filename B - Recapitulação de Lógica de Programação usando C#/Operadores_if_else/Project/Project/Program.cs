namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3;
            bool c2 = 4 != 5;
            bool c3 = 10 < 7;


            bool logic = c1 && c2;

            // Posso escrever também:
            bool and = 2 > 3 && 4 != 5;
            bool ambos = 2 > 3 && 4 != 5;
            bool ou = 2 > 3 || 4 != 5;
            bool reverse = !(2 == 3); // Inverte o resultado
            bool precedencia  = c1 || c2 && c3; 
            Console.WriteLine("Testes de Operadores Logicos:");
            Console.WriteLine(and); Console.WriteLine(ambos); Console.WriteLine(ou); Console.WriteLine(reverse); Console.WriteLine(precedencia);
            Console.WriteLine("Estrutua Condicionais");
            
            Console.WriteLine("Bom dia!");

            int a = 4;

            if (a > 5) //Só vai executar se for verdade
            {
                Console.WriteLine("Boa Tarde");
            }      
            Console.WriteLine("Boa Noite!");


            Console.WriteLine("Entre com um numero inteiro:");

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else // Só é executado se for falso
            {
                Console.WriteLine("Impar!");
            }

            Console.WriteLine("Qual a hora atual? ");
            int hour = int.Parse(Console.ReadLine());
            if (hour < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hour < 18) 
            {
                Console.WriteLine("Boa Tarde!");
            }
            else if (hour <= 24) {
                Console.WriteLine("Boa Noite");
            }
            else
            {
                Console.WriteLine("Insira um valor entre 0 e 24");
            }

        

        }
    }
}