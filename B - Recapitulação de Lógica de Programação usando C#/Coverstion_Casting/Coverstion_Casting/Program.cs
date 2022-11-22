namespace Coverstion_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão implicita correta
            float x = 4.5f; //Tem 4 Bytes
            double y = x; //Tem 8 Bytes então o float de 4 bytes cabe.
            // Conversão Casting
            double a = 5.1;
            float b = (float)a; // Conversão por casting definindo o float e assumindo possivel perda

            // Casting com perda de informação
            double dec = 5.1;
            int inteiro = (int)dec; //Os valores decimais vão ser truncados
            Console.WriteLine(inteiro);

            //Exemplo do funcionamento da linguagem
            int n1 = 5;
            int n2 = 2;
            double result = a / b;
            Console.WriteLine(result);



        }
    }
}