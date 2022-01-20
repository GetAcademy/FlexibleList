using System;

namespace FlexibleList
{
    internal class FlexibleList<T>
    {
        private T[] _values;
        private int _index;

        public FlexibleList()
        {
            _values = new T[4];
            _index = 0;
        }

        public void Remove(int index)
        {
            for (var i = index; i < _values.Length-1; i++)
            {
                _values[i] = _values[i+1];
            }

            _values[_index-1] = default(T);
            _index--;
        }

        //public void Add(string numberStr)
        //{
        //    var value = Convert.ToInt32(numberStr);
        //    Add(value);
        //}

        public void Add(T value)
        {
            if (_index >= _values.Length)
            {
                Console.WriteLine($"Dobler kapasitet til {_values.Length * 2}");
                var newValues = new T[_values.Length * 2];
                Array.Copy(_values, newValues, _values.Length);
                _values = newValues;
            }
            _values[_index] = value;
            _index++;
        }

        public string Get()
        {
            return "Tallene er: " + string.Join('-', _values);
        }
    }
}
