using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achieve
{
    public class Class1
    {
        public Double Add(Double a,Double b)
        {
            Double c= a + b;
            return c;
        }
        public Double Multi(Double a, Double b)
        {
            Double c = a * b;
            return c;
        }
        public Double Divi(Double a,Double b)
        {
            Double c = a / b;
            return c;
        }
        public Double Sub(Double a,Double b)
        {
            Double c = a - b;
            return c;
        }
        public Double Surplus(Double a,Double b) //求余
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return a%b;
            }
            
        }
        public Double Square(Double a) //平方
        {
            return a * a;
        }
        public String Equation(Double a,Double b,Double c)
        {
            String result;
           
            if (Math.Pow(b, 2) - 4 * a * c >= 0)
            {
                
                Double x1= (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a ;
                Double x2=(-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a ;

                result = "x1=" + x1.ToString() + "     x2=" + x1.ToString();
               
            }
            else
            {
                result = "此方程无解";
            }
            return result;
           
        }
    }
}
