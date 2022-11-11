namespace Operadores_aritimeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);
            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);
            int n3 = 17 % 3;
            Console.WriteLine(n3);
            double n4 = (double) 10 / 8; //Posso colocar 10.0 para retornar um double também
            Console.WriteLine(n4);

            // Formula de Baskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b,2.0) - 4.0 * a * c; //Para potencias posso usar Math.Pow
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Para raiz uso Math.Sqrt
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); //Para raiz uso Math.Sqrt
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}