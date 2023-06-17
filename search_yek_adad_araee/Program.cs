using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_yek_adad_araee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int number, temp = -1, counter = 0;
            Console.WriteLine("please enter array elements:");
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine("element [{0},{1}] = ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("please enter number for search:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j <= 9; j++)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (array[i, j] == number)
                    {
                        temp = i;
                        counter++;
                    }

                }
            }
            if (temp == -1)
            {
                Console.WriteLine("number not found!");
            }
            else
            {
                Console.WriteLine("number found!");
            }
            Console.WriteLine("counter = {0}", counter);

            Console.ReadKey();
        }
    }
}
