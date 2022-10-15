using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, i, e=1, r1=1, r2, w;
            Console.WriteLine("Введите натуральное число");
            bool f = int.TryParse(Console.ReadLine(), out a);
            string q = a.ToString();
            if (a > 1 && f )
            {
                for (i = 1; i < q.Length; i++)
                {
                    e = e * 10;
                    r1 = a / e;
                }
                r2 = a % 10;
                w = a - r1 * e + r2*e -r2+r1;
                Console.WriteLine("Преобразованное число = {0}", w);
            }
        }
    }
}
