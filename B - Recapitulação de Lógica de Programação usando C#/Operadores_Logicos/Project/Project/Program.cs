﻿namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10; //False
            bool c2 = a < 20; //True
            bool c3 = a > 10; //False
            bool c4 = a > 5; //True
            Console.WriteLine(c1); Console.WriteLine(c2); Console.WriteLine(c3); Console.WriteLine(c4);
            Console.WriteLine("----------------------");
            bool c5 = a <= 10;  //True
            bool c6 = a >= 10; //True
            bool c7 = a == 10; //True
            bool c8 = a != 10; //False
            Console.WriteLine(c5); Console.WriteLine(c6); Console.WriteLine(c7); Console.WriteLine(c8);

            
        }
    }
}