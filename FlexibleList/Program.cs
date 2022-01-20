using System;
using System.Collections.Generic;

namespace FlexibleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lists = new List<List<int>> { new(), new(), new() };

            while (true)
            {

                Console.Write("Velg en liste (a, b eller c): ");
                var listName = Console.ReadLine();
                var listChar = listName[0];
                var listIndex = listChar - 'a';
                var list = lists[listIndex];

                Console.Write("Skriv et tall: ");
                var numberOrCommand = Console.ReadLine();
                if (numberOrCommand.StartsWith("-"))
                {
                    var index = Convert.ToInt32(numberOrCommand.Substring(1));
                    list.RemoveAt(index);
                }
                else
                {
                    var number = Convert.ToInt32(numberOrCommand);
                    list.Add(number);
                }

                Console.WriteLine("A: " + string.Join(' ', lists[0]));
                Console.WriteLine("B: " + string.Join(' ', lists[1]));
                Console.WriteLine("C: " + string.Join(' ', lists[2]));
            }
        }

        // innebygget liste
        //static void Main(string[] args)
        //{
        //    var list = new List<bool>();
        //    while (true)
        //    {
        //        Console.Write("Skriv et tall: ");
        //        var numberOrCommand = Console.ReadLine();
        //        if (numberOrCommand.StartsWith("-"))
        //        {
        //            var index = Convert.ToInt32(numberOrCommand.Substring(1));
        //            list.RemoveAt(index);
        //        }
        //        else
        //        {
        //            var number = Convert.ToBoolean(numberOrCommand);
        //            list.Add(number);
        //        }

        //        Console.WriteLine(string.Join(' ', list));
        //    }
        //}


        //generic-liste
        //static void Main(string[] args)
        //{
        //    var list = new FlexibleList<int>();
        //    while (true)
        //    {
        //        Console.Write("Skriv et tall: ");
        //        var numberOrCommand = Console.ReadLine();
        //        if (numberOrCommand.StartsWith("-"))
        //        {
        //            var index = Convert.ToInt32(numberOrCommand.Substring(1));
        //            list.Remove(index);
        //        }
        //        else
        //        {
        //            var number = Convert.ToInt32(numberOrCommand);
        //            list.Add(number);
        //        }

        //        Console.WriteLine(list.Get());
        //    }
        //}


        /*
         int-liste
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
