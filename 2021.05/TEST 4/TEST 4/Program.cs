using System;

namespace TEST_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7단 계산 시작");
            for (int i = 7; i < 8; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}*{j}={i * j} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("8단 계산 시작");
            for (int i = 8; i < 9; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}*{j}={i * j} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("9단 계산 시작");
            for (int i = 9; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}*{j}={i * j} ");
                }
            }
        }
    }
}
