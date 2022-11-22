namespace Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            //string s = Console.ReadLine();
            string[] vetors = Console.ReadLine().Split(' ');
            string v1 = vetors[0];
            string v2 = vetors[1];
            string v3 = vetors[2];
            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);

        }
    }
}