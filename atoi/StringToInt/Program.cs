using System;

namespace StringToInt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("857"));
            Console.ReadLine();
        }

        public static int MyAtoi(string str)
        {
            int res = 0;
            var index = 0;
            while (index < str.Length)
            {
                res = res * 10 + str[index] - '0';
                index++;
            }
            return res;
        }

    }
}
