using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07.CentsRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter amount:");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount == 0)
            {
                Console.WriteLine("Amount 0, no combinations available");
                return;
            }

            //quarters (25 cents), dimes (10 cents), nickels (5 cents) and pennies (1 cent)

            for (int i = 0; i <= amount / 25; i++)
            {
                for (int j = 0; j <= amount / 10; j++)
                {
                    for (int k = 0; k <= amount / 5; k++)
                    {
                        for (int m = 0; m <= amount / 1; m++)
                        {
                            var current = i * 25 + j * 10 + k * 5 + m * 1;
                            if (current == amount)
                            {
                                Console.Write($"({i} {j} {k} {m}) ");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
