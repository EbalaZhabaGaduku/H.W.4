using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,  s;
            N = Convert.ToInt32(Console.ReadLine());
            
            s = 0;
            for (int i =1; i < N; i++)
            {
                s += (2 * i - 1);
            }

            Console.WriteLine("Квадрат числа N="+s);
            Console.ReadKey();

        }

    }
}