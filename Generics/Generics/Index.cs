using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Index<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _dictionary;
        private List<TValue> _values;

        public Index()
        {
            _dictionary = new Dictionary<TKey, TValue>();
            _values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
            _values.Add(item);
        }

        public void  Remove(TKey key)
            {
            if (!_dictionary.ContainsKey(key))
                return;

            var value = _dictionary[key];

            _values.Remove(value);
        }

        public IEnumerable<TValue> Find(Predicate <TValue> predicate)

        {
            return _values.FindAll(predicate);
        }
 
        public TValue this [TKey key]
        {
            get
            {
                return _dictionary[key];
            }
        }
    }
}
