using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorBank
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable bank = new Bank();
            IEnumerator cashier = bank.GetEnumerator();
            while (cashier.MoveNext())
            {
                Banknote banknote = cashier.Current as Banknote;
                Console.WriteLine(banknote.Nominal);
            }
        }
    }
}
