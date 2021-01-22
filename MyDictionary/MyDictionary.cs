using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tvalue, Tkey>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey siralamaItem, Tvalue burcItem)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = siralamaItem;
            values[values.Length - 1] = burcItem;

            public int Length
        {
            get { return keys.Length; }
        }

        public Tkey[] Keys
        {
            get { return keys; }
        }

        public Tvalue[] Values
        {
            get { return values; }
        }
    }
    }
}
