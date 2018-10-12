using System;
using System.Collections.Generic;
using System.Linq;

namespace StringUniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var str1 = "ABCDEF";
            Console.WriteLine(str1);
            Console.WriteLine(IsCharactersUniqueWith2Loops(str1));
            Console.WriteLine(IsCharactersUniqueWithHashSet(str1));
            Console.WriteLine(IsCharactersUniqueWithSorting(str1));

            var str2 = "ABCDEE";
            Console.WriteLine(str2);
            Console.WriteLine(IsCharactersUniqueWith2Loops(str2));
            Console.WriteLine(IsCharactersUniqueWithHashSet(str2));
            Console.WriteLine(IsCharactersUniqueWithSorting(str2));

            Console.ReadLine();
        }

        public static bool IsCharactersUniqueWith2Loops(string str)
        {
            if (String.IsNullOrEmpty(str))
                return false;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        return false;
                }
            }
            return true;
        }

        public static bool IsCharactersUniqueWithHashSet(string str)
        {
            if (String.IsNullOrEmpty(str))
                return false;
            var set = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (set.Contains(str[i]))
                    return false;
                else
                    set.Add(str[i]);
            }
            return true;
        }


        public static bool IsCharactersUniqueWithSorting(string str)
        {
            if (String.IsNullOrEmpty(str))
                return false;
            var characters = str.ToArray();
            Array.Sort(characters);
            var sortedString = new string(characters);

            for (int i = 0; i < sortedString.Length - 1; i++)
            {
                if (sortedString[i] == sortedString[i + 1])
                    return false;
            }
            return true;
        }

    }
}
