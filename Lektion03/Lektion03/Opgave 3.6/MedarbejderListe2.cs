using System;
using System.Collections.Generic;

namespace Lektion03.Opgave3
{
    public class MedarbejderListe2<TKey>
    {
        private readonly Dictionary<TKey, Medarbejder2> _collection = new Dictionary<TKey, Medarbejder2>();

        public void AddElement(TKey k, Medarbejder2 m)
        {
            _collection.Add(k, m);
        }

        public Medarbejder2 GetElement(TKey k)
        {
            return _collection[k];
        }

        public int Size()
        {
            return _collection.Count;
        }
    }
}
