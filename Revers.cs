using System;

namespace Revers
{
    class Solution
    {

        public static int Reverse(int x)
        {
            int rev = 0;
            while (x > 0)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }
            return rev;
        }

        static void Main(String[] args)
        { 
              string str1;
              int to;

              Console.Write(" Укажите Числа : ");
              str1 = Console.ReadLine();
              to = Convert.ToInt32(str1);

                Console.Write("Числа в реверсе"
                        + Reverse(to));
        }
    }
}
