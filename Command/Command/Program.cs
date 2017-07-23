using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int resulit;

            resulit = calculator.Add(5);
            Console.WriteLine("resulit is "+ resulit);

            resulit = calculator.Sub(2);
            Console.WriteLine("resulit is " + resulit);

            resulit = calculator.Div(2);
            Console.WriteLine("resulit is " + resulit);

            resulit = calculator.Mul(12);
            Console.WriteLine("resulit is " + resulit);
        }
    }
}
