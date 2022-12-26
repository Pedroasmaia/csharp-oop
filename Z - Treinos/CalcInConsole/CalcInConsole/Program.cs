namespace CalcInConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool init = true;
            Console.WriteLine("-----Calculadora VIA CMD-----");
            while (init == true)
            {
            Console.WriteLine("Escolha qual operação quer realizar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Numero Atual: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero que vai ser adicionado ao total: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"O Resultado é {soma(a,b)}");
            }
            else if(choice == 2){
                Console.WriteLine("Numero Atual: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero que vai ser subtraido ao total: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"O Resultado é {subtracao(a, b)}");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Numero Atual: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero que vai multiplicar o total: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"O Resultado é {Multiplicacao(a, b)}");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Numero Atual: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero que vai  dividir o total: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"O Resultado é {division(a, b)}");
            }
            else
            {
                Console.WriteLine("Ainda não temos essa função. Escolha de 1 a 4");
            }
                Console.WriteLine("Deseja continuar? Sim - Y Não - Qualquer caracter");
                string next = Console.ReadLine();
                if (next == "Y" || next == "y")
                {
                    init = true;
                }
                else {
                    init = false;
                }
            }

        }
        static int soma(int a, int b)
        {
            return a + b;
        }
        static int subtracao(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacao(int a, int b)
        {
            return a * b;
        }
        static int division(int a, int b)
        {
            return a / b;
        }
    }
}