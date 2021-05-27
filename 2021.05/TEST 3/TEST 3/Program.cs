using System;

namespace TEST_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int y=0; y<11; y++)
            {
                Console.WriteLine();
                for(int x=0; x<y+1; x++)
                {
                    if (y == 5) continue;
                    else Console.Write("*");
                }
            }
        }
    }
}
