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
            bool intResult = C1.ToCheck(15, 15);
            Console.WriteLine("Int Result = {0}", intResult);

            Check1<double> C2 = new Check1<double>();
            bool doubleResult = C1.ToCheck(1514141, 16512215);
            Console.WriteLine("Double Result = {0}", doubleResult);
            Console.WriteLine("");
            
            Check2<string> C3 = new Check2<string>();
            bool stringResult = C3.ToCheck("Theo", "Theo");
            Console.WriteLine("String Result = {0}", stringResult);


            Check2<float> C4 = new Check2<float>();
            bool floatResult = C4.ToCheck(241421421, 24214124);
            Console.WriteLine("Float Result = {0}", floatResult);













            Console.ReadKey();
        }
    }
}
