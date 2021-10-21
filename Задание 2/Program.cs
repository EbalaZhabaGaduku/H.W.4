using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kP =0;
            int kO=0;
            int buf;
            do
            {
                buf = Convert.ToInt32(Console.ReadLine());
                if (buf>0)
                {
                    kP+=1;
                }
                else if(buf<0)
                {
                    kO+=1;
                }
               
            } while (buf!=0);
            Console.WriteLine("Кол-во положительных чисел - {0},Кол-во отрицательных чисел - {1}",kP,kO);
            Console.ReadKey();
           

        }
    }
}
