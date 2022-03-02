using System;
using System.Collections.Generic;

namespace Lektion03.Opgave3
{
    public class MedarbejderListe<TKey>
    {
        private readonly Dictionary<TKey, Medarbejde2r> _collection = new Dictionary<TKey, Medarbejde2r>();

        public void AddElement(TKey k, Medarbejde2r m)
        {
            _collection.Add(k, m);
        }

        public Medarbejde2r GetElement(TKey k)
        {
            return _collection[k];
        }

        public int Size()
        {
            return _collection.Count;
        }
    }
}
