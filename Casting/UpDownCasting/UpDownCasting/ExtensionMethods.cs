using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCasting
{
    public static class ExtensionMethods
    {
        public static bool CustomContains(this string word,string soz)
        {
            bool check = false;
            if (word.Contains(soz))
            {
                check = true;
                Console.WriteLine(check);
                return check;

            }
            else
            {
                Console.WriteLine(check);
                return check;

            }

        }
        public static bool CustomContains(this string word, char letter)
        {
            bool check = false;
            foreach (var item in word)
            {
                if (item == letter)
                {
                    check = true;
                    Console.WriteLine(check);
                    return check;

                }
            }
            Console.WriteLine(check);
            return check;
        }
       public static bool IsPrime(this int number)
        {
            bool check = false;
            int counter = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                check = true;
                Console.WriteLine(check);
                return check;

            }
            else
            {
                Console.WriteLine(check);
                return check;

            }
        }
    }
}

               
            