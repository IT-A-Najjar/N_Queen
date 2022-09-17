using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N_QuanHau
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("enter the number n>3: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Queens q = new Queens(n);
                if (q.Solve(0))
                    q.Display();
                else
                    Console.WriteLine("the array is empte");

                Console.WriteLine("enter agen:");
                Console.ReadKey();
            }
        }
    }
}
