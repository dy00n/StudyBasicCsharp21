using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("값을 입력하세요 : ");
                string input = Console.ReadLine();
                float result = float.Parse(input); //예외발생
                Console.WriteLine($"입력된 값은  {result} 입니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.StackTrace}");
            }
            
            //곱셈
            /*for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
            }*/
        }
    }
}
