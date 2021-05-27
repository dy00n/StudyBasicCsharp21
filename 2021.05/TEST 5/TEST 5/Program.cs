using System;

namespace TEST_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!");

            for (int i = 0; i < 100; i++)
            {
                if (i > 10)
                {
                    if ((i / 10) % 3 == 0) { Console.Write("짝! "); }

                    else
                    {
                        if ((i % 10) == 0) Console.Write(i + " ");
                        else
                        {
                            if ((i % 10) % 3 == 0) Console.Write("짝! ");
                            else Console.Write(i + " ");
                        }
                    }
                }
                else
                {
                    if (i % 3 == 0) Console.Write("짝! ");
                    else Console.Write(i + " ");
                }
            }

        }
    }
}
