using System;

namespace FlexibleList
{
    internal class FlexibleList
    {
        private int[] _numbers;
        private int _index;

        public FlexibleList()
        {
            _numbers = new int[4];
            _index = 0;
        }
        public void Add(string numberStr)
        {
            var number = Convert.ToInt32(numberStr);
            Add(number);
        }

        public void Add(int number)
        {
            if (_index >= _numbers.Length)
            {
                Console.WriteLine($"Dobler kapasitet til {_numbers.Length * 2}");
                var newNumbers = new int[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[_index] = number;
            _index++;
        }

        public string Get()
        {
            return "Tallene er: " + string.Join(',', _numbers);
        }
    }
}
