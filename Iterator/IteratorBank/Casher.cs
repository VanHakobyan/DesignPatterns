using System;
using System.Collections;

namespace IteratorBank
{
    internal class Casher : IEnumerator
    {
        private Bank bank;
        int current = -1;
        public Casher(Bank bank)
        {
            this.bank = bank;
        }

        public object Current
        {
            get { return bank[current]; }
        }

        public bool MoveNext()
        {
            if (current < bank.count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}