using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.WriteLine("请输入三个数的值：");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(b, 2) - 4 * a * c >= 0)
            {
                Console.WriteLine("x1=" + (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
                Console.WriteLine("x2=" + (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
            }
            else
            {
                Console.WriteLine("此方程无解！！！");
            }
            Console.ReadKey();

        }
    }
}
