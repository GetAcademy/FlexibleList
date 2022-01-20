using System;

namespace FlexibleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new FlexibleList<bool>();
            while (true)
            {
                Console.Write("Skriv et tall: ");
                var numberOrCommand = Console.ReadLine();
                if (numberOrCommand.StartsWith("-"))
                {
                    var index = Convert.ToInt32(numberOrCommand.Substring(1));
                    list.Remove(index);
                }
                else
                {
                    var number = Convert.ToBoolean(numberOrCommand);
                    list.Add(number);
                }

                Console.WriteLine(list.Get());
            }
        }

        /*
        static void Main(string[] args)
        {
            var initialLength = 4;
            var numbers = new int[initialLength];
            var index = 0;
            while (true)
            {
                Console.Write("Skriv en bokstavtall: ");
                Console.Write("Skriv et tall: ");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                if (index >= numbers.Length)
                {
                    Console.WriteLine($"Dobler kapasitet til {numbers.Length * 2}");
                    var newNumbers = new int[numbers.Length * 2];
                    Array.Copy(numbers, newNumbers, numbers.Length);
                    numbers = newNumbers;
                }

                numbers[index] = number;
                Console.WriteLine("Tallene er: " + string.Join(',', numbers));
                index++;
            }
        }         
         */
    }
}
