namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char genero = 'F'; // Tipo char é unicode e deve ser posto em aspas simples, posso colocar também o codigo unicode
            char letra = '\u0041'; // Passando \u e o codigo unicode
            bool completo = false; // Tipo bool é true or false
            byte n1 = 126; // Tipo Byte aceita só até 126 sem sinal
            int n2 = 1000; // Numeros inteiros
            int n3 = 2147483647; // Esse é o maior numéro que o tipo int aceita
            long n4 = 3147483647L; // É recomendado colocar um L no final quando trabalhar com o Tipo long
            float n5 = 4.5f; //Para definir float coloco F no final
            double n6 = 4.5; //Caso não coloque o C# indentifica como double
            string name = "Maria Green"; // Para cadeia de caracteres é aspas duplas, é imutavel.
            object obj1 = "Alex Brown"; // É um objeto genérico, todas as classes são um Object
            object obj2 = 4.5f;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(name);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            // Funções para valores minimos e máximos
            int int1 = int.MinValue;
            int int2 = int.MaxValue;

            Console.WriteLine(int2);
            Console.WriteLine(int1);
        }
    }
}