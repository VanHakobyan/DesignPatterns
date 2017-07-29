using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorBank
{
    internal class Bank : IEnumerable
    {
        List<Banknote> bankValut = new List<Banknote> {
            new Banknote(),
            new Banknote(),
            new Banknote(),
            new Banknote()
        };
        public Banknote this[int index]
        {
            get { return bankValut[index]; }
            set { bankValut.Insert(index, value); }
        }
        public IEnumerator GetEnumerator()
        {
            return new Casher(this);
        }
        public int count
        {
            get { return bankValut.Count; }
        }
    }
}