namespace Exercicios3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira sua senha: ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Tente novamente");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Registre o cosumo de hoje: 1.Alcool 2.Gasolina 3.Diesel 4.fim");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 4)
            {
                if (choice == 1)
                {
                    alcool += 1;
                }
                else if(choice == 2)
                {
                    gasolina += 1;
                }
                else if(choice == 3)
                {
                    diesel += 1;
                }
                choice = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"gasolina: {gasolina}");
            Console.WriteLine($"diesel: {diesel}");
        }
    }
}