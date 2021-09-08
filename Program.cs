using System;

namespace NullableParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable Parameter");
            Console.WriteLine("--------------------------------------------");
            NullableMethod();
            NonNullableMethod();
        }
        public static void NullableMethod()
        {


            Nullable<int> n = null;
            Console.WriteLine("ByDefault value of Nullable ");
            Console.WriteLine(n.GetValueOrDefault());


            int? n1 = null;
            Console.WriteLine("value of Nullable variable n1");
            Console.WriteLine(n1.GetValueOrDefault());
        }
        public static void NonNullableMethod()
        { 
            int? n1 = 10;
            Console.WriteLine("Nullable value of n1");
            Console.WriteLine(n1.GetValueOrDefault());

            Nullable<int> n2 = 50;
            Console.WriteLine("Nullable value of n1");
            Console.WriteLine(n2.GetValueOrDefault());

        }
    }
}
