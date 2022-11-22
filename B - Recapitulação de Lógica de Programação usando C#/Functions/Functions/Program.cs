namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine($"O Maior é {resultado}");
        }

        static int/*essa é a saida da função*/ Maior(int a,int b,int c)/*Defino o tipo da entrada*/
        {
            int m;

            if (a > b && a > c)
            {
                m = a;   
            }else if(b > c){
                m = b;
            }
            else
            {
               m = c;
            }
            return m; 
        }


    }
}