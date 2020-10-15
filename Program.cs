using System;
using System.Numerics;

namespace Вычисление_факториала
{
    class Program
    {
        static void Table(BigInteger num, string left, string middle, string right)
        {
            Console.Write(left);
            if (middle == "")
                Console.Write(num);
            else
            {
                for (int i = 0; i < num.ToString().Length; i++)
                    Console.Write(middle);
            }
            Console.WriteLine(right);
        }
        static BigInteger CalculateFactorial(BigInteger num)
        {

            var factorial = new BigInteger(1);
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
                BigInteger num;
                Console.Write("Введите целое число:");
                while (!BigInteger.TryParse(Console.ReadLine(), out num))
                    Console.WriteLine("Ошибка!");
                Table(CalculateFactorial(num), "╔", "═", "╗");
                Table(CalculateFactorial(num), "║", "", "║");
                Table(CalculateFactorial(num), "╚", "═", "╝");
         
        }
    }
}




      //  int n = int.parse(console.readline());