using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write(" B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write(" C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int gor = 0;
            int vert = 0;
            int rezult = 0;
            while (A >= C)
            {
                A -= C;
                gor++; 
            }
            while (B >= C)
            {
                B -= C;
                vert++; 
            }
            
            for (int i = 0; i < vert; i++)
                rezult += gor;
            Console.WriteLine("Кол-во квадратов - " + rezult);
            Console.ReadKey();
        }
    }
}
