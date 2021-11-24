using System;
using System.Collections.Generic;

namespace Labb_5__Generic_class_
{
    public class Check<T>
    {
        public static bool ToCheck(T num1, T num2)
        {
            return num1.Equals(num2);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Check1<int> C1 = new Check1<int>();
            bool intResult1 = C1.ToCheck(15, 15);
            Console.WriteLine("Int Result 1 = {0}", intResult1);

            Check1<int> C2 = new Check1<int>();
            bool intResult2 = C1.ToCheck(15, 16);
            Console.WriteLine("Int Result 2 = {0}", intResult2);
            Console.WriteLine("");
            Check2<string> C3 = new Check2<string>();
            bool stringResult1 = C3.ToCheck("Theo", "Kalle");
            Console.WriteLine("String Result 1 = {0}", stringResult1);


            Check2<string> C4 = new Check2<string>();
            bool stringResult2 = C4.ToCheck("Theo", "Theo");
            Console.WriteLine("String Result 2 = {0}", stringResult2);













            Console.ReadKey();
        }
    }
}
