using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalApp
{
    public class Calc
    {
        public void Add(double n1, double n2) {
            Console.WriteLine("Result After Addition: \t"+(n1+n2));
        }
        public void Sub(double n1, double n2)
        {
            Console.WriteLine("Result After Sub: \t" + (n1 - n2));
        }
        public void Mul(double n1, double n2)
        {
            Console.WriteLine("Result After Mul: \t" + (n1 * n2));
        }
        public void Div(double n1, double n2)
        {
            Console.WriteLine("Result After Div: \t" + (n1 / n2));
        }
    }
}
